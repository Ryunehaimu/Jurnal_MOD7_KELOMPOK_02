using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_Kelompok_02
{
    internal class DataMahasiswa_1302213121_PRAKTIKAN
    {

        //method
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Jurnal_MOD7_KELOMPOK_02\\Modul7_Kelompok_02\\Modul7_Kelompok_02\\jurnal7_1_1302213121.json");
            mahasiswa mahasiswa = JsonSerializer.Deserialize<mahasiswa>(jsonString);
            Console.WriteLine("Nama " + mahasiswa.firstName + " " + mahasiswa.lastName + " berjenis kelamin " 
                + mahasiswa.gender +" berumur "+mahasiswa.age+" tahun " +" beralamat di " + mahasiswa.address.streetaddress 
                + "," + mahasiswa.address.city + "," + mahasiswa.address.state);
            for (int i = 0; i < mahasiswa.courses.Count; i++)
            {
                Console.WriteLine("MK " + (i + 1) + " " + mahasiswa.courses[i].code + " - " + mahasiswa.courses[i].name);
            }
        }

        public class mahasiswa
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public address address { get; set; }
            public List<courses> courses { get; set; }
        }
        public class address
        {
            public String streetaddress { get; set; }
            public String city { get; set; }
            public String state { get; set; }
        }

        public class courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }
    }
}
