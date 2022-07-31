using System;
using System.Threading.Tasks;
using Cadastro_De_Produtos.Business.Models;

namespace Cadastro_De_Produtos.Business.Interfaces
{
    public interface IExampleService : IDisposable
    {
        Task<bool> Adicionar(Example exemple);
        Task<bool> Atualizar(Example exemple);
        Task<bool> Remover(Guid id);
    }
}