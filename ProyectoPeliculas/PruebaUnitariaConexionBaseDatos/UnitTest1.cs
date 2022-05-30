using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoPeliculas.Controller;

namespace PruebaUnitariaConexionBaseDatos
{
    [TestClass]
    public class UnitTest1
    {
        BaseDatos bd = new BaseDatos();
        [TestMethod]
        public void PruebaConexion()
        {
          
            bool resultado = bd.ConexionUni();
            Assert.AreEqual(true, resultado);
        }
    }
}