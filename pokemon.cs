namespace ConsoleApp1
{
    internal class Program
    {
        public struct Pokemon
        {
            // Propiedades
            public string nombre { get; set; }
            public int nivel { get; set; }
            public int ps { get; set; }
            public int ataque { get; set; }
            public int defensa { get; set; }
            public int ae { get; set; }
            public int de { get; set; }
            public int velocidad { get; set; }
            public string estado { get; set; }

            // Constructor
            public Pokemon(string nombre, int nivel, int ps, int ataque, int defensa, int ae, int de, int velocidad, string estado)
            {
                this.nombre = nombre;
                this.nivel = nivel;
                this.ps = ps;
                this.ataque = ataque;
                this.defensa = defensa;
                this.ae = ae;
                this.de = de;
                this.velocidad = velocidad;
                this.estado = estado;
            }
        }

        public struct Entrenador
        {
            // Propiedades
            public string nombre { get; set; }
            public int pokedolares { get; set; }
            public string[] medallas { get; set; }
            public Pokemon[] equipo { get; set; }

            // Constructor
            public Entrenador(string nombre, int pokedolares, string[] medallas, Pokemon[] equipo)
            {
                this.nombre = nombre;
                this.pokedolares = pokedolares;
                this.medallas = medallas;
                this.equipo = equipo;
            }

            public int damenivel()
            {
                int retorno = 0;

                for (int i = 0; i < equipo.Length; i++)
                {
                    retorno += equipo[i].nivel;
                }

                return retorno;
            }

            public void ComprarPocion()
            {
                if (pokedolares >= 200)
                {
                    pokedolares -= 200;
                    Console.WriteLine(nombre + " compró una poción.");
                    Console.WriteLine("Pokedólares restantes: " + pokedolares);
                }
                else
                {
                    Console.WriteLine(nombre + " no pudo comprar la poción.");
                }
            }

            public int CantidadMedallas()
            {
                int cantidad = 0;

                for (int i = 0; i < medallas.Length; i++)
                {
                    if (medallas[i] != null && medallas[i] != "")
                    {
                        cantidad++;
                    }
                }

                return cantidad;
            }

            public int CantidadAlterados()
            {
                int cantidad = 0;

                for (int i = 0; i < equipo.Length; i++)
                {
                    if (equipo[i].estado != "Normal")
                    {
                        cantidad++;
                    }
                }

                return cantidad;
            }
        }

        static void Main(string[] args)
        {
            // Equipo 1
            Pokemon[] equipo1 = new Pokemon[]
            {
                new Pokemon("Pikachu",50,150,90,55,110,50,90,"Parálisis"),
                new Pokemon("Charizard",55,180,84,78,109,85,100,"Normal"),
                new Pokemon("Blastoise",52,175,83,100,85,105,78,"Normal"),
                new Pokemon("Venusaur",51,170,82,83,100,100,80,"Veneno"),
                new Pokemon("Snorlax",48,160,110,65,55,55,45,"Normal"),
                new Pokemon("Gengar",50,130,65,60,130,110,110,"Normal")
            };

            // Equipo 2
            Pokemon[] equipo2 = new Pokemon[]
            {
                new Pokemon("Dragonite",52,160,134,95,70,100,80,"Normal"),
                new Pokemon("Alakazam",50,140,50,70,135,115,120,"Dormido"),
                new Pokemon("Gyarados",49,200,130,60,95,85,65,"Normal"),
                new Pokemon("Rhydon",53,155,110,96,83,85,45,"Normal"),
                new Pokemon("Jolteon",50,135,110,100,50,70,130,"Normal"),
                new Pokemon("Starmie",51,145,105,75,100,90,115,"Normal")
            };

            string[] medallas1 =
            { "Roca", "Cascada", "Trueno", "Arcoiris", "Alma", "Pantano", "Volcan", "Tierra"};

            string[] medallas2 =
            { "Roca", "Cascada", "Trueno", "Arcoiris", "", "", "", ""};

            Entrenador entrenador1 = new Entrenador("Ash", 500, medallas1, equipo1);
            Entrenador entrenador2 = new Entrenador("Pepe", 100, medallas2, equipo2);

            Console.WriteLine("[Comparación de nivel]");

            if (entrenador1.damenivel() > entrenador2.damenivel())
            {
                Console.WriteLine(entrenador1.nombre + " tiene más nivel.");
            }
            else if (entrenador2.damenivel() > entrenador1.damenivel())
            {
                Console.WriteLine(entrenador2.nombre + " tiene más nivel.");
            }
            else
            {
                Console.WriteLine("Tienen el mismo nivel.");
            }

            Console.WriteLine();

            // Comprar poción
            Console.WriteLine("[Comprar poción]");
            entrenador1.ComprarPocion();
            entrenador2.ComprarPocion();

            Console.WriteLine();

            // Comparar medallas
            Console.WriteLine("[Comparación de medallas]");

            if (entrenador1.CantidadMedallas() > entrenador2.CantidadMedallas())
            {
                Console.WriteLine(entrenador1.nombre + " tiene más medallas.");
            }
            else if (entrenador2.CantidadMedallas() > entrenador1.CantidadMedallas())
            {
                Console.WriteLine(entrenador2.nombre + " tiene más medallas.");
            }
            else
            {
                Console.WriteLine("Ambos tienen la misma cantidad de medallas.");
            }

            Console.WriteLine();

            // Comparar Pokémon con estado alterado
            Console.WriteLine("[Estados alterados]");

            if (entrenador1.CantidadAlterados() > entrenador2.CantidadAlterados())
            {
                Console.WriteLine(entrenador1.nombre + " tiene más Pokémon con estado alterado.");
            }
            else if (entrenador2.CantidadAlterados() > entrenador1.CantidadAlterados())
            {
                Console.WriteLine(entrenador2.nombre + " tiene más Pokémon con estado alterado.");
            }
            else
            {
                Console.WriteLine("Ambos tienen la misma cantidad de Pokémon con estado alterado.");
            }
        }
    }
}