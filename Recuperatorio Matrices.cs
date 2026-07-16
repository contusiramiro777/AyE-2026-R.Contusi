string[] heroes = { "Arthur", "Merlin", "Robin", "Conan", "Leonidas", "Gandalf", "Lara", "Zelda", "Aloy", "Geralt", "Ciri", "Kratos", "Ellie", "Joel", "Tifa", "Cloud", "Sephiroth", "Aerith", "Barret", "Ryu", "Ken", "Chun-Li", "Guile", "Zangief" };
string[] clases = { "Caballero", "Mago", "Arquero", "Bárbaro", "Espadachín", "Mago", "Exploradora", "Princesa", "Cazadora", "Brujo", "Guerrera", "Dios", "Superviviente", "Contrabandista", "Luchadora", "Soldado", "Villano", "Curandera", "Artillero", "Karateka", "Karateka", "Artista Marcial", "Militar", "Luchador" };

Random random = new Random();
bool[] usados = new bool[heroes.Length];

string[,] dragones = new string[6, 3];
string[,] leones = new string[6, 3];
string[,] lobos = new string[6, 3];
string[,] aguilas = new string[6, 3];

LlenarClan(dragones);
LlenarClan(leones);
LlenarClan(lobos);
LlenarClan(aguilas);

Console.WriteLine(" Clan Dragones");
MostrarClan(dragones);
Console.WriteLine("Clan Leones");
MostrarClan(leones);
Console.WriteLine("Clan Lobo");
MostrarClan(lobos);
Console.WriteLine("Clan Águilas");
MostrarClan(aguilas);
Console.WriteLine("------------------------");

int poderDragones = SumarPoder(dragones);
int poderLeones = SumarPoder(leones);
int poderLobos = SumarPoder(lobos);
int poderAguilas = SumarPoder(aguilas);


Console.WriteLine("Semifinal 1: Dragones vs Leones");
Console.WriteLine($"Poder Dragones: {poderDragones} || Poder Leones: {poderLeones}");
string[,] ganadorSemi1;
string nombreSemi1;
if (poderDragones > poderLeones)
{
    ganadorSemi1 = dragones;
    nombreSemi1 = "Dragones";
}
else
{
    ganadorSemi1 = leones;
    nombreSemi1 = "Leones";
}
Console.WriteLine("Ganador: " + nombreSemi1);
Console.WriteLine();

Console.WriteLine("Semifinal 2: Lobos vs Águilas");
Console.WriteLine($"Poder Lobos: {poderLobos} || Poder Águilas: {poderAguilas}");
string[,] ganadorSemi2;
string nombreSemi2;
if (poderLobos > poderAguilas)
{
    ganadorSemi2 = lobos;
    nombreSemi2 = "Lobos";
}
else
{
    ganadorSemi2 = aguilas;
    nombreSemi2 = "Águilas";
}
Console.WriteLine("Ganador: " + nombreSemi2);
Console.WriteLine();

int poderFinal1 = SumarPoder(ganadorSemi1);
int poderFinal2 = SumarPoder(ganadorSemi2);
Console.WriteLine("Final");
Console.WriteLine($"{nombreSemi1} ({poderFinal1}) vs {nombreSemi2} ({poderFinal2})");

string[,] clanCampeon;
string nombreCampeon;
if (poderFinal1 > poderFinal2)
{
    clanCampeon = ganadorSemi1;
    nombreCampeon = nombreSemi1;
}
else
{
    clanCampeon = ganadorSemi2;
    nombreCampeon = nombreSemi2;
}

Console.WriteLine();
Console.WriteLine("El Clan Campeón es: " + nombreCampeon);
Console.WriteLine();
Console.WriteLine("Héroes del clan campeón:");
MostrarClan(clanCampeon);

void LlenarClan(string[,] clan)
{
    for (int i = 0; i < clan.GetLength(0); i++)
    {
        int indice;
        do
        {
            indice = random.Next(0, heroes.Length);
        } while (usados[indice]);

        usados[indice] = true;
        clan[i, 0] = heroes[indice];
        clan[i, 1] = clases[indice];
        clan[i, 2] = random.Next(100, 501).ToString();
    }
}

int SumarPoder(string[,] clan)
{
    int suma = 0;
    for (int i = 0; i < clan.GetLength(0); i++)
    {
        suma += Convert.ToInt32(clan[i, 2]);
    }
    return suma;
}

void MostrarClan(string[,] clan)
{
    for (int i = 0; i < clan.GetLength(0); i++)
    {
        Console.WriteLine($"Nombre: {clan[i, 0]} || Clase: {clan[i, 1]} || Poder: {clan[i, 2]}");
    }
    Console.WriteLine();
}