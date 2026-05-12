//Ejercicio1

try {Console.WriteLine("Ingrese la cantidad de horas trabajadas para determinar su salario: ");
   int x = Convert.ToInt32(Console.ReadLine());
    if(x <= 40)
    {
        Console.WriteLine("Como ha trabajado 40 horas o menos, su salario va a ser de $16 la hora");
        
    }
    else
    {
        Console.WriteLine("Como ha trabajado más de 40 horas, su salario es de $16 por cada una de las 40 horas y otros $20 por cada hora extra");
    }
}
catch (System.FormatException)
{
    Console.WriteLine("ERROR. Ingrese solo números");
}

//Ejercicio2

try
{
    int result = 0;
    Console.WriteLine("");
    Console.WriteLine("Ejercicio2");
    Console.WriteLine("Ingrese números de a uno para sumarlos e ingrese el '0' para terminar la suma: ");
    int d = Convert.ToInt32(Console.ReadLine());
    while (d != 0)
    {
        result += d;

        Console.WriteLine("Ingrese otro número o el 0 para terminar la suma: ");
        d = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("El resultado de la suma es: " + result);
}
catch (System.FormatException)
{
    Console.WriteLine("ERROR. Ingrese solo números");
}

//Ejercicio3

try
{
    Console.WriteLine("");
    Console.WriteLine("Ejercicio3");
    Console.WriteLine("Ingrese una palabra: ");
    string p = Console.ReadLine();
    int contadorVocales = 0;
    for (int i = 0; i < p.Length; i++)
    {
        char letra = p[i];
        if (letra == 'aeiouAEIOU')
        {
            contadorVocales++;
        }
    }
    Console.WriteLine("La cantidad de vocales en la palabra es: " + contadorVocales);
}
catch (ArgumentNullException)
{
    Console.WriteLine("ERROR. Ingrese solo palabras");
}
