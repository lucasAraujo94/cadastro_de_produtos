using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_De_Produtos.Business.Models
{
    public class Produtos : Entity
    {
        public string Nome { get ; set; }
        public string Medida  { get; set; }
        public string Descricao { get; set; }
        public int Codigo { get; set; }
    }
}
