using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_en_BDD
{
    internal class Nodo
    {
        public Pokemon Pokemon { get; set; }
        public Nodo Izquierda { get; set; }
        public Nodo Derecha { get; set; }

        public Nodo(Pokemon poke)
        {
            Pokemon = poke;
            Izquierda = null;
            Derecha = null;
        }
    }
}
