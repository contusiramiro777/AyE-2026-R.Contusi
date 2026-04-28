Console.WriteLine("Ingrese un número para sacar su factorial: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("El número puesto es negativo");
    Console.WriteLine("Tiene 3 intentos restantes");
    Console.ReadLine();
    if (num < 0)
    {
        Console.WriteLine("El número puesto es negativo");
        Console.WriteLine("Tiene 2 intentos restantes");
        Console.ReadLine();
        if (num < 0)
        {
            Console.WriteLine("El número puesto es negativo");
            Console.WriteLine("Tiene 1 intento restante");
            Console.ReadLine();
            if (num < 0)
            {
                Console.WriteLine("El número puesto es negativo");
                Console.WriteLine("No tiene más intentos");
            }
        }
    }
}

int factorial = 1;
for (int i = 1; i <= num; i++){ 
    factorial *= i; 
}

Console.WriteLine("El factorial de "+ num + " es: " + factorial);

