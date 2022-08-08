using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using Cadastro_De_Produtos.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Data.Repository
{
    public class Pesquisar_ProdutoRepository : Repository<Pesquisar_Produto>, IPesquisar_ProdutoRepository
    {
        public Pesquisar_ProdutoRepository(AppDbContext myDbContext) : base(myDbContext)
        {

            {
            }
        }
    }
}