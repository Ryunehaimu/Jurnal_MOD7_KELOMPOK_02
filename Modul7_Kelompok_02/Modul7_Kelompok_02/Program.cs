// See https://aka.ms/new-console-template for more information
using Modul7_Kelompok_02;

DataMahasiswa_1302213121_PRAKTIKAN mahasiswa = new DataMahasiswa_1302213121_PRAKTIKAN();
mahasiswa.ReadJSON();
Console.WriteLine("");
TeamMembers_1302213121_PRAKTIKAN member = new TeamMembers_1302213121_PRAKTIKAN();
member.ReadJSON();
Console.WriteLine("");
GlossaryItem_1302213121_PRAKTIKAN glossary = new GlossaryItem_1302213121_PRAKTIKAN();
glossary.ReadJSON();