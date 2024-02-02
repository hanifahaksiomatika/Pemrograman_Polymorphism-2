using System;

using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism
{
    public class ConvertToXml : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            using (StringWriter writer = new StringWriter())
            {
                // konversi objek mahasiswa ke XML
                XmlSerializer serializer = new XmlSerializer(typeof(Mahasiswa));
                serializer.Serialize(writer, mhs);

                string xml = writer.ToString();

                Console.WriteLine("Hasil konversi ke XML:\n");
                Console.WriteLine(xml);
            };
        }
    }
}
