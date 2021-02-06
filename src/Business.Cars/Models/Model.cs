using System;
using System.Collections.Generic;

namespace Negocios.Carros.Models
{
    public class Model : Entity
    {
        public Guid BrandId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public decimal Fipe { get; set; }
        public TypeFuel TypeFuel { get; set; }
        public IEnumerable<string> Images { get; set; }

        /*EF Relacoes*/
        public Brand Brand { get; set; }
    }
}
