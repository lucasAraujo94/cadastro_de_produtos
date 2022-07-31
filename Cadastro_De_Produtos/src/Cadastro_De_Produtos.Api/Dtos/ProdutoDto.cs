using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Api.Dtos
{
    public class ProdutoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Medida { get; set; }
        public string Descriçao { get; set; }
        public int Codigo { get; set; }
    }
}
