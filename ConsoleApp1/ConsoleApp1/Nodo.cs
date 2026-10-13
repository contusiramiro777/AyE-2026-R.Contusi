using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Nodo
    {
        public Agente valor { get; set; }
        public Nodo izquierdo { get; set; }
        public Nodo derecho { get; set; }

        public Nodo(Agente valor)
        {
            this.valor = valor;
            izquierdo = null;
            derecho = null;
        }
    }
}
