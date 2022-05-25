using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPeliculas.Model
{
    public class DTOPeliculas
    {
        public int IdPeliculas { get; set; }
        public string Nombre { get; set; }

        public string Duracion { get; set; }

        public string Clasificacion { get; set; }
        
        public int PeliculasDisponibles { get; set; }

        public double Precio { get; set; }

        public string Genero { get; set; }

        public string Director { get; set; }

        public DateTime AnoLanzamiento { get; set; }

        public bool Status { get; set; }

        public List<AddPelicula> peliculas = new List<AddPelicula>(); 


    }
}
