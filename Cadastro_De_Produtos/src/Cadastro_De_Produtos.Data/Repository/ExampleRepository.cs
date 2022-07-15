using System;
using System.Collections.Generic;
using System.Text;
using Cadastro_De_Produtos.Business.Interfaces;
using Cadastro_De_Produtos.Business.Models;
using Cadastro_De_Produtos.Data.Context;

namespace Cadastro_De_Produtos.Data.Repository
{
    public class ExampleRepository : Repository<Example>, IExampleRepository
    {
        public ExampleRepository(AppDbContext myDbContext) : base(myDbContext)
        {

        }
    }
}
