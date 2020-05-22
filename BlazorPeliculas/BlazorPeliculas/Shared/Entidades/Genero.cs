using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Genero
    {

        public int GeneroID { get; set; }
        [Required(ErrorMessage ="El Campo {0} es Requerido!")]
        public string  GeneroNombre { get; set; }
    }
}
