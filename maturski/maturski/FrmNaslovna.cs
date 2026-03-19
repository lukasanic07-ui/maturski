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
    public partial class FrmNaslovna : Form
    {
        public FrmNaslovna()
        {
            InitializeComponent();
            UrediStil();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmNaslovna_Load(object sender, EventArgs e)
        {
            
        }
        private void UrediStil()
        {
            // Pozadina forme
            this.BackColor = Color.FromArgb(245, 247, 250);

            // Sidebar
            pnlSidebar.BackColor = Color.FromArgb(88, 86, 214);   // ljubičasta
            lblFit.ForeColor = Color.White;                       // label "Fit" (provjeri ime)

            StyleSidebarButton(btnHome);
            StyleSidebarButton(btnVjezbe);
            StyleSidebarButton(btnPlanovi);
            StyleSidebarButton(btnEvidencija);

            // Gornji panel (top bar)
            pnlTop.BackColor = Color.White;

            // Lijevi „recap” panel
            pnlRecap.BackColor = Color.FromArgb(255, 255, 230);   // blago žućkasto

            // Desni „today” panel
            pnlToday.BackColor = Color.FromArgb(255, 249, 220);   // druga nijansa
        }
        private void StyleSidebarButton(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.BackColor = Color.FromArgb(88, 86, 214);
            b.ForeColor = Color.White;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVjezbe_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmVjezbe())
            {
                frm.ShowDialog();
            }
        }

        private void btnPlanovi_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmTreningPlan())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // Opcionalno: osvjezi podatke nakon spremanja plana
                    MessageBox.Show("Trening plan spremljen!");
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmKorisnik())
            {
                frm.ShowDialog();
            }
        }
    }
}
