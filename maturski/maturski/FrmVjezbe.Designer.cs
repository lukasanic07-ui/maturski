namespace WindowsFormsApplication1
{
    partial class FrmVjezbe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVjezbe = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnUcitajSve = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.F = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilterTip = new System.Windows.Forms.ComboBox();
            this.cmbFilterGrupa = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVjezbe
            // 
            this.dgvVjezbe.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvVjezbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVjezbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVjezbe.Location = new System.Drawing.Point(0, 0);
            this.dgvVjezbe.Name = "dgvVjezbe";
            this.dgvVjezbe.Size = new System.Drawing.Size(1027, 631);
            this.dgvVjezbe.TabIndex = 0;
            this.dgvVjezbe.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVjezbe_CellMouseLeave);
            this.dgvVjezbe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVjezbe_ColumnHeaderMouseClick);
            this.dgvVjezbe.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvVjezbe_RowPrePaint);
            this.dgvVjezbe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvVjezbe_MouseUp);
            this.dgvVjezbe.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVjezbe_CellMouseEnter);
            this.dgvVjezbe.SelectionChanged += new System.EventHandler(this.dgvVjezbe_SelectionChanged);
            this.dgvVjezbe.Click += new System.EventHandler(this.dgvVjezbe_Click);
            this.dgvVjezbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVjezbe_CellContentClick);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(845, 24);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(91, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(810, 75);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(171, 73);
            this.txtOpis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tip";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(752, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(730, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Misicna Grupa";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(733, 264);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(66, 31);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(824, 264);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(66, 31);
            this.btnAzuriraj.TabIndex = 3;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(915, 264);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(66, 31);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(733, 304);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(117, 31);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Ocisti";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnUcitajSve
            // 
            this.btnUcitajSve.Location = new System.Drawing.Point(865, 304);
            this.btnUcitajSve.Name = "btnUcitajSve";
            this.btnUcitajSve.Size = new System.Drawing.Size(117, 31);
            this.btnUcitajSve.TabIndex = 6;
            this.btnUcitajSve.Text = "UcitajNovu";
            this.btnUcitajSve.UseVisualStyleBackColor = true;
            this.btnUcitajSve.Click += new System.EventHandler(this.btnUcitajSve_Click);
            // 
            // btnTheme
            // 
            this.btnTheme.Location = new System.Drawing.Point(942, 0);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(85, 33);
            this.btnTheme.TabIndex = 7;
            this.btnTheme.Text = "Dark Mode";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(845, 177);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(121, 21);
            this.cmbTip.TabIndex = 8;
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(845, 218);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupa.TabIndex = 9;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(821, 347);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(72, 18);
            this.F.TabIndex = 10;
            this.F.Text = "Filtriraj po";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(912, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grupi";
            // 
            // cmbFilterTip
            // 
            this.cmbFilterTip.FormattingEnabled = true;
            this.cmbFilterTip.Location = new System.Drawing.Point(729, 421);
            this.cmbFilterTip.Name = "cmbFilterTip";
            this.cmbFilterTip.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterTip.TabIndex = 13;
            this.cmbFilterTip.SelectedIndexChanged += new System.EventHandler(this.cmbFilterTip_SelectedIndexChanged);
            // 
            // cmbFilterGrupa
            // 
            this.cmbFilterGrupa.FormattingEnabled = true;
            this.cmbFilterGrupa.Location = new System.Drawing.Point(865, 421);
            this.cmbFilterGrupa.Name = "cmbFilterGrupa";
            this.cmbFilterGrupa.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterGrupa.TabIndex = 14;
            this.cmbFilterGrupa.SelectedIndexChanged += new System.EventHandler(this.cmbFilterGrupa_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(824, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmVjezbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 631);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFilterGrupa);
            this.Controls.Add(this.cmbFilterTip);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.btnTheme);
            this.Controls.Add(this.btnUcitajSve);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.dgvVjezbe);
            this.Name = "FrmVjezbe";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmVjezbe_Load);
            this.Click += new System.EventHandler(this.FrmVjezbe_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVjezbe;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnUcitajSve;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilterTip;
        private System.Windows.Forms.ComboBox cmbFilterGrupa;
        private System.Windows.Forms.Button button1;
    }
}