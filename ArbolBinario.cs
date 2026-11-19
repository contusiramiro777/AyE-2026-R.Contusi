using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_en_BDD
{
    internal class ArbolBinario
    {
        public Nodo raiz;

        public void Insertar(Pokemon pokemon)
        {
            raiz = Recursiva(raiz, pokemon);
        }
        public Nodo Recursiva(Nodo nodo, Pokemon pokemon)
        {
            if (nodo == null)
            {
                return new Nodo(pokemon);
            }

            if (pokemon.ID < nodo.Pokemon.ID)
            {
                nodo.Izquierda = Recursiva(nodo.Izquierda, pokemon);
            }
            else
            {
                nodo.Derecha = Recursiva(nodo.Derecha, pokemon);
            }

            return nodo;
        }


        public void Mostrar()
        {
            Mostrarr(raiz);
        }
        public void Mostrarr(Nodo nodo)
        {
            if (nodo != null)
            {
                Mostrarr(nodo.Izquierda);
                nodo.Pokemon.Mostrar();
                Mostrarr(nodo.Derecha);
            }
        }


        public Pokemon Buscar(int id)
        {
            Nodo actual = raiz;

            while(actual != null)
            {
                if(id == actual.Pokemon.ID)
                {
                    return actual.Pokemon;
                }    
    
                if(id < actual.Pokemon.ID)
                {
                    actual = actual.Izquierda;
                }
                else
                {
                    actual = actual.Derecha;
                }
            }
            return null;
        }

        public void Limpiar()
        {
            raiz = null;
        }
    }
}
