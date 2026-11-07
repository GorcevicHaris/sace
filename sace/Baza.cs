using MySqlConnector;

namespace sace;

// Ovdje je sve sto treba za povezivanje na bazu.
internal static class Baza
{
    // XAMPP po defaultu ima korisnika root bez lozinke.
    private const string PodaciZaKonekciju = "Server=localhost;Port=3306;Database=sace;User ID=root;Password=;";

    public static MySqlConnection Otvori()
    {
        MySqlConnection konekcija = new MySqlConnection(PodaciZaKonekciju);
        konekcija.Open();
        return konekcija;
    }
}
