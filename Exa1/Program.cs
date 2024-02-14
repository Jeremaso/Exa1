using Exa1;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("Selecciona una opción:");
            Console.WriteLine("1. Agregar un libro a la biblioteca");
            Console.WriteLine("2. Eliminar un libro de la biblioteca");
            Console.WriteLine("3. Mostrar todos los libros de la biblioteca");
            Console.WriteLine("4. Buscar libros");
            Console.WriteLine("5. Mostrar libro de mayor precio");
            Console.WriteLine("6. Mostrar los tres libros más baratos");
            Console.WriteLine("7. Buscar libros por inicio del nombre del autor");
            Console.WriteLine("8. Salir del programa");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Introduce los detalles del libro:");
                    Console.Write("Código: ");
                    string codigo = Console.ReadLine();
                    Console.Write("Título: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Fecha de publicación (dd/mm/yyyy): ");
                    DateTime fechaPublicacion;
                    if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaPublicacion))
                    {
                        Console.WriteLine("Fecha no válida. Por favor, intenta de nuevo.");
                        break;
                    }
                    Console.Write("Precio: ");
                    decimal precio;
                    if (!Decimal.TryParse(Console.ReadLine(), out precio))
                    {
                        Console.WriteLine("Precio no válido. Por favor, intenta de nuevo.");
                        break;
                    }
                    Libro libro = new Libro { Codigo = codigo, Titulo = titulo, Autor = autor, FechaPublicacion = fechaPublicacion, Precio = precio, Disponible = true };
                    biblioteca.AgregarLibro(libro);
                    break;
                case "2":
                    Console.Write("Introduce el código del libro que quieres eliminar: ");
                    string codigoEliminar = Console.ReadLine();
                    biblioteca.EliminarLibro(codigoEliminar);
                    break;
                case "3":
                    biblioteca.MostrarLibros();
                    break;
                case "4":
                    Console.Write("Introduce el título del libro que estás buscando: ");
                    string tituloBuscar = Console.ReadLine();
                    Biblioteca.Busca
                        libro(tituloBuscar);
                    break;
                case "5":
                    biblioteca.MostrarLibroMayorPrecio();
                    break;
                case "6":
                    biblioteca.MostrarTresLibrosMasBaratos();
                    break;
                case "7":
                    Console.Write("Introduce el inicio del nombre del autor: ");
                    string inicioNombre = Console.ReadLine();
                    biblioteca.BuscarLibrosPorInicioNombreAutor(inicioNombre);
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intenta de nuevo.");
                    break;
            }
        }
    }
}

