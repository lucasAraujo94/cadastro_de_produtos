using Microsoft.AspNetCore.Identity;

namespace Cadastro_De_Produtos.Identity.Data
{
    public class CustomIdentity : IdentityUser
    {
        public string Nome { get; set; }
    }
}
