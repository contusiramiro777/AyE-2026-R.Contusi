using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rutaSalida = "TP10.txt";

            using (StreamWriter writer = new StreamWriter(rutaSalida, append: false))
            {
                writer.WriteLine("Ejercicio 1:");
                int num = 98;
                int unidades;
                int decenas;

                if (num >= 10 && num <= 99)
                {
                    unidades = num / 10;
                    decenas = num % 10;
                    writer.WriteLine("La cifra original es: " + num);
                    writer.WriteLine("La cifra de las unidades es: " + unidades);
                    writer.WriteLine("La cifra de las decenas es: " + decenas);
                }
                else
                {
                    writer.WriteLine("Error: Usted ingreso un número no pedido");
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 2");
                int num2 = 782;
                int medio;
                if (num2 >= 100 && num2 <= 999)
                {
                    medio = (num2 / 10) % 10;
                    writer.WriteLine("La cifra original es: " + num2);
                    writer.WriteLine("La cifra central es: " + medio);
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 3");
                float precio = 340.50f;
                float precio_final;
                float descuento;

                if (precio > 0)
                {
                    descuento = precio * 18 / 100;
                    precio_final = precio - descuento;
                    writer.WriteLine("El precio de la lista es: " + precio);
                    writer.WriteLine("El descuento es un 18%");
                    writer.WriteLine("El precio con descuento es:" + precio_final);
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 4");
                int num3 = 64;
                int permutado;

                if (num3 >= 0 && num3 <= 99)
                {
                    permutado = (num3 % 10) * 10 + (num3 / 10);
                    writer.WriteLine("La cifra original es: " + num3);
                    writer.WriteLine("La cifra permutada es: " + permutado);
                }
                else
                {
                    writer.WriteLine("Ingreso un número incorrecto");
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 5");
                int fecha = 190820;
                int mes;
                if (fecha >= 100000 && fecha <= 999999)
                {
                    writer.WriteLine("La fecha es: " + fecha);

                    mes = (fecha / 100) % 100;

                    if (mes >= 1 && mes <= 12)
                    {
                        writer.WriteLine("El mes es: " + mes);
                    }
                    else
                    {
                        writer.WriteLine(" error: Ingresó un mes erróneo");
                    }
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 6");
                int lado = 8;
                int perimetro;
                int superficie;

                if (lado > 0)
                {
                    perimetro = lado * 4;
                    superficie = lado * lado;
                    writer.WriteLine("La perimetro es: " + perimetro);
                    writer.WriteLine("La superficie es: " + superficie);
                }
                else
                {
                    Console.WriteLine("Ingresó un lado negativo");
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 7");

                int sueldo = 380;
                writer.WriteLine("Cantidad de horas que trabajó: ");
                int horas = 8; ;

                if (horas > 0 && horas <= 24)
                {
                    sueldo = sueldo * horas;
                    writer.WriteLine("El sueldo en bruto es: " + sueldo);
                }
                else
                {
                    writer.WriteLine("Dato incorrecto");
                }

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 8");
                int Fah = 34;
                int Cel = (Fah - 32) * 5 / 9;
                writer.WriteLine("Temperatura en Fahrenheit: " + Fah);
                writer.WriteLine("La temperatura a Celcius es: " + Cel + " °C");

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 9");
                writer.Write("Primer tiempo: ");
                int Hora = 14;
                int Min = 30;
                int Seg = 10;
                writer.WriteLine($"{Hora}:{Min}:{Seg}");

                writer.WriteLine("");
                writer.Write("Segundo tiempo: ");
                int Hora2 = 14;
                int Min2 = 50;
                int Seg2 = 52;
                writer.WriteLine($"{Hora2}:{Min2}:{Seg2}");

                int Total = Hora * 3600 + Min * 60 + Seg;
                int Total2 = Hora2 * 3600 + Min2 * 60 + Seg2;

                int Intervalo = Total2 - Total;

                writer.WriteLine("");
                writer.WriteLine("El intervalo es: " + Intervalo);

                writer.WriteLine("");
                writer.WriteLine("Ejercicio 10");
                int num4 = 670;
                int unidadess;
                int decenass;
                int centenass;

                if (num4 >= 100 && num4 <= 999)
                {
                    unidadess = num4 % 10;
                    decenass = (num4 / 10) % 10;
                    centenass = num4 / 100;
                    writer.WriteLine("El número ingresado es: " + num4);
                    writer.WriteLine("Su unidad es: " + unidadess);
                    writer.WriteLine("Su decena es: " + decenass);
                    writer.WriteLine("Su centena es: " + centenass);
                }
                else
                {
                    writer.WriteLine("El número es invalido");
                }
            }

            string rutaEntrada = "TP10.txt";

            using (StreamReader reader = new StreamReader(rutaEntrada))
            {
                while (!reader.EndOfStream)
                {
                    string? linea = reader.ReadLine();
                    Console.WriteLine(linea);
                }
            }

        }
    }
}