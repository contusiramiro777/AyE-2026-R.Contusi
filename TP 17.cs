//Ejercicio1
int[][] triangulo = new int[4][];
int contador = 1;

for (int i = 0; i < triangulo.Length; i++)
{
    triangulo[i] = new int[i + 1];
    for (int j = 0; j < triangulo[i].Length; j++)
    {
        triangulo[i][j] = contador;
        contador++;
    }
}

Console.WriteLine("Triángulo rectángulo:");
for (int i = 0; i < triangulo.Length; i++)
{
    for (int j = 0; j < triangulo[i].Length; j++)
    {
        Console.Write(triangulo[i][j] + " ");
    }
    Console.WriteLine();
}

//Ejercicio2
int[][] matriz2 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int total = 0;
for (int i = 0; i < matriz2.Length; i++)
{
    total += matriz2[i].Length;
}
Console.WriteLine($"Total de elementos: {total}");

//Ejercicio3
int[][] matriz3 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int indiceMasLargo = 0;
int longitudMaxima = 0;

for (int i = 0; i < matriz3.Length; i++)
{
    if (matriz3[i].Length > longitudMaxima)
    {
        longitudMaxima = matriz3[i].Length;
        indiceMasLargo = i;
    }
}
Console.WriteLine($"Fila más larga: Índice {indiceMasLargo} con {longitudMaxima} elementos");

//Ejercicio4
int[][] matriz4 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int[] sumaFilas = new int[matriz4.Length];
for (int i = 0; i < matriz4.Length; i++)
{
    int suma = 0;
    for (int j = 0; j < matriz4[i].Length; j++)
    {
        suma += matriz4[i][j];
    }
    sumaFilas[i] = suma;
}

Console.WriteLine("Suma de cada fila:");
for (int i = 0; i < sumaFilas.Length; i++)
{
    Console.WriteLine($"Fila {i}: {sumaFilas[i]}");
}

//Ejercicio5
int[][] matriz5 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int maximo = int.MinValue;
int filaMax = 0;
int columnaMax = 0;

for (int i = 0; i < matriz5.Length; i++)
{
    for (int j = 0; j < matriz5[i].Length; j++)
    {
        if (matriz5[i][j] > maximo)
        {
            maximo = matriz5[i][j];
            filaMax = i;
            columnaMax = j;
        }
    }
}
Console.WriteLine($"Valor máximo: {maximo} en fila {filaMax}, columna {columnaMax}");

//Ejercicio6
double[][] notas = new double[][]
{
    new double[] { 8.5, 9.0, 7.5 },
    new double[] { 6.5, 7.0 },
    new double[] { 9.5, 9.0, 8.5, 8.0 },
    new double[] { 7.0 }
};

double[] promedios = new double[notas.Length];
for (int i = 0; i < notas.Length; i++)
{
    double suma = 0;
    for (int j = 0; j < notas[i].Length; j++)
    {
        suma += notas[i][j];
    }
    promedios[i] = suma / notas[i].Length;
}

Console.WriteLine("Promedios por estudiante:");
for (int i = 0; i < promedios.Length; i++)
{
    Console.WriteLine($"Estudiante {i + 1}: {promedios[i]:F2}");
}

//Ejercicio7
Console.WriteLine("buscar un intruso");
int[][] matriz7 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5, 6 },
    new int[] { 7, 8, 9 }
};

int buscar = 5;
bool encontrado = false;
for (int i = 0; i < matriz7.Length; i++)
{
    for (int j = 0; j < matriz7[i].Length; j++)
    {
        if (matriz7[i][j] == buscar)
        {
            encontrado = true;
        }
    }
}
Console.WriteLine($"¿Existe el número {buscar}? {(encontrado ? "sí" : "no")}");

buscar = 10;
encontrado = false;
for (int i = 0; i < matriz7.Length; i++)
{
    for (int j = 0; j < matriz7[i].Length; j++)
    {
        if (matriz7[i][j] == buscar)
        {
            encontrado = true;
        }
    }
}
Console.WriteLine($"¿Existe el número {buscar}? {(encontrado ? "sí" : "no")}");
