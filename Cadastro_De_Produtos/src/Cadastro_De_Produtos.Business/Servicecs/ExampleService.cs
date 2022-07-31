using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using Cadastro_De_Produtos.Business.Models.Validations;

namespace Cadastro_De_Produtos.Business.Servicecs
{
    public class Cadastro_De_Produtos : BaseService, Cadastro_De_Produtos
    {

    }
        private readonly Cadastro_De_Produtos _Cadastro_De_Produtos;
        public ExampleService(ICadastro_De_Produtos exempleRepository, INotificator notificator, IUser user) : base(notificator)
        {
            _exempleRepository = exempleRepository;
            _user = user;
        }
        public async Task<bool> Adicionar(Example exemple)
        {
            if (!ExecutarValidacao(new ExampleValidation(), exemple)) return false;
            
            await _exempleRepository.Adicionar(exemple);
            return true;
        }

        public async Task<bool> Atualizar(Example exemple)
        {
            if (!ExecutarValidacao(new ExampleValidation(), exemple)) return false;

            await _exempleRepository.Atualizar(exemple);
            return true;
        }

        public async Task<bool> Remover(Guid id)
        {            
            await _exempleRepository.Remover(id);
            return true;
        }

        public void Dispose()
        {
            _exempleRepository?.Dispose();
        }

    }
}
