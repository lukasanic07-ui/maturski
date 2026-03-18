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
    public partial class FrmTreningPlan : Form
    {
        private List<TreningVjezba> vjezbeZaDan = new List<TreningVjezba>();

        private class TreningVjezba
        {
            public string Naziv;
            public string Opis;
            public string Tip;
            public string MisicnaGrupa;
            public bool Uradjeno;
            public int UradjeniSetovi;
        }

        public FrmTreningPlan()
        {
            InitializeComponent();
            FrmTreningPlan_Load(null, null);
        }

        private void FrmTreningPlan_Load(object sender, EventArgs e)
        {
            dgvVjezbeZaDan.ColumnCount = 5;
            dgvVjezbeZaDan.Columns[0].HeaderText = "Naziv";

            dgvVjezbeZaDan.Columns[1].HeaderText = "Opis";
            dgvVjezbeZaDan.Columns[1].Width = 200;
            dgvVjezbeZaDan.Columns[2].HeaderText = "Tip";
            dgvVjezbeZaDan.Columns[3].HeaderText = "Urađeno";
            dgvVjezbeZaDan.Columns[3].Width = 80;
            dgvVjezbeZaDan.Columns[4].HeaderText = "Setovi";
            dgvVjezbeZaDan.Columns[4].Width = 60;

            lstbDani.Items.Clear();
            lstbDani.Items.Add("Ponedjeljak");
            lstbDani.Items.Add("Utorak");
            lstbDani.Items.Add("Srijeda");
            lstbDani.Items.Add("Četvrtak");
            lstbDani.Items.Add("Petak");
            lstbDani.Items.Add("Subota");
            lstbDani.Items.Add("Nedjelja");
        }

        private void lstbDani_SelectedIndexChanged(object sender, EventArgs e)
        {
            OsvjeziGrid();
        }

        private void OsvjeziGrid()
        {
            dgvVjezbeZaDan.Rows.Clear();
            foreach (var v in vjezbeZaDan)
                dgvVjezbeZaDan.Rows.Add(v.Naziv, v.Opis, v.Tip, v.Uradjeno, v.UradjeniSetovi);
        }

        private void btnDodajVjezbu_Click(object sender, EventArgs e)
        {
            FrmVjezbe f = new FrmVjezbe();
            if (f.ShowDialog() == DialogResult.OK && f.OdabranaVjezba != null)
            {
                vjezbeZaDan.Add(new TreningVjezba
                {
                    Naziv = f.OdabranaVjezba.Naziv,
                    Opis = f.OdabranaVjezba.Opis,
                    Tip = f.OdabranaVjezba.Tip,
                    MisicnaGrupa = f.OdabranaVjezba.MisicnaGrupa,
                    Uradjeno = false,
                    UradjeniSetovi = 0
                });
                OsvjeziGrid();
                MessageBox.Show("Vježba dodana u plan!");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVjezbeZaDan.CurrentRow != null)
            {
                int idx = dgvVjezbeZaDan.CurrentRow.Index;
                vjezbeZaDan.RemoveAt(idx);
                OsvjeziGrid();
                MessageBox.Show("Vježba obrisana!");
            }
            else
            {
                MessageBox.Show("Odaberi vježbu za brisanje!");
            }
        }

        private void dgvVjezbeZaDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                vjezbeZaDan[row].Uradjeno = !vjezbeZaDan[row].Uradjeno;
                OsvjeziGrid();
            }
        }

        private void btnSpremiPlan_Click(object sender, EventArgs e)
        {
            if (vjezbeZaDan.Count == 0)
            {
                MessageBox.Show("Dodaj barem jednu vježbu!");
                return;
            }

            MessageBox.Show("Plan spremljen!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvVjezbeZaDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                vjezbeZaDan[row].Uradjeno = !vjezbeZaDan[row].Uradjeno;
                OsvjeziGrid();
            }
        }
    }
}
