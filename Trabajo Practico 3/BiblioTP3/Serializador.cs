using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace BiblioTP3
{
    public static class Serializador <T> where T : class, new()
    {
        /// <summary>
        /// Guarda el tipo de Dato, el cual es generico, en un archivo xml con un path determinado. 
        /// </summary>
        /// <param name="listaVentas"></param>
        /// <param name="path"></param>
        public static void GuardarArchivoXml(T listaVentas, string path)
        {
            try
            {
                using(StreamWriter sm = new StreamWriter(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(sm, listaVentas);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        [XmlInclude (typeof(Ventas))]


        /// <summary>
        /// Lee un archivo de un path determinado, compuesto por un conjunto de datos genericos, y los devuelve.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Devuelve un conjunto de datos genericos serializados</returns>
        public static T LeerArchivoXml(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                    return xmlSerializer.Deserialize(sr) as T;
                }
            }
            catch(Exception)
            {
                throw;
            }          
        }
        
    }
}
