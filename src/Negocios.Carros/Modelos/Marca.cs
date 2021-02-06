using System.Collections.Generic;

namespace Negocios.Carros.Modelos
{
    public class Marca : Entidade
    {
        public string Nome { get; set; }
        public string imagem { get; set; }

        /*EF Relacoes*/
        public IEnumerable<Modelo> Modelos { get; set; }
    }
}
