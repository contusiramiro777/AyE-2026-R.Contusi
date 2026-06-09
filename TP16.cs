// Ejercicio 1:

Console.WriteLine("Ejercicio 1:");
Console.WriteLine("");
int[,] matriz = new int[4, 4]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};

int sumaEsquinas = matriz[0, 0] + matriz[0, 3] + matriz[3, 0] + matriz[3, 3];
Console.WriteLine("La suma de las esquinas de la matriz es: " + sumaEsquinas);

// Ejercicio 2:
Console.WriteLine("");
Console.WriteLine("Ejercicio 2:");
int[,] matriz2 = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
int sumaDiagonalPrincipal = matriz2[0, 0] + matriz2[1, 1] + matriz2[2, 2];
int sumaDiagonalSecundaria = matriz2[0, 2] + matriz2[1, 1] + matriz2[2, 0];
Console.WriteLine("La suma de la diagonal principal es: " + sumaDiagonalPrincipal);
Console.WriteLine("La suma de la diagonal secundaria es: " + sumaDiagonalSecundaria);

// Ejercicio 3:
Console.WriteLine("");
Console.WriteLine("Ejercicio 3:");
Console.Write("Ingrese el tamaño de la matriz de identidad: ");
int tamaño = int.Parse(Console.ReadLine());
int[,] matrizIdentidad = new int[tamaño, tamaño];
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        if (i == j)
        {
            matrizIdentidad[i, j] = 1;
        }
        else
        {
            matrizIdentidad[i, j] = 0;
        }
    }
}
Console.WriteLine("Matriz de identidad de tamaño " + tamaño + ":");
for (int i = 0; i < tamaño; i++)
{
    for (int j = 0; j < tamaño; j++)
    {
        Console.Write(matrizIdentidad[i, j] + " ");
    }
    Console.WriteLine("");
}
