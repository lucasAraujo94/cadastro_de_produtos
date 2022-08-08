using Cadastro_De_Produtos.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Business.Interfaces
{
    public interface IPesquisar_ProdutoRepository : IPesquisar_Produto<Pesquisar_Produto>
    {
        Task Adicionar(Servicecs.Pesquisar_Produto pesquisar_produto);
    }
}
