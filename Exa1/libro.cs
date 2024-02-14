using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exa1
{
    public class Libro
    {
        private string codigo;
        private string titulo;
        private string autor;
        private DateTime fechaPublicacion;
        private decimal precio;
        private bool disponible;

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El código no puede estar vacío.");
                }
                codigo = value;
            }
        }

        public string Titulo
        {
            get { return titulo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El título no puede estar vacío.");
                }
                titulo = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("El autor no puede estar vacío.");
                }
                autor = value;
            }
        }

        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("La fecha de publicación no puede ser futura.");
                }
                fechaPublicacion = value;
            }
        }

        public decimal Precio
        {
            get { return precio; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio no puede ser negativo.");
                }
                precio = value;
            }
        }

        public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }
        public void Prestar()
        {
            if (!Disponible)
            {
                throw new InvalidOperationException("El libro no está disponible para prestar.");
            }
            Disponible = false;
        }

        public void Devolver()
        {
            if (Disponible)
            {
                throw new InvalidOperationException("El libro ya ha sido devuelto.");
            }
            Disponible = true;
        }

        public void Consultar()
        {
            if (string.IsNullOrEmpty(Titulo) || string.IsNullOrEmpty(Autor))
            {
                throw new InvalidOperationException("El libro no tiene título o autor.");
            }
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Disponible: {Disponible}");
        }
    }
}