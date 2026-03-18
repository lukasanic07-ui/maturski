namespace WindowsFormsApplication1
{
    partial class FrmDashboard
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
            this.btnVjezbe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVjezbe
            // 
            this.btnVjezbe.Location = new System.Drawing.Point(24, 194);
            this.btnVjezbe.Name = "btnVjezbe";
            this.btnVjezbe.Size = new System.Drawing.Size(75, 23);
            this.btnVjezbe.TabIndex = 0;
            this.btnVjezbe.Text = "button1";
            this.btnVjezbe.UseVisualStyleBackColor = true;
            this.btnVjezbe.Click += new System.EventHandler(this.btnVjezbe_Click);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVjezbe);
            this.Name = "FrmDashboard";
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVjezbe;
    }
}