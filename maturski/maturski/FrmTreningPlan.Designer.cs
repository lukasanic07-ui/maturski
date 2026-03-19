namespace WindowsFormsApplication1
{
    partial class FrmTreningPlan
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
            this.lstbDani = new System.Windows.Forms.ListBox();
            this.dgvVjezbeZaDan = new System.Windows.Forms.DataGridView();
            this.btnDodajVjezbu = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtNazivPlana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpremiPlan = new System.Windows.Forms.Button();
            this.lblNapredak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbeZaDan)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbDani
            // 
            this.lstbDani.FormattingEnabled = true;
            this.lstbDani.Location = new System.Drawing.Point(-4, 51);
            this.lstbDani.Name = "lstbDani";
            this.lstbDani.Size = new System.Drawing.Size(150, 199);
            this.lstbDani.TabIndex = 0;
            this.lstbDani.SelectedIndexChanged += new System.EventHandler(this.lstbDani_SelectedIndexChanged);
            // 
            // dgvVjezbeZaDan
            // 
            this.dgvVjezbeZaDan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvVjezbeZaDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVjezbeZaDan.Location = new System.Drawing.Point(145, 51);
            this.dgvVjezbeZaDan.Name = "dgvVjezbeZaDan";
            this.dgvVjezbeZaDan.Size = new System.Drawing.Size(573, 220);
            this.dgvVjezbeZaDan.TabIndex = 1;
            this.dgvVjezbeZaDan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVjezbeZaDan_CellContentClick);
            // 
            // btnDodajVjezbu
            // 
            this.btnDodajVjezbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajVjezbu.Location = new System.Drawing.Point(242, 331);
            this.btnDodajVjezbu.Name = "btnDodajVjezbu";
            this.btnDodajVjezbu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajVjezbu.TabIndex = 2;
            this.btnDodajVjezbu.Text = "Dodaj";
            this.btnDodajVjezbu.UseVisualStyleBackColor = true;
            this.btnDodajVjezbu.Click += new System.EventHandler(this.btnDodajVjezbu_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Location = new System.Drawing.Point(341, 331);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 3;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Location = new System.Drawing.Point(439, 331);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtNazivPlana
            // 
            this.txtNazivPlana.Location = new System.Drawing.Point(254, 28);
            this.txtNazivPlana.Name = "txtNazivPlana";
            this.txtNazivPlana.Size = new System.Drawing.Size(100, 20);
            this.txtNazivPlana.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv:";
            // 
            // btnSpremiPlan
            // 
            this.btnSpremiPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiPlan.Location = new System.Drawing.Point(370, 26);
            this.btnSpremiPlan.Name = "btnSpremiPlan";
            this.btnSpremiPlan.Size = new System.Drawing.Size(75, 23);
            this.btnSpremiPlan.TabIndex = 7;
            this.btnSpremiPlan.Text = "Spremi";
            this.btnSpremiPlan.UseVisualStyleBackColor = true;
            this.btnSpremiPlan.Click += new System.EventHandler(this.btnSpremiPlan_Click);
            // 
            // lblNapredak
            // 
            this.lblNapredak.AutoSize = true;
            this.lblNapredak.Location = new System.Drawing.Point(283, 383);
            this.lblNapredak.Name = "lblNapredak";
            this.lblNapredak.Size = new System.Drawing.Size(35, 13);
            this.lblNapredak.TabIndex = 8;
            this.lblNapredak.Text = "label2";
            // 
            // FrmTreningPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 418);
            this.Controls.Add(this.lblNapredak);
            this.Controls.Add(this.btnSpremiPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNazivPlana);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodajVjezbu);
            this.Controls.Add(this.dgvVjezbeZaDan);
            this.Controls.Add(this.lstbDani);
            this.Name = "FrmTreningPlan";
            this.Text = "FrmTreningPlan";
            this.Load += new System.EventHandler(this.FrmTreningPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVjezbeZaDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbDani;
        private System.Windows.Forms.DataGridView dgvVjezbeZaDan;
        private System.Windows.Forms.Button btnDodajVjezbu;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtNazivPlana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpremiPlan;
        private System.Windows.Forms.Label lblNapredak;
    }
}