using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPeliculas.Controller;
using ProyectoPeliculas.Controller.Rentas;

namespace PruebasUnitariasRentas
{
    [TestClass]
    public class UnitTest1
    {
        DAORentas dao = new DAORentas();
        [TestMethod]
        public void AgregarRentasUni()
        {
            string sentencia = "INSERT INTO peliculas.rentas VALUES(0,'Juanito','2022/05/18','2022/05/23',100,1";
            bool correcta = dao.agregarUni(sentencia);
            Assert.AreEqual(true, correcta);

        }
        [TestMethod]
        public void ModificarRenta()
        {

            string sentencia = "UPDATE peliculas.auxrentas SET Cantidad = 10, Activa = 1 where IdPeliculas = 1 and IdRentas = 1";
            bool correcta = dao.ModificarUni(sentencia);
            Assert.AreEqual(true, correcta);

        }
        [TestMethod]
        public void ModificarEstatus()
        {

            string sentencia = "UPDATE peliculas.rentas SET Activa = 0";
            bool correcta = dao.ModificarEstatusUni(sentencia);
            Assert.AreEqual(true, correcta);

        }
      
        [TestMethod]
        public void Mostrar()
        {

            string sentencia = "SELECT * FROM peliculas.rentas";
            bool correcta = dao.MostrarRentasUni(sentencia);
            Assert.AreEqual(true, correcta);

        }



    }
}