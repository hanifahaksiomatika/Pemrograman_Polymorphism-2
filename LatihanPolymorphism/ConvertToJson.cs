using System;

using Newtonsoft.Json;

namespace LatihanPolymorphism
{
    public class ConvertToJson : IConvertObject
    {
        public void Convert(Mahasiswa mhs)
        {
            // konversi objek mahasiswa ke json
            string json = JsonConvert.SerializeObject(mhs);

            Console.WriteLine("Hasil konversi ke json:\n");
            Console.WriteLine(json);
        }
    }
}


