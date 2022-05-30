using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPeliculas;
using ProyectoPeliculas.Controller;

namespace PruebasUnitariasPelicula
{
    [TestClass]
    public class UnitTest1
    {
        DAOPeliculas dao = new DAOPeliculas();
        [TestMethod]
        public void AgregarPeliculas()
        {

           string sentencia = "INSERT INTO pelicula.pelis Values(0,'Bambi','2 Horas','Infantil',10,100,'Accion','Juan Perez','2002/05,20'";
            bool correcta = dao.agregarUni(sentencia);
            Assert.AreEqual(true, correcta);
           
        }

        [TestMethod]
        public void ModificarPelicula()
        {

            string sentencia = "UPDATE peliculas.pelis SET Nombre = 'bambi', Duracion = '2 Horas', Clasificacion = 'A', CantidadPeliculasDisponibles = 10, PreciodeRenta = 10" +
                ",Genero = 'Accion', Director = 'Juan Perez', AnoLanzamiento = '2002/05/20', Estatus = true WHERE IdPelicula = 1";
            bool correcta = dao.ModificarUni(sentencia);
            Assert.AreEqual(true, correcta);

        }
        [TestMethod]
        public void ModificarEstatus()
        {

            string sentencia = "update peliculas.pelis set Estatus = 0 where IdPelicula = 1";
            bool correcta = dao.ModificarEstatusUni(sentencia);
            Assert.AreEqual(true, correcta);

        }
        [TestMethod]
        public void MostrarPeliculas()
        {

            string sentencia = "SELECT * FROM peliculas.pelis";
            bool correcta = dao.MostrarPeliculasUni(sentencia);
            Assert.AreEqual(true, correcta);

        }

       
       




    }
}