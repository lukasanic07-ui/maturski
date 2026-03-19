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
    public partial class FrmVjezbe : Form
    {
        private List<Vjezba> listaVjezb = new List<Vjezba>();
        private int trenutniID = 1;
        private string trenutniSortKolona = "";
        private bool sortAsc = true;
        private string filterTip = "";
        private string filterGrupa = "";

        bool darkMode = false;
        int hoveredRow = -1;
        public Vjezba OdabranaVjezba { get; set; }

        public FrmVjezbe()
        {
            InitializeComponent();
            FrmVjezbe_Load(null, null);
        }

        private void UcitajTestPodatke()
        {
            listaVjezb.Add(new Vjezba { VjezbaID = 1, Naziv = "Čučanj", Opis = "Osnovna vježba za kvadricepse i gluteuse, čučanj sa tegom", Tip = "Snaga", MisicnaGrupa = "Noge" });
            listaVjezb.Add(new Vjezba { VjezbaID = 2, Naziv = "Bench Press", Opis = "Ležanje sa tegom za razvoj prsa, tricepsa i prednjih deltoida", Tip = "Snaga", MisicnaGrupa = "Prsa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 3, Naziv = "Deadlift", Opis = "Mrtvo dizanje za leđa, stražnje lože i jezgru, ključna vježba", Tip = "Snaga", MisicnaGrupa = "Leđa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 4, Naziv = "Pull Up", Opis = "Podizanje na sklopici za širinu leđa i biceps, bodyweight vježba", Tip = "Snaga", MisicnaGrupa = "Leđa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 5, Naziv = "Trčanje", Opis = "Kardio vježba na traci ili napolju, poboljšava izdržljivost", Tip = "Kardio", MisicnaGrupa = "Cijelo tijelo" });
        }

        private void UcitajListu()
        {
            dgvVjezbe.Rows.Clear();
            foreach (Vjezba v in listaVjezb)
            {
                dgvVjezbe.Rows.Add(v.VjezbaID, v.Naziv, v.Opis, v.Tip, v.MisicnaGrupa);
            }
        }

        private void OcistiPolja()
        {
            txtNaziv.Clear();
            txtOpis.Clear();
            cmbTip.SelectedIndex = 0;
            cmbGrupa.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listaVjezb.Add(new Vjezba
            {
                VjezbaID = trenutniID++,
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                Tip = cmbTip.SelectedItem.ToString(),
                MisicnaGrupa = cmbGrupa.SelectedItem.ToString()
            });
            MessageBox.Show("Vježba dodana!");
            OcistiPolja();
            UcitajListu();
        }

        private void dgvVjezbe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null)
            {
            }
        }

        private void FrmVjezbe_Load(object sender, EventArgs e)
        {
            UrediGrid();
            dgvVjezbe.AutoGenerateColumns = false;

            dgvVjezbe.Columns.Clear();

            dgvVjezbe.Columns.Add("VjezbaID", "ID");
            dgvVjezbe.Columns[0].Width = 40;
            dgvVjezbe.Columns.Add("Naziv", "Naziv");
            dgvVjezbe.Columns[1].Width = 100;
            dgvVjezbe.Columns.Add("Opis", "Opis");
            dgvVjezbe.Columns[2].Width = 250;
            dgvVjezbe.Columns.Add("Tip", "Tip");
            dgvVjezbe.Columns[3].Width = 80;
            dgvVjezbe.Columns.Add("MisicnaGrupa", "Grupa");
            dgvVjezbe.Columns[4].Width = 80;

            dgvVjezbe.Columns["VjezbaID"].Width = 45;
            dgvVjezbe.Columns["Naziv"].Width = 130;
            dgvVjezbe.Columns["Opis"].Width = 370;
            dgvVjezbe.Columns["Tip"].Width = 85;
            dgvVjezbe.Columns["MisicnaGrupa"].Width = 85;

            listaVjezb.Clear();
            listaVjezb.Add(new Vjezba { VjezbaID = 1, Naziv = "Čučanj", Opis = "Osnovna vježba za kvadricepse i gluteuse, čučanj sa tegom", Tip = "Snaga", MisicnaGrupa = "Noge" });
            listaVjezb.Add(new Vjezba { VjezbaID = 2, Naziv = "Bench Press", Opis = "Ležanje sa tegom za razvoj prsa, tricepsa i prednjih deltoida", Tip = "Snaga", MisicnaGrupa = "Prsa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 3, Naziv = "Deadlift", Opis = "Mrtvo dizanje za leđa, stražnje lože i jezgru, ključna vježba", Tip = "Snaga", MisicnaGrupa = "Leđa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 4, Naziv = "Pull Up", Opis = "Podizanje na sklopici za širinu leđa i biceps, bodyweight vježba", Tip = "Snaga", MisicnaGrupa = "Leđa" });
            listaVjezb.Add(new Vjezba { VjezbaID = 5, Naziv = "Trčanje", Opis = "Kardio vježba na traci ili napolju, poboljšava izdržljivost", Tip = "Kardio", MisicnaGrupa = "Cijelo tijelo" });

            UcitajListu();

            cmbTip.Items.Clear();
            cmbTip.Items.Add("Snaga");
            cmbTip.Items.Add("Kardio");
            cmbTip.Items.Add("Mobilnost");
            cmbTip.Items.Add("Izdržljivost");
            cmbTip.SelectedIndex = 0;

            cmbGrupa.Items.Clear();
            cmbGrupa.Items.Add("Prsa");
            cmbGrupa.Items.Add("Leđa");
            cmbGrupa.Items.Add("Noge");
            cmbGrupa.Items.Add("Ruke");
            cmbGrupa.Items.Add("Ramena");
            cmbGrupa.Items.Add("Cijelo tijelo");
            cmbGrupa.SelectedIndex = 0;

            cmbFilterTip.Items.AddRange(new string[] { "Svi", "Snaga", "Kardio", "Mobilnost", "Izdržljivost" });
            cmbFilterTip.SelectedIndex = 0;
            cmbFilterGrupa.Items.AddRange(new string[] { "Sve", "Prsa", "Leđa", "Noge", "Ruke", "Ramena", "Cijelo tijelo" });
            cmbFilterGrupa.SelectedIndex = 0;

            cmbFilterTip.SelectedIndexChanged += cmbFilterTip_SelectedIndexChanged;
            cmbFilterGrupa.SelectedIndexChanged += cmbFilterGrupa_SelectedIndexChanged;
            dgvVjezbe.ColumnHeaderMouseClick += dgvVjezbe_ColumnHeaderMouseClick;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVjezbe.CurrentRow.Cells["VjezbaID"].Value);
                var v = listaVjezb.FirstOrDefault(x => x.VjezbaID == id);
                if (v != null)
                {
                    v.Naziv = txtNaziv.Text;
                    v.Opis = txtOpis.Text;
                    v.Tip = cmbTip.SelectedItem.ToString();
                    v.MisicnaGrupa = cmbGrupa.SelectedItem.ToString();

                    MessageBox.Show("Ažurirano!");

                    UcitajListu();
                }
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null &&
            MessageBox.Show("Sigurno obrisati?", "Potvrda", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)dgvVjezbe.CurrentRow.Cells["VjezbaID"].Value;
                listaVjezb.RemoveAll(x => x.VjezbaID == id);
                MessageBox.Show("Obrisano!");
                OcistiPolja();
                UcitajListu();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            OcistiPolja();
        }

        private void btnUcitajSve_Click(object sender, EventArgs e)
        {
            UcitajListu();
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void txtTip_TextChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtMisicnaGrupa_TextChanged(object sender, EventArgs e) { }
        private void txtNaziv_TextChanged(object sender, EventArgs e) { }
        private void dgvVjezbe_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void UrediGrid()
        {
            dgvVjezbe.BorderStyle = BorderStyle.None;
            dgvVjezbe.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvVjezbe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvVjezbe.GridColor = Color.LightGray;

            dgvVjezbe.RowHeadersVisible = false;
            dgvVjezbe.EnableHeadersVisualStyles = false;
            dgvVjezbe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvVjezbe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVjezbe.AllowUserToAddRows = false;
            dgvVjezbe.ReadOnly = false;

            dgvVjezbe.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);

            dgvVjezbe.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVjezbe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
            dgvVjezbe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVjezbe.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVjezbe.ColumnHeadersHeight = 40;

            dgvVjezbe.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dgvVjezbe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvVjezbe.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvVjezbe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvVjezbe.RowTemplate.Height = 35;

            dgvVjezbe.RowPrePaint += dgvVjezbe_RowPrePaint;
            dgvVjezbe.CellMouseEnter += dgvVjezbe_CellMouseEnter;
            dgvVjezbe.CellMouseLeave += dgvVjezbe_CellMouseLeave;

            Click += FrmVjezbe_Click;
            dgvVjezbe.Click += dgvVjezbe_Click;
        }

        private void dgvVjezbe_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            hoveredRow = e.RowIndex;
            dgvVjezbe.Refresh();
        }

        private void dgvVjezbe_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            hoveredRow = -1;
            dgvVjezbe.Refresh();
        }

        private void dgvVjezbe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Color baseColor;

            if (darkMode)
                baseColor = (e.RowIndex % 2 == 0) ? Color.FromArgb(45, 45, 45) : Color.FromArgb(55, 55, 55);
            else
                baseColor = (e.RowIndex % 2 == 0) ? Color.White : Color.FromArgb(240, 240, 240);

            if (e.RowIndex == hoveredRow)
                baseColor = darkMode ? Color.FromArgb(70, 70, 70) : Color.FromArgb(220, 235, 255);

            dgvVjezbe.Rows[e.RowIndex].DefaultCellStyle.BackColor = baseColor;
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            darkMode = !darkMode;

            if (darkMode)
            {
                BackColor = Color.FromArgb(30, 30, 30);
                dgvVjezbe.BackgroundColor = Color.FromArgb(40, 40, 40);
                dgvVjezbe.DefaultCellStyle.ForeColor = Color.White;
                dgvVjezbe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
                dgvVjezbe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvVjezbe.GridColor = Color.FromArgb(70, 70, 70);

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;

                btnTheme.Text = "Light Mode";
                btnTheme.BackColor = Color.FromArgb(0, 122, 204);
                btnTheme.ForeColor = Color.White;
            }
            else
            {
                BackColor = Color.FromArgb(245, 247, 250);
                dgvVjezbe.BackgroundColor = Color.White;
                dgvVjezbe.DefaultCellStyle.ForeColor = Color.Black;
                dgvVjezbe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 144, 255);
                dgvVjezbe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvVjezbe.GridColor = Color.LightGray;

                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;

                btnTheme.Text = "Dark Mode";
                btnTheme.BackColor = SystemColors.Control;
                btnTheme.ForeColor = Color.Black;
            }

            dgvVjezbe.Refresh();
        }

        private void FrmVjezbe_Click(object sender, EventArgs e) { }
        private void dgvVjezbe_Click(object sender, EventArgs e) { }

        private void dgvVjezbe_MouseUp(object sender, MouseEventArgs e)
        {
            var hit = dgvVjezbe.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvVjezbe.ClearSelection();
                dgvVjezbe.CurrentCell = null;
                OcistiPolja();
                dgvVjezbe.Refresh();
            }
        }

        private void PrimijeniFilterISort()
        {
            var podaci = listaVjezb.AsQueryable();

            if (!string.IsNullOrEmpty(filterTip))
                podaci = podaci.Where(v => v.Tip == filterTip);
            if (!string.IsNullOrEmpty(filterGrupa))
                podaci = podaci.Where(v => v.MisicnaGrupa == filterGrupa);

            if (trenutniSortKolona == "Tip")
                podaci = sortAsc ? podaci.OrderBy(v => v.Tip) : podaci.OrderByDescending(v => v.Tip);
            else if (trenutniSortKolona == "MisicnaGrupa")
                podaci = sortAsc ? podaci.OrderBy(v => v.MisicnaGrupa) : podaci.OrderByDescending(v => v.MisicnaGrupa);

            listaVjezb = podaci.ToList();
            UcitajListu();
        }

        private void cmbFilterTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterTip = cmbFilterTip.SelectedItem.ToString();
            if (filterTip == "Svi") filterTip = "";
            PrimijeniFilterISort();
        }

        private void cmbFilterGrupa_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterGrupa = cmbFilterGrupa.SelectedItem.ToString();
            if (filterGrupa == "Sve") filterGrupa = "";
            PrimijeniFilterISort();
        }

        private void dgvVjezbe_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string kolona = dgvVjezbe.Columns[e.ColumnIndex].Name;
            if (kolona != "Tip" && kolona != "MisicnaGrupa") return;

            if (trenutniSortKolona == kolona)
                sortAsc = !sortAsc;
            else
            {
                sortAsc = true;
                trenutniSortKolona = kolona;
            }

            PrimijeniFilterISort();
        }

        private void dgvVjezbe_DoubleClick(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVjezbe.CurrentRow.Cells["VjezbaID"].Value);
                OdabranaVjezba = listaVjezb.FirstOrDefault(x => x.VjezbaID == id);

                if (OdabranaVjezba != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        public class Vjezba
        {
            public int VjezbaID { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
            public string Tip { get; set; }
            public string MisicnaGrupa { get; set; }

            public int PlaniraniSetovi { get; set; }
            public int UradjeniSetovi { get; set; }
            public bool Uradjeno { get; set; }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvVjezbe.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvVjezbe.CurrentRow.Cells["VjezbaID"].Value);
                OdabranaVjezba = listaVjezb.FirstOrDefault(x => x.VjezbaID == id);

                if (OdabranaVjezba != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Vježba nije pronađena!");
            }
            else
                MessageBox.Show("Odaberi vježbu iz liste!");
        }
    }
}
