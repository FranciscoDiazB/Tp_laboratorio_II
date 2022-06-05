using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioTP3;

namespace PruebasUnitariasPintureria
{
    [TestClass]
    public class PintureriaUT
    {
        /// <summary>
        /// Realiza el testing del metodo CalcularComision() con valores inferiores a 15000
        /// </summary>
        [TestMethod]
        public void CalcularComision_CuandoElPrecioTotalDeLaVentaEsInferiorA15000Pesos_DeberiaRetornar0()
        {
            //Arrange 
            float totalVenta = 14999.9f;
            float expected = 0;
            float actual;

            //Act
            actual = MetodosAyuda.CalcularComision(totalVenta);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo CalcularComision() con valores entre 15000 y 30000
        /// </summary>
        [TestMethod]
        public void CalcularComision_CuandoElPrecioTotalDeLaVentaEstaEntre15000Y30000Pesos_DeberiaRetornarUn5PorCientoDelTotal()
        {
            //Arrange 
            float totalVenta = 25000;
            float expected = 1250;
            float actual;

            //Act
            actual = MetodosAyuda.CalcularComision(totalVenta);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo CalcularComision() con valores superiores a 30000
        /// </summary>
        [TestMethod]
        public void CalcularComision_CuandoElPrecioTotalDeLaVentaEsSuperiorA30000Pesos_DeberiaRetornarUn10PorCientoDelTotal()
        {
            //Arrange 
            float totalVenta = 47900;
            float expected = 4790;
            float actual;

            //Act
            actual = MetodosAyuda.CalcularComision(totalVenta);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo CalcularTotal()
        /// </summary>
        [TestMethod]
        public void CalcularTotal_CuandoRecibeElPrecioYLaCantidadDeUnidadesEnFormatoString_DeberiaLaMultiplicacionDeAmbos()
        {
            //Arrange 
            float precioPintura = 4790;
            string unidades = "5";
            float expected = precioPintura * 5;
            float actual;

            //Act
            actual = MetodosAyuda.CalcularTotal(precioPintura, unidades);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo AplicarDescuento() utilizando el metodo de pago Efectivo
        /// </summary>
        [TestMethod]
        public void CalcularDescuento_CuandoRecibeElTotalYMetodoDePagoEfectivo_DeberiaAplicarUnDescuentoDel10PorCiento()
        {
            //Arrange 
            float precioVentaPreDescuento = 15000;
            string metodoPago = "Efectivo";
            float expected = 13500;
            float actual;

            //Act
            actual = MetodosAyuda.AplicarDescuentoCorrespondiente(precioVentaPreDescuento, metodoPago);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo AplicarDescuento() utilizando el metodo de pago Transferencia
        /// </summary>
        [TestMethod]
        public void CalcularDescuento_CuandoRecibeElTotalYMetodoDePagoTransferencia_DeberiaAplicarUnDescuentoDel5PorCiento()
        {
            //Arrange 
            float precioVentaPreDescuento = 15000;
            string metodoPago = "Transferencia";
            float expected = 14250;
            float actual;

            //Act
            actual = MetodosAyuda.AplicarDescuentoCorrespondiente(precioVentaPreDescuento, metodoPago);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testing del metodo AplicarDescuento() utilizando el metodo de pago Tarjeta de Credito
        /// </summary>
        [TestMethod]
        public void CalcularDescuento_CuandoRecibeElTotalYMetodoDePagoTarjetaCredito_NoDeberiaAplicarNingunDescuento()
        {
            //Arrange 
            float precioVentaPreDescuento = 15000;
            string metodoPago = "Tarjeta de Credito";
            float expected = 15000;
            float actual;

            //Act
            actual = MetodosAyuda.AplicarDescuentoCorrespondiente(precioVentaPreDescuento, metodoPago);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Realiza el testin del metodo NumeroPositivo() validando que el numero ingresado sea mayor a 0
        /// </summary>
        [TestMethod]
        public void VerificarNumero_CuandoRecibeUnStringMayorA0_DeberiaDevolverTrue()
        {
            //Arrange 
            string numero = "15";
            bool expected = true;
            bool actual;

            //Act
            actual = MetodosAyuda.NumeroPositivo(numero);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
