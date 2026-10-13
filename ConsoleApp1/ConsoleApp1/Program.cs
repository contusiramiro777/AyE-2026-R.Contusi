using System;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1

{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var db = new AppDbContext();

            // consulta todos los agentes

            Agente[] agentes =
                await db.agentes_valorant.ToArrayAsync();

            for (int i = 0; i < agentes.Length; i++)
            {
                Console.WriteLine(
                    agentes[i].id + " - " +
                    agentes[i].nombre_agente + " - " +
                    agentes[i].tipo_agente);
            }

            // crea el arbol binario

            ArbolBinario arbol = new ArbolBinario();

            for (int i = 0; i < agentes.Length; i++)
            {
                arbol.Insertar(agentes[i]);
            }

            // busca un agente por ID

            int id = 1;

            Agente buscado = arbol.Buscar(id);

            if (buscado != null)
            {
                Console.WriteLine(
                    "Agente encontrado: " +
                    buscado.nombre_agente);
            }
            else
            {
                Console.WriteLine("Agente no encontrado");
            }

            // ordena alfabeticamente

            OrdenarAlfabeticamente(agentes);

            Console.WriteLine("Agentes ordenados:");

            for (int i = 0; i < agentes.Length; i++)
            {
                Console.WriteLine(
                    agentes[i].nombre_agente);
            }
        }

        // agrega un agente

        static async Task AgregarAgente(Agente agente)
        {
            using var db = new AppDbContext();

            db.agentes_valorant.Add(agente);

            await db.SaveChangesAsync();
        }

        // actualiza un agente

        static async Task ActualizarAgente(int id)
        {
            using var db = new AppDbContext();

            var agente =
                await db.agentes_valorant.FindAsync(id);

            if (agente != null)
            {
                agente.tipo_agente = "Controlador";

                await db.SaveChangesAsync();
            }
        }

        // elimina un agente

        static async Task EliminarAgente(int id)
        {
            using var db = new AppDbContext();

            var agente =
                await db.agentes_valorant.FindAsync(id);

            if (agente != null)
            {
                db.agentes_valorant.Remove(agente);

                await db.SaveChangesAsync();
            }
        }

        // ordenamiento burbuja alfabetico

        static void OrdenarAlfabeticamente(Agente[] agentes)
        {
            for (int i = 0; i < agentes.Length - 1; i++)
            {
                for (int j = 0;
                    j < agentes.Length - 1 - i; j++)
                {
                    if (agentes[j].nombre_agente.CompareTo(
                        agentes[j + 1].nombre_agente) > 0)
                    {
                        Agente auxiliar = agentes[j];

                        agentes[j] = agentes[j + 1];

                        agentes[j + 1] = auxiliar;
                    }
                }
            }
        }
    }
}

