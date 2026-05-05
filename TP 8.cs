
//Ejercicio 1
Console.WriteLine("ingrese una frase para contar sus vocales");
string frase = Console.ReadLine();
int contadorVocales = 0;
string vocales = "aeiouAEIOU";
foreach (char T in frase)
{
    foreach (char V in vocales)
    {
        if (T == V)
        {
            contadorVocales++;
            break;
        }
    }
}
Console.WriteLine("La cantidad de vocales en la frase es: " + contadorVocales);

//Ejercicio 2
Console.WriteLine("");
Console.WriteLine("ingrese una frase para invertirla");
string frase2 = Console.ReadLine();
string fraseInvertida = "";
for (int i = 0; i < frase2.Length; i++)
{
    fraseInvertida = frase2[i] + fraseInvertida;
}
Console.WriteLine("La frase invertida es: " + fraseInvertida);

//Ejercicio 3
Console.WriteLine("");
Console.WriteLine("ingrese un numero entero y calcula la suma de los digitos");
string numero = Console.ReadLine();
int suma = 0;
int sumarespaldo = 0;
foreach (char digito in numero)
{
    suma = Convert.ToInt32("" + digito);
    sumarespaldo = suma + sumarespaldo;
}
Console.WriteLine("La suma de los digitos es:" + sumarespaldo);

//Ejercicio 4

Console.WriteLine("");
Console.WriteLine("Ingrese algunas palabras");
string parrafo = Console.ReadLine();
Console.WriteLine("Ingrese la palabra prohibida:");
string palabraProhibida = Console.ReadLine();
Console.WriteLine("Ingrese la palabra de reemplazo:");
string palabraReemplazo = Console.ReadLine();
string parrafoModificado = parrafo.Replace(palabraProhibida, palabraReemplazo);
Console.WriteLine("El texto resultante es: " + parrafoModificado);

//Ejercicio 5

Console.WriteLine("");
Console.WriteLine("ingrese su nombre y apellido para abreviarlo y poner solo las iniciales");
string nombreCompleto = Console.ReadLine();
string[] partes = nombreCompleto.Split(' ');
string iniciales = "";
for (int i = 0; i < partes.Length; i++)
{
    iniciales += partes[i][0] + ".";
}
Console.WriteLine("Las iniciales son: " + iniciales);

//Ejercicio 6
Console.WriteLine("");
Console.WriteLine("ingrese una palabra para ver si se lee igual al derecho y al reves");
string palabra = Console.ReadLine();
string palabraInvertida2 = "";
for (int i = 0; i < palabra.Length; i++)
{
    palabraInvertida2 = palabra[i] + palabraInvertida2;
}
if (palabra == palabraInvertida2)
{
    Console.WriteLine("La palabra es un palindromo");
}
else
{
    Console.WriteLine("La palabra no es un palindromo");
}