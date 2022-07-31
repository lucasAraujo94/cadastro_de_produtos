using System;
using System.Collections.Generic;
using System.Text;

namespace Cadastro_De_Produtos.Business.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
