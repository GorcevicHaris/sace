namespace sace;

partial class RegisterForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblNaslov = new Label();
        lblKorisnickoIme = new Label();
        txtKorisnickoIme = new TextBox();
        lblEmail = new Label();
        txtEmail = new TextBox();
        lblLozinka = new Label();
        txtLozinka = new TextBox();
        lblPonoviLozinku = new Label();
        txtPonoviLozinku = new TextBox();
        btnRegistruj = new Button();
        btnNazad = new Button();
        SuspendLayout();
        //
        // lblNaslov
        //
        lblNaslov.AutoSize = true;
        lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblNaslov.Location = new Point(30, 20);
        lblNaslov.Name = "lblNaslov";
        lblNaslov.Size = new Size(115, 25);
        lblNaslov.TabIndex = 0;
        lblNaslov.Text = "Registracija";
        //
        // lblKorisnickoIme
        //
        lblKorisnickoIme.AutoSize = true;
        lblKorisnickoIme.Location = new Point(30, 65);
        lblKorisnickoIme.Name = "lblKorisnickoIme";
        lblKorisnickoIme.Size = new Size(85, 15);
        lblKorisnickoIme.TabIndex = 1;
        lblKorisnickoIme.Text = "Korisničko ime";
        //
        // txtKorisnickoIme
        //
        txtKorisnickoIme.Location = new Point(30, 85);
        txtKorisnickoIme.Name = "txtKorisnickoIme";
        txtKorisnickoIme.Size = new Size(280, 23);
        txtKorisnickoIme.TabIndex = 2;
        //
        // lblEmail
        //
        lblEmail.AutoSize = true;
        lblEmail.Location = new Point(30, 120);
        lblEmail.Name = "lblEmail";
        lblEmail.Size = new Size(36, 15);
        lblEmail.TabIndex = 3;
        lblEmail.Text = "Email";
        //
        // txtEmail
        //
        txtEmail.Location = new Point(30, 140);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(280, 23);
        txtEmail.TabIndex = 4;
        //
        // lblLozinka
        //
        lblLozinka.AutoSize = true;
        lblLozinka.Location = new Point(30, 175);
        lblLozinka.Name = "lblLozinka";
        lblLozinka.Size = new Size(47, 15);
        lblLozinka.TabIndex = 5;
        lblLozinka.Text = "Lozinka";
        //
        // txtLozinka
        //
        txtLozinka.Location = new Point(30, 195);
        txtLozinka.Name = "txtLozinka";
        txtLozinka.Size = new Size(280, 23);
        txtLozinka.TabIndex = 6;
        txtLozinka.UseSystemPasswordChar = true;
        //
        // lblPonoviLozinku
        //
        lblPonoviLozinku.AutoSize = true;
        lblPonoviLozinku.Location = new Point(30, 230);
        lblPonoviLozinku.Name = "lblPonoviLozinku";
        lblPonoviLozinku.Size = new Size(87, 15);
        lblPonoviLozinku.TabIndex = 7;
        lblPonoviLozinku.Text = "Ponovi lozinku";
        //
        // txtPonoviLozinku
        //
        txtPonoviLozinku.Location = new Point(30, 250);
        txtPonoviLozinku.Name = "txtPonoviLozinku";
        txtPonoviLozinku.Size = new Size(280, 23);
        txtPonoviLozinku.TabIndex = 8;
        txtPonoviLozinku.UseSystemPasswordChar = true;
        //
        // btnRegistruj
        //
        btnRegistruj.Location = new Point(30, 290);
        btnRegistruj.Name = "btnRegistruj";
        btnRegistruj.Size = new Size(135, 32);
        btnRegistruj.TabIndex = 9;
        btnRegistruj.Text = "Registruj se";
        btnRegistruj.UseVisualStyleBackColor = true;
        btnRegistruj.Click += btnRegistruj_Click;
        //
        // btnNazad
        //
        btnNazad.Location = new Point(175, 290);
        btnNazad.Name = "btnNazad";
        btnNazad.Size = new Size(135, 32);
        btnNazad.TabIndex = 10;
        btnNazad.Text = "Nazad";
        btnNazad.UseVisualStyleBackColor = true;
        btnNazad.Click += btnNazad_Click;
        //
        // RegisterForm
        //
        AcceptButton = btnRegistruj;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(340, 345);
        Controls.Add(btnNazad);
        Controls.Add(btnRegistruj);
        Controls.Add(txtPonoviLozinku);
        Controls.Add(lblPonoviLozinku);
        Controls.Add(txtLozinka);
        Controls.Add(lblLozinka);
        Controls.Add(txtEmail);
        Controls.Add(lblEmail);
        Controls.Add(txtKorisnickoIme);
        Controls.Add(lblKorisnickoIme);
        Controls.Add(lblNaslov);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Registracija";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNaslov;
    private Label lblKorisnickoIme;
    private TextBox txtKorisnickoIme;
    private Label lblEmail;
    private TextBox txtEmail;
    private Label lblLozinka;
    private TextBox txtLozinka;
    private Label lblPonoviLozinku;
    private TextBox txtPonoviLozinku;
    private Button btnRegistruj;
    private Button btnNazad;
}
