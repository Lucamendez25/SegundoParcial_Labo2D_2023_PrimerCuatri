using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClasesCarniceria
{
    public class SerializadorJson<T> : ISerializador<T> where T : class, new()
    {
        public StreamWriter writer;
        public StreamReader reader;

        public string path;

        /// <summary>
        ///  genera el directorio para guardar el archivo
        /// </summary>
        /// <param name="archivo"></param>
        public SerializadorJson(string archivo)
        {
            this.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.path += "\\" + archivo;
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
                using (this.reader = new StreamReader(this.path))
                {
                    string json = this.reader.ReadToEnd();

                    aux = JsonSerializer.Deserialize<T>(json);
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
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Serializar(T objeto)
        {
            bool retorno = false;
            try
            {
                using (this.writer = new StreamWriter(this.path))
                {

                    string json = JsonSerializer.Serialize(objeto);

                    this.writer.Write(json);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
