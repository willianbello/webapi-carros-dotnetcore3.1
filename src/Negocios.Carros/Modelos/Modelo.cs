using System;
using System.Collections.Generic;

namespace Negocios.Carros.Modelos
{
    public class Modelo : Entidade
    {
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public decimal Fipe { get; set; }
        public TipoCombustivel TipoCombustivel { get; set; }
        public IEnumerable<string> imagens { get; set; }

        /*EF Relacoes*/
        public Guid MarcaId { get; set; }
    }
}
