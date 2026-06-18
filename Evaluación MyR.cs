//Ejercicio1
{
   void Main(string[] args)
    {
        List<string> pokemones = new List<string> { "Bulbasaur", "Ivysaur", "Venusaur", "Charmander", "Charmeleon", "Charizard", "Squirtle", "Wartortle", "Blastoise", "Caterpie", "Metapod", "Butterfree", "Weedle", "Kakuna", "Beedrill", "Pidgey", "Pidgeotto", "Pidgeot", "Rattata", "Raticate", "Spearow", "Fearow", "Ekans", "Arbok", "Pikachu", "Raichu", "Sandshrew", "Sandslash", "Nidoran♀", "Nidorina", "Nidoqueen", "Nidoran♂", "Nidorino", "Nidoking", "Clefairy", "Clefable", "Vulpix", "Ninetales", "Jigglypuff", "Wigglytuff", "Zubat", "Golbat", "Oddish", "Gloom", "Vileplume", "Paras", "Parasect", "Venonat", "Venomoth", "Diglett", "Dugtrio", "Meowth", "Persian", "Psyduck", "Golduck", "Mankey", "Primeape", "Growlithe", "Arcanine", "Poliwag", "Poliwhirl", "Poliwrath", "Abra", "Kadabra", "Alakazam", "Machop", "Machoke", "Machamp", "Bellsprout", "Weepinbell", "Victreebel", "Tentacool", "Tentacruel", "Geodude", "Graveler", "Golem", "Ponyta", "Rapidash", "Slowpoke", "Slowbro", "Magnemite", "Magneton", "Farfetch'd", "Doduo", "Dodrio", "Seel", "Dewgong", "Grimer", "Muk", "Shellder", "Cloyster", "Gastly", "Haunter", "Gengar", "Onix", "Drowzee", "Hypno", "Krabby", "Kingler", "Voltorb", "Electrode", "Exeggcute", "Exeggutor", "Cubone", "Marowak", "Hitmonlee", "Hitmonchan", "Lickitung", "Koffing", "Weezing", "Rhyhorn", "Rhydon", "Chansey", "Tangela", "Kangaskhan", "Horsea", "Seadra", "Goldeen", "Seaking", "Staryu", "Starmie", "Mr. Mime", "Scyther", "Jynx", "Electabuzz", "Magmar", "Pinsir", "Tauros", "Magikarp", "Gyarados", "Lapras", "Ditto", "Eevee", "Vaporeon", "Jolteon", "Flareon", "Porygon", "Omanyte", "Omastar", "Kabuto", "Kabutops", "Aerodactyl", "Snorlax", "Articuno", "Zapdos", "Moltres", "Dratini", "Dragonair", "Dragonite", "Mewtwo", "Mew" };
        List<string> tipos = new List<string> { "Grass", "Grass", "Grass", "Fire", "Fire", "Fire", "Water", "Water", "Water", "Bug", "Bug", "Bug", "Bug", "Bug", "Bug", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Normal", "Poison", "Poison", "Electric", "Electric", "Ground", "Ground", "Poison", "Poison", "Poison", "Poison", "Poison", "Poison", "Fairy", "Fairy", "Fire", "Fire", "Normal", "Normal", "Poison", "Poison", "Grass", "Grass", "Grass", "Bug", "Bug", "Bug", "Bug", "Ground", "Ground", "Normal", "Normal", "Water", "Water", "Fighting", "Fighting", "Fire", "Fire", "Water", "Water", "Water", "Psychic", "Psychic", "Psychic", "Fighting", "Fighting", "Fighting", "Grass", "Grass", "Grass", "Water", "Water", "Rock", "Rock", "Rock", "Fire", "Fire", "Water", "Water", "Electric", "Electric", "Normal", "Normal", "Normal", "Water", "Water", "Poison", "Poison", "Water", "Water", "Ghost", "Ghost", "Ghost", "Rock", "Psychic", "Psychic", "Water", "Water", "Electric", "Electric", "Grass", "Grass", "Ground", "Ground", "Fighting", "Fighting", "Normal", "Poison", "Poison", "Ground", "Ground", "Normal", "Grass", "Normal", "Water", "Water", "Water", "Water", "Water", "Water", "Psychic", "Bug", "Ice", "Electric", "Fire", "Bug", "Normal", "Water", "Water", "Water", "Normal", "Normal", "Water", "Electric", "Fire", "Normal", "Rock", "Rock", "Rock", "Rock", "Rock", "Normal", "Ice", "Electric", "Fire", "Dragon", "Dragon", "Dragon", "Psychic", "Psychic" };
        Dictionary<string, string> pokemonTipo = new Dictionary<string, string>();
        for (int i = 0; i < pokemones.Count; i++)
        {
            pokemonTipo[pokemones[i]] = tipos[i];
        }
        Random rand = new Random();
        List<Equipo> equipos = new List<Equipo>
        {
            CreateTeam("Red", pokemones, pokemonTipo, rand),
            CreateTeam("Green", pokemones, pokemonTipo, rand),
            CreateTeam("Blue", pokemones, pokemonTipo, rand),
            CreateTeam("Yellow", pokemones, pokemonTipo, rand)
        };
        Equipo RedGreen = Battle(equipos[0], equipos[1]);
        Equipo BlueYellow = Battle(equipos[2], equipos[3]);
        Equipo win = Battle(RedGreen, BlueYellow);
        Console.WriteLine($"!!!!!El campeón del torneo es el equipo {win.Name}!!!!!!");
    }
    static Equipo CreateTeam(string nomb, List<string> pokemones, Dictionary<string, string> pokemonTipo, Random random)
    {
        Equipo team = new Equipo(nomb);
        for (int i = 0; i < 6; i++)
        {
            int index = random.Next(pokemones.Count);
            string pokemonNomb = pokemones[index];
            string pokemonType = pokemonTipo[pokemonNomb];
            int level = random.Next(50, 81);
            team.AddPokemon(new Pokemon(pokemonNomb, pokemonType, level));
        }
        return team;
    }

    static Equipo Battle(Equipo equip1, Equipo equip2)
    {
        int team1Level = equip1.TotalLevel();
        int team2Level = equip2.TotalLevel();
        Console.WriteLine("");
        Console.WriteLine($"{equip1.Name} vs {equip2.Name}:");
        
        if (team1Level > team2Level)
        {
            Console.WriteLine("");
            Console.WriteLine($"El ganador es el equipo {equip1.Name}");
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            return equip1;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine($"El ganador es el equipo {equip2.Name}");

            Console.WriteLine("---------------------");
            return equip2;
        }
    }
}

class Pokemon
{
    public string Name { get; }
    public string Type { get; }
    public int Level { get; }
    public Pokemon(string name, string type, int level)
    {
        Name = name;
        Type = type;
        Level = level;
    }
}

class Equipo
{
    public string Name { get; }
    private List<Pokemon> Pokemons { get; }
    public Equipo(string name)
    {
        Name = name;
        Pokemons = new List<Pokemon>();
    }
    public void AddPokemon(Pokemon pokemon)
    {
        Pokemons.Add(pokemon);
    }
    public int TotalLevel()
    {
        int total = 0;
        foreach (var pokemon in Pokemons)
        {
            total += pokemon.Level;
        }
        return total;
    }
}


//Ejercicio2

void MostrarNumeros(int numero)
{
    if (numero < 0) return;
    Console.WriteLine(numero);
    MostrarNumeros(numero - 5);
}
MostrarNumeros(50); 






