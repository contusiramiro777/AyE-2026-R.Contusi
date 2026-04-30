//Bloque 1 - Ejercicio 1
Console.WriteLine("Ejercicio 1");
Console.WriteLine("");
for (int i = 0; i <= 100; i = i + 3)
{
    Console.WriteLine(i);
}

//Ejercicio 2
Console.WriteLine("");
Console.WriteLine("Ejercicio 2");
int edad;
Console.WriteLine("Ingrese su edad");
edad = Convert.ToInt32(Console.ReadLine());

if (edad == 18)
{
    Console.WriteLine("Usted tiene 18");
}
else if (edad > 18)
{
    Console.WriteLine("Usted es mayor de 18");
}
else
{
    Console.WriteLine("Usted es menor de 18");
}


//JEjercicio3
Console.WriteLine("");
Console.WriteLine("Ejercicio 3");

Console.WriteLine("Ingrese una palabra");
string palabra = Console.ReadLine();

int longitud = palabra.Length;
Console.WriteLine("La palabra ingresada tiene " + longitud + " letras");

//Ejercicio 4
Console.WriteLine("");
Console.WriteLine("Ejercicio 4");
Console.WriteLine(" Adivine la contraseña secreta. Tiene 5 intentos.");
string secreto = "amoalosgatos420";
int intentosMax = 5;
bool acertado = false;

for (int intento = 1; intento <= intentosMax; intento++)
{
    Console.Write("Intento: " + intento + "/" + intentosMax + ": ");
    string intentoUsuario = Console.ReadLine();

    if (intentoUsuario == secreto)
    {
        Console.WriteLine("¡Correcto! Ha adivinado la contraseña.");
        acertado = true;
        break;
    }
}
Console.WriteLine("Ha agotado los intentos.");

//Ejercicio 5
Console.WriteLine("");
Console.WriteLine("Ingrese 10 números");
int cantidad = 10;
int maximo = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write("Ingrese un número: ");
    int numro = Convert.ToInt32(Console.ReadLine());
    if (numro > maximo)
    {
        maximo = numro;
    }
}
Console.WriteLine("El número más alto ingresado es: " + maximo);

//Ejercicio 6
Console.WriteLine("");
Console.WriteLine("Ingrese su nombre:");
Console.Write("Nombre: ");
string nombre = Console.ReadLine();
Console.WriteLine("Hola, " + nombre + "!");

//Ejercicio 7
Console.WriteLine("");
int x = 7;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(x * i);
}


//Ejercicio 8
Console.WriteLine("");

for (int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
}

//Ejercicio 9
Console.WriteLine("");
Console.WriteLine("Ingrese un número para determinar si es par o impar:");
Console.Write("Número: ");
int numeroIngresado = Convert.ToInt32(Console.ReadLine());
if (numeroIngresado % 2 == 0)
{
    Console.WriteLine("El número ingresado es par");
}
else
{
    Console.WriteLine("El número ingresado es impar");
}

//Ejercicio 10
Console.WriteLine("");
Console.WriteLine("Ingrese una frase y se mostrará la cantidad de vocales:");
Console.Write("Frase: ");
string frase = Console.ReadLine();
int contadorVocales = 0;
string vocales = "aeiouAEIOU";

foreach (char c in frase)
{
    if (vocales.IndexOf(c) >= 0)
    {
        contadorVocales++;
    }
}

Console.WriteLine("Cantidad de vocales: " + contadorVocales);

//Ejercicio 11
Console.WriteLine("");
Console.Write("Ingrese un número: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tabla de multiplicar del " + numero + ":");
for (int i = 1; i <= 12; i++)
{
    Console.WriteLine(numero + "x" + i + "= " + numero * i);
}

//Ejercicio 12
Console.WriteLine("");
Console.WriteLine("Ingrese números para acumular un total mayor a 100.");
int acumulado = 0;
while (acumulado <= 100)
{
    Console.Write("Ingrese un número: ");
    int numero2 = Convert.ToInt32(Console.ReadLine());
    acumulado += numero2;
    Console.WriteLine("Total acumulado: " + acumulado);
}
Console.WriteLine("Ya ha superado el total de 100");

//Ejercicio 13
Console.WriteLine("");
Console.Write("Ingrese una palabra: ");
string plabra = Console.ReadLine();

foreach (char ltra in plabra)
{
    Console.WriteLine(ltra);
}

//Ejercicio 14
Console.WriteLine("");
Console.Write("Ingrese su edad: ");
int edd = Convert.ToInt32(Console.ReadLine());

if (edd >= 18)
{
    Console.WriteLine("Puede votar y manejar.");
}
else if (edd >= 16)
{
    Console.WriteLine("Puede manejar, pero no puede votar.");
}
else
{
    Console.WriteLine("No puede votar ni manejar.");
}

//Ejercicio 15
Console.WriteLine("");
for (int i = 50; i >= 0; i -= 5)
{
    Console.WriteLine(i);
}

//Ejercicio 16
Console.WriteLine("");
string contraseña = "";
string confirmacion = "";
Console.Write("Ingrese una contraseña: ");
contraseña = Console.ReadLine();
Console.Write("Confirme la contraseña: ");
confirmacion = Console.ReadLine();
while (contraseña != confirmacion)
{
    Console.WriteLine("Las contraseñas no coinciden. Hágalo nuevamente.");
    Console.Write("Ingrese una contraseña: ");
    contraseña = Console.ReadLine();

    Console.Write("Confirme la contraseña: ");
    confirmacion = Console.ReadLine();
}
Console.WriteLine("Acceso permitido.");

//Ejercicio 17
Console.WriteLine("");
Console.WriteLine("Ingrese nombres. El programa finalizará cuando se ingrese un nombre con más de 10 caracteres.");
string nmbre = "";
Console.Write("Ingrese un nombre: ");
nombre = Console.ReadLine();
while (nombre.Length <= 10)
{
    Console.WriteLine("Nombre ingresado: " + nmbre);
    Console.Write("Ingrese un nombre: ");
    nmbre = Console.ReadLine();
}
Console.WriteLine("El nombre tiene más de 10 caracteres. Fin del programa.");

// ejercicio 18
Console.WriteLine("");
Console.Write("Ingrese una oración: ");
string oracion = Console.ReadLine();
int contadorA = 0;
foreach (char letra in oracion)
{
    if (letra == 'a' || letra == 'A')
    {
        contadorA++;
    }
}
Console.WriteLine("La oración tiene " + contadorA + " letras 'a'.");
