using Modul7_Kelompok_02;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210093 dataMahasiswa = new DataMahasiswa1302210093();
        dataMahasiswa.ReadJSON();

        TeamMembers1302210093 team = new TeamMembers1302210093();
        team.readJSON();
    }
}