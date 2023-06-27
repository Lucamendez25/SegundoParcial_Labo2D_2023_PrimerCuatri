using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClasesCarniceria
{
    public class SerializadorXml<T> : ISerializador<T> where T : class, new()
    {
        private StreamWriter writer;
        private StreamReader reader;
        public XmlSerializer serializer;

        private string path;

        /// <summary>
        ///  genera el directorio para guardar el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public SerializadorXml(string archivo)
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += "\\" + archivo;
        }

        /// <summary>
        ///  deserializa objeto q contega
        /// </summary>
        /// <returns></returns>
        public T Deserializar()
        {
            T aux = new T();
            try
            {
                using (reader = new StreamReader(path))
                {
                    serializer = new XmlSerializer(typeof(T));
                    aux = (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return aux;
        }
        /// <summary>
        ///  serializa cualquier objeto que reciba
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Serializar(T item)
        {
            bool retorno = false;
            try
            {
                using (writer = new StreamWriter(path))
                {
                    serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(writer, item);
                }
                retorno = true;
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
