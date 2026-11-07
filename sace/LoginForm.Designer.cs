namespace sace;

partial class LoginForm
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
        lblLozinka = new Label();
        txtLozinka = new TextBox();
        btnPrijava = new Button();
        btnRegistracija = new Button();
        SuspendLayout();
        //
        // lblNaslov
        //
        lblNaslov.AutoSize = true;
        lblNaslov.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblNaslov.Location = new Point(30, 20);
        lblNaslov.Name = "lblNaslov";
        lblNaslov.Size = new Size(168, 25);
        lblNaslov.TabIndex = 0;
        lblNaslov.Text = "Prodavnica meda";
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
        // lblLozinka
        //
        lblLozinka.AutoSize = true;
        lblLozinka.Location = new Point(30, 120);
        lblLozinka.Name = "lblLozinka";
        lblLozinka.Size = new Size(47, 15);
        lblLozinka.TabIndex = 3;
        lblLozinka.Text = "Lozinka";
        //
        // txtLozinka
        //
        txtLozinka.Location = new Point(30, 140);
        txtLozinka.Name = "txtLozinka";
        txtLozinka.Size = new Size(280, 23);
        txtLozinka.TabIndex = 4;
        txtLozinka.UseSystemPasswordChar = true;
        //
        // btnPrijava
        //
        btnPrijava.Location = new Point(30, 180);
        btnPrijava.Name = "btnPrijava";
        btnPrijava.Size = new Size(135, 32);
        btnPrijava.TabIndex = 5;
        btnPrijava.Text = "Prijavi se";
        btnPrijava.UseVisualStyleBackColor = true;
        btnPrijava.Click += btnPrijava_Click;
        //
        // btnRegistracija
        //
        btnRegistracija.Location = new Point(175, 180);
        btnRegistracija.Name = "btnRegistracija";
        btnRegistracija.Size = new Size(135, 32);
        btnRegistracija.TabIndex = 6;
        btnRegistracija.Text = "Registracija";
        btnRegistracija.UseVisualStyleBackColor = true;
        btnRegistracija.Click += btnRegistracija_Click;
        //
        // LoginForm
        //
        AcceptButton = btnPrijava;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(340, 235);
        Controls.Add(btnRegistracija);
        Controls.Add(btnPrijava);
        Controls.Add(txtLozinka);
        Controls.Add(lblLozinka);
        Controls.Add(txtKorisnickoIme);
        Controls.Add(lblKorisnickoIme);
        Controls.Add(lblNaslov);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Prijava";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNaslov;
    private Label lblKorisnickoIme;
    private TextBox txtKorisnickoIme;
    private Label lblLozinka;
    private TextBox txtLozinka;
    private Button btnPrijava;
    private Button btnRegistracija;
}
