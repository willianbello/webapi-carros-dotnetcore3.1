using System.Collections.Generic;

namespace Negocios.Carros.Models
{
    public class Brand : Entity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        /*EF Relacoes*/
        public IEnumerable<Model> Models { get; set; }
    }
}
