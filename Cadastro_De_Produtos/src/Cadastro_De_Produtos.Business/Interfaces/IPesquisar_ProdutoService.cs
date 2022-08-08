using Cadastro_De_Produtos.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Business.Interfaces
{
    public interface IPesquisar_ProdutoService :IDisposable
    {
        Task<bool> ObterPorId(Pesquisar_Produto pesquisar_produto );
    }
}
