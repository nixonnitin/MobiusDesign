using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Mobius.Data;

namespace Mobius.Services
{
    public class ReadConfiguration
    {
        public ReadConfiguration()
        {
        }

        public static T GetResourceAttributes<T>(string elementName)
        {
            Assembly assembly = typeof(MyClass).GetTypeInfo().Assembly;
            string[] resources = assembly.GetManifestResourceNames();

            T parsedObject = default(T);
            foreach (string resource in resources)
            {
                if (resource.EndsWith(".xml"))
                {
                    Stream stream = assembly.GetManifestResourceStream(resource);
                    if (stream != null)
                    {
                        using (var reader = new System.IO.StreamReader(stream))
                        {
                            XmlRootAttribute xRoot = new XmlRootAttribute();
                            xRoot.ElementName = elementName;
                            xRoot.IsNullable = true;

                            var objserializer = new XmlSerializer(typeof(T));
                            parsedObject = (T)objserializer.Deserialize(reader);
                        }
                    }
                }
            }
            return parsedObject;
        }

    }
}
