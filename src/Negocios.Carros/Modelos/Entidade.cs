using System;

namespace Negocios.Carros.Modelos
{
    public abstract class Entidade
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; }

        protected Entidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
