namespace tareasemana13
{
    class Program
    {
        // Función para buscar Titulo
        static bool BuscarTitulo(List<string> catalogo, string titulo)
        {
            // Recorremos el elemento de la lista 
            foreach (var item in catalogo)
            {
                // Usamos StringComparison.OrdinalIgnoreCase para ignorar mayúsculas y minúsculas
                if (item.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Si encontramos el título "true"
                }
            }
            return false; // Si no encontramos el título "false"
        }

        static void Main()
        {
            // Strings para almacenar los títulos de las revistas
            List<string> catalogoRevistas = new List<string>();

            // El usuario ingresa 10 títulos de revistas
            Console.WriteLine("*******************************");
            Console.WriteLine("Ingrese 10 títulos de revistas:");
            Console.WriteLine("*******************************");

            // Bucle for para que se repite 10 veces e ingresar los títulos
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Título {i}: "); // Muestra los "Título 1", "Título 2", .....
                string titulo = Console.ReadLine();  
                catalogoRevistas.Add(titulo); // 
            }

            // Variable para controlar si el programa debe seguir ejecutándose
            bool salir = false;

            // Bucle while que se repetirá hasta que el usuario elija salir
            while (!salir)
            {
                // Mostramos el menú con las opciones disponibles
                Console.WriteLine("*******************");
                Console.WriteLine("\nMenú de opciones:");
                Console.WriteLine("");
                Console.WriteLine("*******************");
                Console.WriteLine("");
                Console.WriteLine("1. Buscar un título");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                // Leemos la opción seleccionada por el usuario
                int opcion = int.Parse(Console.ReadLine());

                // Estructura switch para manejar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        // Si el usuario selecciona la opción 1, se busca un título
                        Console.Write("Ingrese el título a buscar: "); // Pedimos el título
                        string tituloBuscar = Console.ReadLine(); // Lo leemos

                        // Llamamos a la función BuscarTitulo para buscar el título
                        bool encontrado = BuscarTitulo(catalogoRevistas, tituloBuscar);

                        // Mostramos el resultado de la búsqueda según el valor de la variable 'encontrado'
                        if (encontrado)
                        {
                            Console.WriteLine("Resultado de la búsqueda: encontrado");
                        }
                        else
                        {
                            Console.WriteLine("Resultado de la búsqueda: no encontrado");
                        }
                        break;

                    case 2:
                        // Si el usuario selecciona la opción 2, se cambia 'salir' a true y termina el bucle
                        salir = true;
                        break;

                    default:
                        // Si el usuario ingresa una opción no válida, se muestra este mensaje
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}