using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPeliculas.Model
{
    public class DTORentas
    {
        public int idRenta  { get; set; }

        public DateTime FechaRenta { get; set; }

        public int idPeliculaRentada {get; set; }   

        public double TotalPagar { get; set; }

        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public int idRentaAux { get; set; } 
        
        public bool Estatus { get; set; }

    }
}
