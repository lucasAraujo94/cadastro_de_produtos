﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Notifications;

namespace Cadastro_De_Produtos.Api.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly INotificator _notificator;
        public readonly IUser AppUser;
        private INotificator notificator;

        protected Guid UsuarioId { get; set; }
        protected bool UsuarioAutenticado { get; set; }
        public MainController(INotificator notificator, IUser appUser)
        {
            _notificator = notificator;
            AppUser = appUser;
        }

        protected MainController(INotificator notificator)
        {
            this.notificator = notificator;
        }

        protected bool OperacaoValida()
        {
            return !_notificator.HasNotification();
        }

        protected ActionResult CustomResponse(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notificator.GetNotifications().Select(n => n.Mensagem)
            });
        }

        protected ActionResult CustomResponse(ModelStateDictionary modelState)
        {
            if (!modelState.IsValid) NotificarErroModelInvalida(modelState);
            return CustomResponse();
        }

        protected void NotificarErroModelInvalida(ModelStateDictionary modelState)
        {
            var erros = modelState.Values.SelectMany(e => e.Errors);
            foreach (var erro in erros)
            {
                var errorMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(errorMsg);
            }
        }

        protected void NotificarErro(string mensagem)
        {
            _notificator.Handle(new Notification(mensagem));
        }
    }
}