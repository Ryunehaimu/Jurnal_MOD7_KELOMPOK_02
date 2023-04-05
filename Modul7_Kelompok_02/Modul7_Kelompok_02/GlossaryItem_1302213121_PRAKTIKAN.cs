using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static Modul7_Kelompok_02.GlossaryItem_1302213121_PRAKTIKAN;
using static Modul7_Kelompok_02.TeamMembers_1302213121_PRAKTIKAN;

namespace Modul7_Kelompok_02
{
    internal class GlossaryItem_1302213121_PRAKTIKAN
    {
        public void ReadJSON()
        {
            String jsonString = File.ReadAllText("D:\\Jurnal_MOD7_KELOMPOK_02\\Modul7_Kelompok_02\\Modul7_Kelompok_02\\jurnal7_3_1302213121.json");
            Glossary glossary = JsonSerializer.Deserialize<Glossary>(jsonString);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.ID);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.SortAs);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.GlossTerm);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.Acronym);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.Abbrev);
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.GlossDef.para);
            foreach (var item in glossary.GlossDiv.GlossList.GlossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(glossary.GlossDiv.GlossList.GlossEntry.GlossSee);
        }

        public class Glossary
        {
            public String title { get; set; }
            public GlossDiv GlossDiv { get; set; }
        }

        public class GlossDiv
        {
            public GlossList GlossList { get; set; }
        }
        public class GlossList
        {
            public GlossEntry GlossEntry { get; set; }
        } 
        public class GlossEntry
        {
            public String ID { get; set; }
            public String SortAs { get; set; }
            public String GlossTerm { get; set; }
            public String Acronym { get; set; }
            public String Abbrev { get; set; }
            public GlossDef GlossDef { get; set; }
            public String GlossSee { get; set; }
        }

        public class GlossDef {
            public String para { get; set; }
            public List<string> GlossSeeAlso { get; set; }
        }

    }
}
