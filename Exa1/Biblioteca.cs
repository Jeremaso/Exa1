using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exa1
{
    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            if (libro == null)
            {
                throw new ArgumentNullException(nameof(libro));
            }
            if (libros.Any(l => l.Codigo == libro.Codigo))
            {
                throw new ArgumentException("Ya existe un libro con el mismo código.");
            }
            libros.Add(libro);
        }

        public void EliminarLibro(string codigo)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new ArgumentException("El código no puede estar vacío.");
            }
            var libro = libros.FirstOrDefault(l => l.Codigo == codigo);
            if (libro == null)
            {
                throw new ArgumentException("No se encontró ningún libro con el código proporcionado.");
            }
            libros.Remove(libro);
        }

        public void MostrarLibros()
        {
            if (!libros.Any())
            {
                throw new InvalidOperationException("La biblioteca no tiene libros.");
            }
            foreach (var libro in libros)
            {
                libro.Consultar();
            }
        }

        internal void BuscarLibros(string? tituloBuscar)
        {
            throw new NotImplementedException();
        }

        internal void BuscarLibrosPorInicioNombreAutor(string? inicioNombre)
        {
            throw new NotImplementedException();
        }

        internal void MostrarLibroMayorPrecio()
        {
            throw new NotImplementedException();
        }

        internal void MostrarTresLibrosMasBaratos()
        {
            throw new NotImplementedException();
        }

        internal class Busca
        {
        }
    }

}
