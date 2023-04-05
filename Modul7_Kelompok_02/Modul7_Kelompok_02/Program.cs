using Modul7_Kelompok_02;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa1302210025 dataMahasiswa = new DataMahasiswa1302210025();
        dataMahasiswa.ReadJSON();

        TeamMembers1302210025 team = new TeamMembers1302210025();
        team.readJSON();
    }
}