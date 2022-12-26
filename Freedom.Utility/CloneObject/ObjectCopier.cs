using System.Runtime.Serialization;
using System.Xml;

namespace Freedom.Utility.CloneObject
{
    /// <summary>
    /// Object Copier
    /// </summary>
    public static class ObjectCopier
    {
        /// <summary>
        /// Clone by System.Text.Json
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="theObject"></param>
        /// <returns></returns>
        public static T CloneJson<T>(this T theObject) where T : class
        {
            string jsonData = System.Text.Json.JsonSerializer.Serialize(theObject);
            return System.Text.Json.JsonSerializer.Deserialize<T>(jsonData);
        }

        /// <summary>
        /// Perform a deep Copy of an object that is marked with '[DataContract]'
        /// </summary>
        /// <typeparam name="T">The type of object being copied.</typeparam>
        /// <param name="source">The object instance to copy.</param>
        /// <returns>The copied object.</returns>
        public static T CloneUsingDataContracts<T>(T source)
        {
            if (!IsDataContract(typeof(T)))
            {
                throw new ArgumentException("The type must be a data contract.", "source");
            }

            // ** Don't serialize a null object, simply return the default for that object
            if (source == null)
            {
                return default;
            }

            DataContractSerializer dcs = new DataContractSerializer(typeof(T));

            using (Stream stream = new MemoryStream())
            {
                using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateBinaryWriter(stream))
                {
                    dcs.WriteObject(writer, source);
                    writer.Flush();
                    stream.Seek(0, SeekOrigin.Begin);

                    using (XmlDictionaryReader reader = XmlDictionaryReader.CreateBinaryReader(stream, XmlDictionaryReaderQuotas.Max))
                    {
                        return (T)dcs.ReadObject(reader);
                    }
                }
            }
        }

        /// <summary>
        /// Helper function to check if a class is a [DataContract]
        /// </summary>
        /// <param name="type">The type of the object to check.</param>
        /// <returns>Boolean flag indicating if the class is a DataContract (true) or not (false) </returns>
        public static bool IsDataContract(Type type)
        {
            object[] attributes = type.GetCustomAttributes(typeof(DataContractAttribute), false);
            return attributes.Length == 1;
        }
    }
}