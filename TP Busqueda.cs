using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaOriginal = new int[50];
            Random random = new Random();

            for (int i = 0; i < listaOriginal.Length; i++)
            {
                listaOriginal[i] = random.Next(1, 101);
            }

            Console.WriteLine("LISTA ORIGINAL (50 ELEMENTOS DESORDENADOS)");
            ImprimirVector(listaOriginal);
            Console.WriteLine("\n" + new string('=', 60) + "\n");

            int objetivo = listaOriginal[10];
            Console.WriteLine($"Buscando el número: {objetivo}\n");

            int posSec = BusquedaSecuencialSimple(listaOriginal, objetivo);
            Console.WriteLine($"Posición (Secuencial Simple - Desordenada): {posSec}");

            int[] listaOrdenada = (int[])listaOriginal.Clone();
            Array.Sort(listaOrdenada);

            int posSecOpt = BusquedaSecuencialOptimizada(listaOrdenada, objetivo);
            Console.WriteLine($"Posición (Secuencial Optimizada - Ordenada): {posSecOpt}");

            int posBinIter = BusquedaBinariaIterativa(listaOrdenada, objetivo);
            Console.WriteLine($"Posición (Binaria Iterativa - Ordenada): {posBinIter}");

            int posBinRec = BusquedaBinariaRecursiva(listaOrdenada, objetivo, 0, listaOrdenada.Length - 1);
            Console.WriteLine($"Posición (Binaria Recursiva - Ordenada): {posBinRec}");

            Console.WriteLine("\n" + new string('=', 60) + "\n");

            Console.WriteLine("PRUEBAS DE ALGORITMOS DE ORDENAMIENTO\n");

            OrdenamientoBurbujaClasico(listaOriginal);
            OrdenamientoBurbujaOptimizado(listaOriginal);
            OrdenamientoSeleccion(listaOriginal);
            OrdenamientoInsercion(listaOriginal);
            OrdenamientoQuickSort(listaOriginal);
            OrdenamientoStalin(listaOriginal);
            OrdenamientoBogo(listaOriginal);
        }

        /*Explicación: Recorre el vector elemento por elemento desde el índice 0 
        comparando secuencialmente con el valor buscado.
        ¿Qué condiciones se deben cumplir?: Ninguna. Funciona en vectores ordenados y desordenados.
        ¿Qué complejidad algorítmica tiene?: O(N) en el peor caso (elemento al final o no existente).
        */
        static int BusquedaSecuencialSimple(int[] lista, int objetivo)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == objetivo)
                    return i;
            }
            return -1;
        }

        /*
        Explicación: Recorre la lista de forma secuencial, pero detiene la búsqueda 
        si encuentra un elemento estrictamente MAYOR al buscado (corte temprano).
        ¿Qué condiciones se deben cumplir?: La lista DEBE estar ordenada de forma ascendente.
        ¿Qué complejidad algorítmica tiene?: O(N) en el peor caso, pero con menor tiempo promedio de fallo.
        */
        static int BusquedaSecuencialOptimizada(int[] lista, int objetivo)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == objetivo)
                    return i;
                else if (lista[i] > objetivo) // Corte temprano
                    break;
            }
            return -1;
        }

        /*
        Explicación: Divide iterativamente el rango de búsqueda a la mitad evaluando 
        el punto medio y ajustando los límites superior e inferior.
        ¿Qué condiciones se deben cumplir?: La lista DEBE estar previamente ordenada.
        ¿Qué complejidad algorítmica tiene?: O(log N).
        */
        static int BusquedaBinariaIterativa(int[] lista, int objetivo)
        {
            int inicio = 0;
            int fin = lista.Length - 1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if (lista[medio] == objetivo)
                    return medio;
                if (lista[medio] < objetivo)
                    inicio = medio + 1;
                else
                    fin = medio - 1;
            }
            return -1;
        }

        /*
        Explicación: Aplica 'Divide y Vencerás' dividiendo el rango a la mitad 
        mediante llamadas recursivas a la función.
        ¿Qué condiciones se deben cumplir?: La lista DEBE estar ordenada.
        ¿Qué complejidad algorítmica tiene?: O(log N) en tiempo y O(log N) en espacio de memoria (pila).
        */
        static int BusquedaBinariaRecursiva(int[] lista, int objetivo, int inicio, int fin)
        {
            if (inicio > fin)
                return -1;

            int medio = inicio + (fin - inicio) / 2;

            if (lista[medio] == objetivo)
                return medio;

            if (lista[medio] < objetivo)
                return BusquedaBinariaRecursiva(lista, objetivo, medio + 1, fin);
            else
                return BusquedaBinariaRecursiva(lista, objetivo, inicio, medio - 1);
        }

        /*
        Explicación: Compara elementos adyacentes y los intercambia de posición 
        si no están en el orden correcto en pasadas sucesivas.
        ¿Qué condiciones se deben cumplir?: Ninguna condición previa.
        ¿Qué complejidad algorítmica tiene?: O(N^2) en todos los casos.
        */
        static void OrdenamientoBurbujaClasico(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write("Burbuja Clásico: ");
            ImprimirVector(arr);
        }

        /*
        Explicación: Optimización de burbuja mediante una bandera para verificar si 
        se realizaron intercambios. Si no hubo ninguno en una pasada, finaliza antes.
        ¿Qué condiciones se deben cumplir?: Ninguna condición previa.
        ¿Qué complejidad algorítmica tiene?: O(N^2) peor caso, O(N) mejor caso (lista ya ordenada).
        */
        static void OrdenamientoBurbujaOptimizado(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            int n = arr.Length;
            bool huboIntercambio;

            for (int i = 0; i < n - 1; i++)
            {
                huboIntercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        huboIntercambio = true;
                    }
                }
                if (!huboIntercambio)
                    break;
            }
            Console.Write("Burbuja Optimizado: ");
            ImprimirVector(arr);
        }

        /*
        Explicación: Encuentra en cada iteración el índice del elemento mínimo de la 
        sección no ordenada y lo intercambia con la posición actual.
        ¿Qué condiciones se deben cumplir?: Ninguna condición previa.
        ¿Qué complejidad algorítmica tiene?: O(N^2) en todos los casos.
        */
        static void OrdenamientoSeleccion(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                }
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
            Console.Write("Selección: ");
            ImprimirVector(arr);
        }

        /*
        Explicación: Construye el arreglo ordenado de forma incremental, tomando un 
        elemento e insertándolo en su posición adecuada desplazando los mayores.
        ¿Qué condiciones se deben cumplir?: Ninguna condición previa.
        ¿Qué complejidad algorítmica tiene?: O(N^2) en el peor caso, O(N) en el mejor caso.
        */
        static void OrdenamientoInsercion(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int clave = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > clave)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = clave;
            }
            Console.Write("Inserción: ");
            ImprimirVector(arr);
        }

        /*
        Explicación: Algoritmo 'Divide y Vencerás' que selecciona un pivote y acomoda 
        los menores a la izquierda y los mayores a la derecha usando índices.
        ¿Qué condiciones se deben cumplir?: Ninguna condición previa.
        ¿Qué complejidad algorítmica tiene?: O(N log N) promedio, O(N^2) en el peor caso.
        */
        static void OrdenamientoQuickSort(int[] lista)
        {
            int[] arr = (int[])lista.Clone();

            QuickSortHelper(arr, 0, arr.Length - 1);

            Console.Write("QuickSort: ");
            ImprimirVector(arr);
        }

        static void QuickSortHelper(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSortHelper(arr, low, pi - 1);
                QuickSortHelper(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
        }

        /*
        Explicación: Algoritmo meme/satírico. Recorre la lista y destruye/elimina 
        cualquier elemento que sea menor al elemento anterior.
        ¿Qué condiciones se deben cumplir?: Ninguna.
        ¿Qué complejidad algorítmica tiene?: O(N).
        */
        static void OrdenamientoStalin(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            List<int> sobrevivientes = new List<int>();

            if (arr.Length > 0)
            {
                sobrevivientes.Add(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] >= sobrevivientes[sobrevivientes.Count - 1])
                    {
                        sobrevivientes.Add(arr[i]);
                    }
                }
            }

            Console.Write("Stalin Sort (Sobrevivientes): ");
            Console.WriteLine($"[{string.Join(", ", sobrevivientes)}]");
        }

        /*
        Explicación: Reordena de forma totalmente aleatoria todos los elementos 
        y verifica si quedó ordenado. Repite iterativamente hasta que esté ordenado.
        ¿Qué condiciones se deben cumplir?: Ninguna.
        ¿Qué complejidad algorítmica tiene?: O((N+1)!) promedio. Inviable para N=50.
        */
        static void OrdenamientoBogo(int[] lista)
        {
            int[] arr = (int[])lista.Clone();
            Random rng = new Random();
            int intentos = 0;
            int maxIntentos = 100000;

            while (!EstaOrdenado(arr) && intentos < maxIntentos)
            {

                for (int i = arr.Length - 1; i > 0; i--)
                {
                    int k = rng.Next(i + 1);
                    int temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                }
                intentos++;
            }

            if (EstaOrdenado(arr))
            {
                Console.Write($"BogoSort (Exitoso en {intentos} intentos): ");
                ImprimirVector(arr);
            }
            else
            {
                Console.WriteLine($"BogoSort: Cancelado tras {intentos} intentos (N=50 requeriría un tiempo indeterminado).");
            }
        }


        static bool EstaOrdenado(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }

        static void ImprimirVector(int[] vector)
        {
            Console.WriteLine($"[{string.Join(", ", vector)}]");
        }
    }
}