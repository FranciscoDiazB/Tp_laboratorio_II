using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BiblioTP3
{
    public class CargandoBarra
    {
        public delegate void BarraCompletaHandler();

        public event BarraCompletaHandler OnBarraCompleta;

        /// <summary>
        /// Metodo el cual incrementa el valor recibido por parametros e invoca un proceso.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>El valor incrementado</returns>
        public int CargarBarra(int valor)
        {
            while(valor <= 99)
            {
                Thread.Sleep(1);
                valor++;
            }
            OnBarraCompleta.Invoke();
            return valor;
        }
    }
}
