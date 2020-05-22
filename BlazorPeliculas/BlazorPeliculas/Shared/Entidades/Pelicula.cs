using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Pelicula
    {

        public string Nombre { get; set; }
        public DateTime Lanzamiento { get; set; }
        public string Poster { get; set; }
        public string TituloCortado {
            get {

                if (string.IsNullOrWhiteSpace(Nombre))
                    return null;
                else if (Nombre.Length > 60)
                    return Nombre.Substring(0, 60) + "...";
                else
                {
                    return Nombre;
                }
            }

                }
    }
}
