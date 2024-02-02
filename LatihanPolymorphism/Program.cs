using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo Polymorphism Menggunakan Interface";
            
            // contoh data mahasiswa
            Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "22.11.5121";
            mhs.nama = "Hanifah Putri Aksiomatika";
            mhs.email = "haniaksioma@students.amikom.ac.id";

            Console.WriteLine("Pilih Format Konversi Data:");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3. Csv\n");

            Console.Write("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IConvertObject convert; // deklarasi objek konversi

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXml();
            else
                convert = new ConvertToCsv();

            // konversi objek mhs berdasarkan format yang dipilih
            convert.Convert(mhs);

            // buat objek mahasiswa
            /*Mahasiswa mhs = new Mahasiswa();
            mhs.npm = "22.11.5121";
            mhs.nama = "Hanifah Putri Aksiomatika";
            mhs.email = "haniaksioma@students.amikom.ac.id";

            IConvertObject convertObject; // deklarasi objek konversi

            // buat objek dari class ConvertToCsv
            convertObject = new ConvertToCsv();
            convertObject.Convert(mhs);

            // buat objek dari class ConvertToJson
            convertObject = new ConvertToJson();
            convertObject.Convert(mhs);*/

            Console.ReadKey();
        }
    }
}
