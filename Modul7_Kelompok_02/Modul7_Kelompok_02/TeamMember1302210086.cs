using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_Kelompok_02
{
    internal class TeamMembers1302210086
    {
        public void readJSON()
        {
            Member memberdata = JsonSerializer.Deserialize<Member>(File.ReadAllText("../../../jurnal7_2_1302210086.json"));
            Console.WriteLine("Team Members : ");
            foreach (var item in memberdata.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + " (" + item.age + " " + item.gender + ")");
            }
        }
    }
    public class Member
    {
        public List<Member2> members { get; set; }
    }
    public class Member2
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }
}