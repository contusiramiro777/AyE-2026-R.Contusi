//Ejercicio2

int numero, potencia;

Console.WriteLine("Ingrese un numero: ");
numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la potencia a la que desea elevar el numero: ");
potencia = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine($"El resultado de elevar {numero} a la potencia {potencia} es: {CalcularPotencia(numero, potencia)}");

int CalcularPotencia(int baseNum, int exp)
{
    if (exp == 0)
    {
        return 1;
    }
    else if (exp < 0)
    {
        return 1 / CalcularPotencia(baseNum, -exp); 
    }
    else
    {
        return baseNum * CalcularPotencia(baseNum, exp - 1);
    }
}














