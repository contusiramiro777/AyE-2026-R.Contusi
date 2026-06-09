// Ejercicio 1:

Console.WriteLine("Ejercicio 1:");
Console.WriteLine("Crear una matriz 3x3 que contenga números del 1 al 9, luego imprimirla en consola de manera que se vea como una cuadricula.");
Console.WriteLine("");

int[,] matriz = new int[3, 3]
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

// Ejercicio 2:

Console.WriteLine("");
Console.WriteLine("Ejercicio 2:");

int[,] matriz2 = new int[3, 3]
    {
    { 10, 20, 30 },
    { 40, 50, 60 },
    { 70, 80, 90 }
};
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz2.GetLength(1); j++)
    {
        matriz2[i, j] = (i * 3 + j + 1) * 10;
        Console.Write(matriz2[i, j] + "\t");
    }
    Console.WriteLine();
}

int suma = 0;

for (int i = 0; i < matriz2.GetLength(0); i++)
{
    for (int j = 0; j < matriz2.GetLength(1); j++)
    {
        suma += matriz2[i, j];
    }
}
Console.WriteLine("");
Console.WriteLine("La suma de todos los números de la matriz es: " + suma);

// Ejercicio 3:

Console.WriteLine("");
Console.WriteLine("Ejercicio 3:");

int[,] matriz3 = new int[4, 4]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};
for (int i = 0; i < matriz3.GetLength(0); i++)
{
    for (int j = 0; j < matriz3.GetLength(1); j++)
    {
        Console.Write(matriz3[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("Ingrese la coordenada (fila,columna) para obtener el elemento correspondiente:");
Console.WriteLine("");
string input = Console.ReadLine();
string[] coordenadas = input.Split(',');
if (coordenadas.Length == 2 &&
    int.TryParse(coordenadas[0].Trim(), out int fila) &&
    int.TryParse(coordenadas[1].Trim(), out int columna) &&
    fila >= 0 && fila < matriz3.GetLength(0) &&
    columna >= 0 && columna < matriz3.GetLength(1))
{
    int elemento = matriz3[fila, columna];
    Console.WriteLine("El elemento en la coordenada (" + fila + ", " + columna + ") es: " + elemento);
}
else
{
    Console.WriteLine("Coordenada inválida. Asegúrese de ingresar en el formato correcto y dentro de los límites de la matriz.");
}

// Ejercicio 4:

Console.WriteLine("");
Console.WriteLine("Ejercicio 4:");
Console.WriteLine("Ingrese los números para llenar la matriz 4x4:");
Console.WriteLine("Ingrese 16 números separados por espacios:");
Console.WriteLine("");
int[,] matriz4 = new int[4, 4];
string input4 = Console.ReadLine();
string[] numeros = input4.Split(' ');
for (int i = 0; i < numeros.Length; i++)
{
    int numero;
    if (int.TryParse(numeros[i], out numero))
    {
        matriz4[i / 4, i % 4] = numero;
    }
    else
    {
        Console.WriteLine(numeros[i] + " no es un número válido. Se asignará 0 en su lugar.");
        matriz4[i / 4, i % 4] = 0;
    }
}
int maximo = matriz4[0, 0];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matriz4[i, j] > maximo)
        {
            maximo = matriz4[i, j];
        }
    }
}
Console.WriteLine("El número más grande en la matriz es: " + maximo);

// Ejercicio 5:
Console.WriteLine("");
Console.WriteLine("Ejercicio 5:");

int[,] matriz5 = new int[4, 4]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 },
    { 13, 14, 15, 16 }
};
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matriz5[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("");
for (int i = 0; i < 4; i++)
{
    int sumaFila = 0;
    for (int j = 0; j < 4; j++)
    {
        sumaFila += matriz5[i, j];
    }
    Console.WriteLine("La suma de la fila " + i + " es: " + sumaFila);
}
for (int i = 0; i < 4; i++)
{
    int sumaColumna = 0;
    for (int j = 0; j < 4; j++)
    {
        sumaColumna += matriz5[j, i];
    }
    Console.WriteLine("La suma de la columna " + i + " es: " + sumaColumna);
}

// Ejercicio 6
Console.WriteLine("");
Console.WriteLine("Ejercicio 6:");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matriz3[i, j],3}");
    }
    Console.WriteLine();
}
int[,]
    transpuesta = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        transpuesta[j, i] = matriz3[i, j];
    }
}
Console.WriteLine("Matriz transpuesta:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{transpuesta[i, j],3}");
    }
    Console.WriteLine("");
}
Console.WriteLine("");

// Ejercicio 7
Console.WriteLine("");
Console.WriteLine("Ejercicio 7:");

int[,] matriz7 = new int[3, 4]
{
    {1, 5, 3, 5},
    {8, 5, 9, 2},
    {4, 5, 6, 7}
};
Console.WriteLine("Ingrese un número para buscar en la matriz:");
int numeroBuscado = int.Parse(Console.ReadLine());
int contador = 0;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (matriz7[i, j] == numeroBuscado)
        {
            contador++;
        }
    }
}
Console.WriteLine("El número " + numeroBuscado + " aparece " + contador + " veces en la matriz.");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matriz[i, j],3}");
    }
    Console.WriteLine("");
}
// Ejercicio 8
Console.WriteLine("");
Console.WriteLine("Ejercicio 8:");

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matriz3[i, j],3}");
    }
    Console.WriteLine("");
}
int sumaTotal = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        sumaTotal += matriz3[i, j];
    }
}
int promedio = (sumaTotal + 8) / 16;
Console.WriteLine($"El promedio de los números en la matriz es: {promedio}");
int[,] matrizPromedio = new int[4, 4];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrizPromedio[i, j] = matriz3[i, j] < promedio ? promedio : matriz3[i, j];
    }
}
Console.WriteLine("Matriz con números menores al promedio reemplazados por el promedio:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrizPromedio[i, j],3}");
    }
    Console.WriteLine("");
}
Console.WriteLine("");