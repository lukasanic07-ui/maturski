namespace WindowsFormsApplication1
{
    partial class FrmNaslovna
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlOverview = new System.Windows.Forms.Panel();
            this.btnEvidencija = new System.Windows.Forms.Button();
            this.btnPlanovi = new System.Windows.Forms.Button();
            this.btnVjezbe = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblFit = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlRecap = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlToday = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlRecap.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlSidebar.Controls.Add(this.panel2);
            this.pnlSidebar.Controls.Add(this.panel1);
            this.pnlSidebar.Controls.Add(this.pnlOverview);
            this.pnlSidebar.Controls.Add(this.btnEvidencija);
            this.pnlSidebar.Controls.Add(this.btnPlanovi);
            this.pnlSidebar.Controls.Add(this.btnVjezbe);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.lblFit);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(109, 661);
            this.pnlSidebar.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(109, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(109, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // pnlOverview
            // 
            this.pnlOverview.Location = new System.Drawing.Point(109, 99);
            this.pnlOverview.Name = "pnlOverview";
            this.pnlOverview.Size = new System.Drawing.Size(391, 562);
            this.pnlOverview.TabIndex = 2;
            // 
            // btnEvidencija
            // 
            this.btnEvidencija.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnEvidencija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvidencija.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEvidencija.Location = new System.Drawing.Point(3, 513);
            this.btnEvidencija.Name = "btnEvidencija";
            this.btnEvidencija.Size = new System.Drawing.Size(95, 63);
            this.btnEvidencija.TabIndex = 4;
            this.btnEvidencija.Text = "Evidencija";
            this.btnEvidencija.UseVisualStyleBackColor = false;
            // 
            // btnPlanovi
            // 
            this.btnPlanovi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnPlanovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlanovi.Location = new System.Drawing.Point(3, 372);
            this.btnPlanovi.Name = "btnPlanovi";
            this.btnPlanovi.Size = new System.Drawing.Size(95, 63);
            this.btnPlanovi.TabIndex = 3;
            this.btnPlanovi.Text = "Planovi";
            this.btnPlanovi.UseVisualStyleBackColor = false;
            this.btnPlanovi.Click += new System.EventHandler(this.btnPlanovi_Click);
            // 
            // btnVjezbe
            // 
            this.btnVjezbe.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVjezbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVjezbe.Location = new System.Drawing.Point(3, 244);
            this.btnVjezbe.Name = "btnVjezbe";
            this.btnVjezbe.Size = new System.Drawing.Size(95, 63);
            this.btnVjezbe.TabIndex = 2;
            this.btnVjezbe.Text = "Vjezbe";
            this.btnVjezbe.UseVisualStyleBackColor = false;
            this.btnVjezbe.Click += new System.EventHandler(this.btnVjezbe_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(3, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 63);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Korisnik";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblFit
            // 
            this.lblFit.AutoSize = true;
            this.lblFit.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFit.Location = new System.Drawing.Point(3, 9);
            this.lblFit.Name = "lblFit";
            this.lblFit.Size = new System.Drawing.Size(95, 85);
            this.lblFit.TabIndex = 1;
            this.lblFit.Text = "Fit";
            this.lblFit.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(109, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(964, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naslov Za aplikaciju cu ovdje stavit";
            // 
            // pnlRecap
            // 
            this.pnlRecap.BackColor = System.Drawing.Color.Ivory;
            this.pnlRecap.Controls.Add(this.panel3);
            this.pnlRecap.Controls.Add(this.label3);
            this.pnlRecap.Location = new System.Drawing.Point(109, 99);
            this.pnlRecap.Name = "pnlRecap";
            this.pnlRecap.Size = new System.Drawing.Size(500, 562);
            this.pnlRecap.TabIndex = 2;
            this.pnlRecap.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Beige;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(498, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(466, 562);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pregled posljednjeg treninga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Pregled posljednjeg treninga";
            // 
            // pnlToday
            // 
            this.pnlToday.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlToday.Controls.Add(this.label5);
            this.pnlToday.Location = new System.Drawing.Point(610, 99);
            this.pnlToday.Name = "pnlToday";
            this.pnlToday.Size = new System.Drawing.Size(463, 562);
            this.pnlToday.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zapocni Dnasasnji Trening";
            // 
            // FrmNaslovna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 661);
            this.Controls.Add(this.pnlToday);
            this.Controls.Add(this.pnlRecap);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FrmNaslovna";
            this.Text = "FrmNaslovna";
            this.Load += new System.EventHandler(this.FrmNaslovna_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlRecap.ResumeLayout(false);
            this.pnlRecap.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlToday.ResumeLayout(false);
            this.pnlToday.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblFit;
        private System.Windows.Forms.Button btnEvidencija;
        private System.Windows.Forms.Button btnPlanovi;
        private System.Windows.Forms.Button btnVjezbe;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlOverview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRecap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label label5;
    }
}