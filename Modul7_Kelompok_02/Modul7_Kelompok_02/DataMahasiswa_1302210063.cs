using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_Kelompok_02
{
    internal class DataMahasiswa_1302210063
    {

        public void ReadJSON()
        {
            Data myda = JsonSerializer.Deserialize<Data>(File.ReadAllText("../../../jurnal7_1_1302210063.json"));
            Console.WriteLine("Firstname : " + myda.firstName);
            Console.WriteLine("Lastname : " + myda.lastName);
            Console.WriteLine("Gender : " + myda.gender);
            Console.WriteLine("Address : ");
            Console.WriteLine("     Street Address : " + myda.address.streetAddress);
            Console.WriteLine("     City : " + myda.address.city);
            Console.WriteLine("     State : " + myda.address.state);
            Console.WriteLine("Courses : ");
            foreach (var item in myda.courses)
            {
                Console.WriteLine(item.code + " - " + item.name);
            }
        }
    }
    public class Data
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Course> courses { get; set; }
    }
    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

}