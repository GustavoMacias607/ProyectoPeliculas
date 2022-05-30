using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPeliculas.Controller;

namespace PruebasUnitariasPelicula
{
    [TestClass]
    public class UnitTest1
    {
        DAOPeliculas pe = new DAOPeliculas();
        [TestMethod]
        public void MostrarPeliculas()
        {

           // string sentencia = "SELECT * FROM peliculas.pelis WHERE Estatus = 1 and CantidadPeliculasDisponibles >= 1";
            //bool correcta = pe.datosDisponibles(sentencia);
            //Assert.AreEqual(true, sentencia);
        }
    }
}