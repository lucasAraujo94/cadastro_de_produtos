using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Business.Servicecs
{
    public class Pesquisar_Produto : BaseService, IPesquisar_Produto

    {
        private readonly IPesquisar_ProdutoRepository _pesquisar_produtoRepository;
        public Pesquisar_Produto(IPesquisar_ProdutoRepository pesquisar_produtoRepository, INotificator notificator) : base(notificator)
        {
            _pesquisar_produtoRepository = pesquisar_produtoRepository;
        }
        public async Task<bool> Adicionar(Pesquisar_Produto pesquisar_produto)
        {
            await _pesquisar_produtoRepository.Adicionar(pesquisar_produto);
            return true;
        }

        public void Dispose()
        {
            _pesquisar_produtoRepository?.Dispose();
        }
    }

    internal interface IPesquisar_Produto
    {
    }
}
