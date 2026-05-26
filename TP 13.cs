//Ejercicio1
Console.WriteLine("Ejercicio 1");
string[] palabras = { "gatopelotudo", "ramirez", "queque", "invierno", "Papoi", "dospuntostres", "ramirezpuntoexe", "wachin", "niessi", "pneumonoultramicroscopicsilicovolcanoconiosis" };
string palabraMasLarga = "";
for (int i = 0; i < palabras.Length; i++)
{
    if (palabras[i].Length > palabraMasLarga.Length)
    {
        palabraMasLarga = palabras[i];
    }
}
Console.WriteLine("La palabra con la mayor cantidad de caracteres es: " + palabraMasLarga);

//Ejercicio2
Console.WriteLine("");
Console.WriteLine("Ejercicio 2");
Console.WriteLine("Usando la misma lista del ejercicio 1, mostrar la cantidad de vocales de todas las palabras combinadas");
int cantidadVocales = 0;
for (int i = 0; i < palabras.Length; i++)
{
    for (int j = 0; j < palabras[i].Length; j++)
    {
        char letra = palabras[i][j];
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            cantidadVocales++;
        }
    }
}
Console.WriteLine("La cantidad total de vocales en todas las palabras es: " + cantidadVocales);

//Ejercicio3
Console.WriteLine("");
Console.WriteLine("Ejercicio 3");
int[] numeros = { 1, 2, 3, 4, 5, 6, 7 };
int factor = 5;
int[] numerosMultiplicados = new int[numeros.Length];
for (int i = 0; i < numeros.Length; i++)
{
    numerosMultiplicados[i] = numeros[i] * factor;
}
Console.WriteLine("Los números multiplicados por el factor " + factor + " son:");
for (int i = 0; i < numerosMultiplicados.Length; i++)
{
    Console.WriteLine(numerosMultiplicados[i]);
}