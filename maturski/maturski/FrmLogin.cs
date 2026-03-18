using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {

        private List<Korisnik> korisnici = new List<Korisnik>();
        private Korisnik trenutniKorisnik;
        public FrmLogin()

        {
            InitializeComponent();
            UcitajTestKorisnike();
        }

          private void UcitajTestKorisnike()
    {
        korisnici.Add(new Korisnik { KorisnikID = 1, Ime = "Marko Petrović", Email = "marko@test.com", Lozinka = "123" });
        korisnici.Add(new Korisnik { KorisnikID = 2, Ime = "Ana Horvat", Email = "ana@test.com", Lozinka = "123" });
    }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             string email = txtEmail.Text;
        string pass = txtLozinka.Text;

        trenutniKorisnik = korisnici.FirstOrDefault(k => 
            k.Email == email && k.Lozinka == pass);

        if (trenutniKorisnik != null)
        {
            MessageBox.Show("Dobrodošao {trenutniKorisnik.Ime}!");
           /* FrmDashboard dashboard = new FrmDashboard(trenutniKorisnik);
            dashboard.Show();
            this.Hide();  // Login se sakrije*/
        }
        else
        {
            MessageBox.Show("Pogrešan email/lozinka!");
            txtLozinka.Clear();
        }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            {
               /* FrmRegistracija reg = new FrmRegistracija(korisnici);
                if (reg.ShowDialog() == DialogResult.OK)
                    UcitajTestKorisnike();  // Refresh liste*/
            }
        }
    }
}
public class Korisnik
{
    public int KorisnikID { get; set; }
    public string Ime { get; set; }
    public string Email { get; set; }
    public string Lozinka { get; set; }
    public double Tezina { get; set; }
    public double Visina { get; set; }
}