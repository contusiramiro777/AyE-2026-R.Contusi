namespace ConsoleApp1
{
    struct Personaje
    {
        public int vidaTotal;
        public int vidaActual;
        public string ultimaAccion;

        public Personaje (int vidaTotal, int vidaActual, string ultimaAccion)
        {
            this.vidaTotal = vidaTotal;

            this.vidaActual= vidaActual;

            this.ultimaAccion = ultimaAccion;
        }

    }

    internal class Program
    {
        static void volverEnElTiempo(Stack<Personaje> historial)
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("No hay acciones por deshacer");
                return;
            }
            Personaje accionBorrada = historial.Pop();
            Console.WriteLine("Accion Borrada: " + accionBorrada.ultimaAccion);
        }

        static void golpear(Stack<Personaje> historial)
        {
            if (historial.Count == 0)
            {
                Console.WriteLine("No hay personajes para golpear");
                return;
            }
            Personaje ultimo = historial.Peek();

            int nuevaVida = ultimo.vidaActual - 20;
            if (nuevaVida < 0) nuevaVida = 0;

            Personaje nuevaAccion = new Personaje(ultimo.vidaTotal, nuevaVida, "Golpe recibido");
            historial.Push(nuevaAccion);

        }
        static void Main(string[] args)
        {
            Stack<Personaje> historialDelPersonaje = new Stack<Personaje>();

            Personaje p1 = new Personaje(100, 100, "Aparicion");

            Personaje p2 = new Personaje(100, 90, "Esquivo un ataque");

            Personaje p3 = new Personaje(100, 75, "Curo vida");

            historialDelPersonaje.Push(p1);
            historialDelPersonaje.Push(p2);
            historialDelPersonaje.Push(p3);

            Console.WriteLine("Historial del Personaje");
            foreach (Personaje item in historialDelPersonaje)
            {
                Console.WriteLine("Vida Total: "+ item.vidaTotal + "| Vida Actual: " + item.vidaActual + "|Ultima Acción: " + item.ultimaAccion);
            }
            Console.WriteLine("");
            Console.WriteLine("Ejecutando golpear");
            golpear(historialDelPersonaje);

            Console.WriteLine("");
            Console.WriteLine("Historial después del golpe");
            foreach (Personaje item in historialDelPersonaje)
            {
                Console.WriteLine("Vida Total: " + item.vidaTotal + "| Vida Actual: " + item.vidaActual + "|Ultima Acción: " + item.ultimaAccion);

            }

            Console.WriteLine("");
            Console.WriteLine("Ejecutando Volver en el Tiempo");
            volverEnElTiempo(historialDelPersonaje);

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();
        }
    }
}
