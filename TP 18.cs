using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp40
{
    internal class Program
    {
        //Ejercicio1
        public struct Punto2D
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Punto2D(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Mostrar()
            {
                Console.WriteLine($"({X}, {Y})");
            }
        }

        //Ejercicio2
        public struct Dimensiones
        {
            public int Ancho { get; set; }
            public int Alto { get; set; }

            public Dimensiones(int ancho, int alto)
            {
                Ancho = ancho;
                Alto = alto;
            }
        }

        //Ejercicio3
        public struct Producto
        {
            public string Nombre { get; set; }
            public int Codigo { get; set; }
            public double Precio { get; set; }

            public Producto(string nombre, int codigo, double precio)
            {
                Nombre = nombre;
                Codigo = codigo;
                Precio = precio;
            }
        }

        //Ejercicio4:
        public struct Estudiante
        {
            public string Nombre { get; set; }
            public double[] Notas { get; set; }

            public Estudiante(string nombre, double[] notas)
            {
                Nombre = nombre;
                Notas = notas;
            }

            public double CalcularPromedio()
            {
                double suma = 0;
                foreach (double nota in Notas)
                {
                    suma += nota;
                }
                return suma / Notas.Length;
            }
        }

        static void Main(string[] args)
        {
            //Ejercicio 1
            Punto2D punto = new Punto2D(5, 10);
            punto.Mostrar();
            Console.WriteLine();

            //Ejercicio2
            Dimensiones d1 = new Dimensiones(10, 20);
            Dimensiones d2 = d1;
            d2.Ancho = 99;

            Console.WriteLine($"d1 - Ancho: {d1.Ancho}, Alto: {d1.Alto}");
            Console.WriteLine($"d2 - Ancho: {d2.Ancho}, Alto: {d2.Alto}");
            // ¿Por qué el ancho de d1 no cambió a 99?
            // 
            //El ancho de d1 no cambió porque las estructuras en C# son tipos de valor,
            //lo que significa que al hacer d2 = d1 se crea una copia independiente en la memoria;
            //por lo tanto, modificar d2.Ancho = 99 solo afectó a esa copia y dejó el valor de d1 intacto,
            //algo que podrías evitar cambiando el struct por una class
            //si necesitás que ambas variables compartan los mismos datos
            Console.WriteLine();

            //Ejercicio 3
            Producto[] inventario = new Producto[3];

            inventario[0] = new Producto("Laptop", 101, 999.99);
            inventario[1] = new Producto("Mouse", 102, 29.99);
            inventario[2] = new Producto("Teclado", 103, 79.99);

            foreach (Producto producto in inventario)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Precio: ${producto.Precio}");
            }
            Console.WriteLine();

            // Ejercicio 4
            double[] notas = { 8.5, 9.0, 7.5 };
            Estudiante estudiante = new Estudiante("Juan Pérez", notas);

            double promedio = estudiante.CalcularPromedio();
            Console.WriteLine($"Estudiante: {estudiante.Nombre}");
            Console.WriteLine($"Promedio: {promedio:F2}");
        }
    }
}