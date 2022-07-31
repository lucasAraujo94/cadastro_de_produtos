using AutoMapper;
using Cadastro_De_Produtos.Api.Dtos;
using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : MainController
    {
        private readonly IProdutosService _produtosService;
        private readonly IMapper _mapper;

        public ProdutosController(IProdutosService produtosService, IMapper mapper, INotificator notificator, IUser user) : base(notificator, user)
        {
            _produtosService = produtosService;
            _mapper = mapper;

        }
        [HttpPost]
        public async Task<ActionResult<ProdutoDto>> Adicionar(ProdutoDto produtoDto)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);
            await _produtosService.Adicionar(_mapper.Map<Produtos>(produtoDto));
            return CustomResponse(produtoDto);
        }
    }
}
