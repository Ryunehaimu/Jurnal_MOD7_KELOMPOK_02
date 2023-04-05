using Modul7_Kelompok_02;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210086 dataMahasiswa = new DataMahasiswa1302210086();
        dataMahasiswa.ReadJSON();

        TeamMembers1302210086 team = new TeamMembers1302210086();
        team.readJSON();
    }
}