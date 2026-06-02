// Programa 5:
string[] nombres = new string[100];
string[] telefonos = new string[100];
int cantidad = 0;
bool continuar = true;

while (continuar)
{
    Console.WriteLine("1. Añadir contacto. - 2. Mostar todos. - 3. Buscar contacto - 4. Salir");
    Console.WriteLine("Seleccione una opción: ");

    int opcion = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (opcion)
    {
        case 1:
            if (cantidad < 100)
            {
                Console.WriteLine("Ingrese el nombre: ");

                nombres[cantidad] = Console.ReadLine();

                Console.WriteLine("Ingrese el número de teléfono: ");

                telefonos[cantidad] = Console.ReadLine();

                cantidad++;

                Console.WriteLine("Contacto Añadido");
            }
            else
            {
                Console.WriteLine("Alcanzaste el limite de caracteres");
                break;
            }
            break;
        case 2:
            Console.WriteLine("Contactos");
            if (cantidad == 0)
            {
                Console.WriteLine("No hay contactos");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    i = i + 1;
                    Console.WriteLine(nombres[i]);
                    break;
                }
            }
            break;
        case 3:
            Console.WriteLine("Buscar contacto: ");
            string buscar = Console.ReadLine();
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (nombres[i] == buscar)
                {
                    Console.WriteLine(nombres[i] + " - " + telefonos[i]);
                    encontrado = true;
                    break;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Contacto no encontrado");
                break;
            }
            break;
        case 4:
            continuar = false;
            break;
    }
    Console.WriteLine("");
}