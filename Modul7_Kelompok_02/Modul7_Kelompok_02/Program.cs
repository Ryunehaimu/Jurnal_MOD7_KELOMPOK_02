using Modul7_Kelompok_02;

internal class Program
{
    private static void Main(string[] args)
    {
        DataMahasiswa_1302210063 dataMahasiswa = new DataMahasiswa_1302210063();
        dataMahasiswa.ReadJSON();

        TeamMembers1302210063 teamMembers = new TeamMembers1302210063();
        teamMembers.readJSON();
    }
}