//Ejercicio1

Console.WriteLine("Ingrese 0 o 1");
int num = Convert.ToInt32(Console.ReadLine());
while (num !>=0 && num !<= 1)
{
    Console.WriteLine("Estás dentro del while");
    break;
}
if (num == 1 && num == 0)
{
    Console.WriteLine("Estás dentro del while");
}
else
{
    Console.WriteLine("Número equivocado");
}


//Ejercicio2

Console.WriteLine("");
Console.WriteLine("Ingrese un número de 2 cifras");
int nm = Convert.ToInt32(Console.ReadLine()); 
while (nm <= 9)
{
    Console.WriteLine("Número incorreto");
    break;
}
if (nm <= 9)
{
    Console.WriteLine("Número incorreto");
}
else
{
    Console.WriteLine("Bien");
}

