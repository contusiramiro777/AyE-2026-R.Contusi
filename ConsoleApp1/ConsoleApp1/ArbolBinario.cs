using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ConsoleApp1;

namespace ConsoleApp1
{
    public class ArbolBinario
    {
        public Nodo raiz { get; set; }

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(Agente agente)
        {
            Nodo nuevo = new Nodo(agente);

            if (raiz == null)
            {
                raiz = nuevo;
                return;
            }

            Nodo actual = raiz;

            while (true)
            {
                if (agente.id < actual.valor.id)
                {
                    if (actual.izquierdo == null)
                    {
                        actual.izquierdo = nuevo;
                        return;
                    }

                    actual = actual.izquierdo;
                }
                else
                {
                    if (actual.derecho == null)
                    {
                        actual.derecho = nuevo;
                        return;
                    }

                    actual = actual.derecho;
                }
            }
        }

        public Agente Buscar(int id)
        {
            Nodo actual = raiz;

            while (actual != null)
            {
                if (id == actual.valor.id)
                {
                    return actual.valor;
                }

                if (id < actual.valor.id)
                {
                    actual = actual.izquierdo;
                }
                else
                {
                    actual = actual.derecho;
                }
            }

            return null;
        }
    }
}