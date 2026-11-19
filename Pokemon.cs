using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB_en_BDD
{
    internal class Pokemon
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Tipo_1 { get; set; }
        public string? Tipo_2 { get; set; }
        public int Hp { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }
        public Pokemon()
        {

        }
        public Pokemon(int id, string N, string T1, string T2, int hp, int atk, int def, int atkE, int defE, int V, int NI)
        {
            ID = id;
            Nombre = N;
            Tipo_1 = T1;
            Tipo_2 = T2;
            Hp = hp;
            ataque = atk;
            defensa = def;
            ataque_especial = atkE;
            defensa_especial = defE;
            velocidad = V;
            nivel = NI;
        }
        
        public void Mostrar()
        {
            Console.WriteLine($"Pokemon: ID: {ID} | Nombre: {Nombre} | Tipo 1: {Tipo_1} | Tipo 2: {Tipo_2??("Nada")} | Vida: {Hp} | ataque: {ataque} | defensa: {defensa} | ataque especial: {ataque_especial} | defensa especial: {defensa_especial} | velocidad: {velocidad} | nivel: {nivel}");
        }
    }
}
