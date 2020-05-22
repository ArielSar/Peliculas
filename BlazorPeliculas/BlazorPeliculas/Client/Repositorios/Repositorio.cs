using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {   
            new Pelicula() { Nombre = "Spiderman", Lanzamiento = new DateTime(2019, 10, 20), 
                Poster="https://m.media-amazon.com/images/M/MV5BZDEyN2NhMjgtMjdhNi00MmNlLWE5YTgtZGE4MzNjMTRlMGEwXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_UY148_CR0,0,100,148_.jpg" },
            new Pelicula() { Nombre = "The 4 Factastics", Lanzamiento = new DateTime(2018, 12, 21),
                Poster ="https://m.media-amazon.com/images/M/MV5BMTk0OTMyMDA0OF5BMl5BanBnXkFtZTgwMzY5NTkzNTE@._V1_UX100_CR0,0,100,148_.jpg" },
            new Pelicula() { Nombre = "Superman", Lanzamiento = new DateTime(2017, 11, 22), 
                Poster="https://m.media-amazon.com/images/M/MV5BNzY2ZDQ2MTctYzlhOC00MWJhLTgxMmItMDgzNDQwMDdhOWI2XkEyXkFqcGdeQXVyNjc1NTYyMjg@._V1_UX100_CR0,1,100,148_.jpg" }
            };
        }
    }
}
