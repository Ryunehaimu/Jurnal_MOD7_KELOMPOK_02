using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modul7_Kelompok_02
{
    internal class TeamMembers_1302213121_PRAKTIKAN
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Jurnal_MOD7_KELOMPOK_02\\Modul7_Kelompok_02\\Modul7_Kelompok_02\\jurnal7_2_1302213121.json");
            Membersdata member = JsonSerializer.Deserialize<Membersdata>(jsonString);
            Console.WriteLine("Team member list:");
            /*
            for(int i = 0;i<members.memberlist.Count;i++)
            {
                Console.WriteLine(members.memberlist[i].nim+" " + members.memberlist[i].firstName+" "
                    + members.memberlist[i].lastName+" "+ members.memberlist[i].age+" "+ members.memberlist[i].gender);
            }
            */
            foreach (var item in member.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " "
                + item.lastName + " " + item.age + " " + item.gender);
            }
        }

        public class Membersdata
        {
            public List<member> members { get; set; }
        }

        public class member
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }

            public member() { }
        }
    }
}
