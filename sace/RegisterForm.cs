using MySqlConnector;

namespace sace;

public partial class RegisterForm : Form
{
    public RegisterForm()
    {
        InitializeComponent();
    }

    private void btnRegistruj_Click(object sender, EventArgs e)
    {
        string korisnickoIme = txtKorisnickoIme.Text.Trim();
        string email = txtEmail.Text.Trim();
        string lozinka = txtLozinka.Text;
        string ponovljenaLozinka = txtPonoviLozinku.Text;

        if (korisnickoIme == "" || email == "" || lozinka == "")
        {
            MessageBox.Show("Popunite sva polja.");
            return;
        }

        if (!email.Contains('@'))
        {
            MessageBox.Show("Unesite ispravan email.");
            return;
        }

        if (lozinka.Length < 6)
        {
            MessageBox.Show("Lozinka mora imati najmanje 6 znakova.");
            return;
        }

        if (lozinka != ponovljenaLozinka)
        {
            MessageBox.Show("Lozinke se ne poklapaju.");
            return;
        }

        try
        {
            using MySqlConnection konekcija = Baza.Otvori();

            // Provjera da li korisnicko ime ili email vec postoje.
            string sqlProvjera = "SELECT COUNT(*) FROM korisnici WHERE korisnicko_ime = @ime OR email = @email";
            using MySqlCommand provjera = new MySqlCommand(sqlProvjera, konekcija);
            provjera.Parameters.AddWithValue("@ime", korisnickoIme);
            provjera.Parameters.AddWithValue("@email", email);

            long brojKorisnika = Convert.ToInt64(provjera.ExecuteScalar());
            if (brojKorisnika > 0)
            {
                MessageBox.Show("Korisničko ime ili email već postoje.");
                return;
            }

            // U bazu se ne sprema prava lozinka, nego njen hash.
            string hashLozinke = BCrypt.Net.BCrypt.HashPassword(lozinka);

            // Svaki novi nalog je obican korisnik (uloga 'korisnik').
            string sqlUnos = "INSERT INTO korisnici (korisnicko_ime, email, lozinka) VALUES (@ime, @email, @lozinka)";
            using MySqlCommand unos = new MySqlCommand(sqlUnos, konekcija);
            unos.Parameters.AddWithValue("@ime", korisnickoIme);
            unos.Parameters.AddWithValue("@email", email);
            unos.Parameters.AddWithValue("@lozinka", hashLozinke);
            unos.ExecuteNonQuery();

            MessageBox.Show("Registracija je uspješna. Sada se možete prijaviti.");
            Close();
        }
        catch (MySqlException)
        {
            MessageBox.Show("Nije moguće povezati se na bazu. Provjerite da li je MySQL pokrenut u XAMPP-u.");
        }
    }

    private void btnNazad_Click(object sender, EventArgs e)
    {
        Close();
    }
}
