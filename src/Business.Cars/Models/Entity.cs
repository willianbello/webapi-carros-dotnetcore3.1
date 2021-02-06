using System;

namespace Negocios.Carros.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime DateUpdate { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
