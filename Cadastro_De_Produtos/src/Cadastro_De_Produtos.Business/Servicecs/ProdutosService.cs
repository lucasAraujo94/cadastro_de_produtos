using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Business.Servicecs
{
    public class ProdutosService : BaseService, IProdutosService

    {
        private readonly IProdutosRepository _produtosRepository;
        public ProdutosService(IProdutosRepository produtosRepository, INotificator notificator) : base(notificator)
        {
            _produtosRepository = produtosRepository;
        }
        public async Task<bool> Adicionar(Produtos produtos)
        {
            await _produtosRepository.Adicionar(produtos);
            return true;
        }

        public void Dispose()
        {
            _produtosRepository?.Dispose();
        }
    }
}
