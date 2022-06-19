using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Environment;

namespace BiblioTP3
{
    public static class ManejarArchivos 
    {
        /// <summary>
        /// Recibe por parametros texto string, un booleano y un path de tipo string. Guarda el texto que se paso por parametro 
        /// en un archivo de texto en el path indicado, concatenando los datos
        /// </summary>
        /// <param name="path"></param>
        /// <param name="texto"></param>
        /// <param name="concatenar"></param>
        public static void GuardarDatosEnArchivoDeTexto(string path, string texto, bool concatenar)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(path, concatenar))
                {
                    sw.WriteLine(texto);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Lee el archivo de un path determinado, el cual se le paso por parametros
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Devuelve la informacion del archivo en modo de texto</returns>
        public static string LeerDatosDeUnArchivoTexto(string path)
        {
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
