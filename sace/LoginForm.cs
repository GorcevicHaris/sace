using MySqlConnector;

namespace sace;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnPrijava_Click(object sender, EventArgs e)
    {
        string korisnickoIme = txtKorisnickoIme.Text.Trim();
        string lozinka = txtLozinka.Text;

        if (korisnickoIme == "" || lozinka == "")
        {
            MessageBox.Show("Unesite korisničko ime i lozinku.");
            return;
        }

        try
        {
            using MySqlConnection konekcija = Baza.Otvori();

            string sql = "SELECT lozinka, uloga FROM korisnici WHERE korisnicko_ime = @ime";
            using MySqlCommand komanda = new MySqlCommand(sql, konekcija);
            komanda.Parameters.AddWithValue("@ime", korisnickoIme);

            using MySqlDataReader red = komanda.ExecuteReader();

            // Ako korisnik ne postoji ili lozinka nije tacna, poruka je ista.
            if (!red.Read() || !BCrypt.Net.BCrypt.Verify(lozinka, red.GetString("lozinka")))
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
                return;
            }

            if (red.GetString("uloga") == "admin")
            {
                MessageBox.Show("Prijavljeni ste kao administrator.");
            }
            else
            {
                MessageBox.Show("Prijavljeni ste kao korisnik.");
            }
        }
        catch (MySqlException)
        {
            MessageBox.Show("Nije moguće povezati se na bazu. Provjerite da li je MySQL pokrenut u XAMPP-u.");
        }
    }

    private void btnRegistracija_Click(object sender, EventArgs e)
    {
        RegisterForm forma = new RegisterForm();
        forma.ShowDialog();
    }
}
