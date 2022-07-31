using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_De_Produtos.Identity.Exensions
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public int ExpiracaoHoras { get; set; }
        public string Emissor { get; set; }
        public string ValidoEm { get; set; }
    }
}
