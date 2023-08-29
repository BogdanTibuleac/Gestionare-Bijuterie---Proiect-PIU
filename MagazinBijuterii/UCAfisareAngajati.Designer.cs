namespace MagazinBijuterii
{
    partial class UCAfisareAngajati
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlAfisareAngajati = new System.Windows.Forms.Panel();
            this.PnlListBox = new System.Windows.Forms.Panel();
            this.BtnStergeAngajat = new System.Windows.Forms.Button();
            this.LsBxAfisareAngajati = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareAngajati = new System.Windows.Forms.Label();
            this.PnlAfisareAngajati.SuspendLayout();
            this.PnlListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareAngajati
            // 
            this.PnlAfisareAngajati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.PnlAfisareAngajati.Controls.Add(this.PnlListBox);
            this.PnlAfisareAngajati.Controls.Add(this.LblTitluAfisareAngajati);
            this.PnlAfisareAngajati.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareAngajati.Name = "PnlAfisareAngajati";
            this.PnlAfisareAngajati.Size = new System.Drawing.Size(1000, 580);
            this.PnlAfisareAngajati.TabIndex = 1;
            this.PnlAfisareAngajati.VisibleChanged += new System.EventHandler(this.PnlAfisareAngajati_VisibleChanged);
            // 
            // PnlListBox
            // 
            this.PnlListBox.BackColor = System.Drawing.Color.White;
            this.PnlListBox.Controls.Add(this.BtnStergeAngajat);
            this.PnlListBox.Controls.Add(this.LsBxAfisareAngajati);
            this.PnlListBox.Location = new System.Drawing.Point(0, 150);
            this.PnlListBox.Name = "PnlListBox";
            this.PnlListBox.Size = new System.Drawing.Size(1000, 400);
            this.PnlListBox.TabIndex = 4;
            // 
            // BtnStergeAngajat
            // 
            this.BtnStergeAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnStergeAngajat.FlatAppearance.BorderSize = 0;
            this.BtnStergeAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeAngajat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStergeAngajat.ForeColor = System.Drawing.Color.White;
            this.BtnStergeAngajat.Location = new System.Drawing.Point(450, 350);
            this.BtnStergeAngajat.Name = "BtnStergeAngajat";
            this.BtnStergeAngajat.Size = new System.Drawing.Size(125, 40);
            this.BtnStergeAngajat.TabIndex = 1;
            this.BtnStergeAngajat.Text = "Sterge";
            this.BtnStergeAngajat.UseVisualStyleBackColor = false;
            this.BtnStergeAngajat.Click += new System.EventHandler(this.BtnStergeAngajat_Click);
            // 
            // LsBxAfisareAngajati
            // 
            this.LsBxAfisareAngajati.BackColor = System.Drawing.Color.White;
            this.LsBxAfisareAngajati.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareAngajati.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareAngajati.ForeColor = System.Drawing.Color.Black;
            this.LsBxAfisareAngajati.FormattingEnabled = true;
            this.LsBxAfisareAngajati.ItemHeight = 20;
            this.LsBxAfisareAngajati.Location = new System.Drawing.Point(0, 0);
            this.LsBxAfisareAngajati.Name = "LsBxAfisareAngajati";
            this.LsBxAfisareAngajati.Size = new System.Drawing.Size(1000, 400);
            this.LsBxAfisareAngajati.TabIndex = 0;
            this.LsBxAfisareAngajati.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareAngajati_SelectedIndexChanged);
            // 
            // LblTitluAfisareAngajati
            // 
            this.LblTitluAfisareAngajati.AutoSize = true;
            this.LblTitluAfisareAngajati.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareAngajati.ForeColor = System.Drawing.Color.White;
            this.LblTitluAfisareAngajati.Location = new System.Drawing.Point(270, 75);
            this.LblTitluAfisareAngajati.Name = "LblTitluAfisareAngajati";
            this.LblTitluAfisareAngajati.Size = new System.Drawing.Size(273, 39);
            this.LblTitluAfisareAngajati.TabIndex = 3;
            this.LblTitluAfisareAngajati.Text = "Afisare Angajati";
            // 
            // UCAfisareAngajati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.PnlAfisareAngajati);
            this.Name = "UCAfisareAngajati";
            this.Size = new System.Drawing.Size(1000, 580);
            this.Load += new System.EventHandler(this.UCAfisareAngajati_Load);
            this.PnlAfisareAngajati.ResumeLayout(false);
            this.PnlAfisareAngajati.PerformLayout();
            this.PnlListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareAngajati;
        private System.Windows.Forms.Panel PnlListBox;
        private System.Windows.Forms.Button BtnStergeAngajat;
        private System.Windows.Forms.ListBox LsBxAfisareAngajati;
        private System.Windows.Forms.Label LblTitluAfisareAngajati;
    }
}
