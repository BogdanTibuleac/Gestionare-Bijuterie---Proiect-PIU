namespace MagazinBijuterii
{
    partial class UCAfisareClienti
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
            this.PnlAfisareClienti = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnStergeClient = new System.Windows.Forms.Button();
            this.LsBxAfisareClienti = new System.Windows.Forms.ListBox();
            this.LblTitluAfisareClienti = new System.Windows.Forms.Label();
            this.PnlAfisareClienti.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareClienti
            // 
            this.PnlAfisareClienti.Controls.Add(this.panel1);
            this.PnlAfisareClienti.Controls.Add(this.LblTitluAfisareClienti);
            this.PnlAfisareClienti.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareClienti.Name = "PnlAfisareClienti";
            this.PnlAfisareClienti.Size = new System.Drawing.Size(1000, 580);
            this.PnlAfisareClienti.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnStergeClient);
            this.panel1.Controls.Add(this.LsBxAfisareClienti);
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 400);
            this.panel1.TabIndex = 27;
            this.panel1.VisibleChanged += new System.EventHandler(this.PnlAfisareClienti_VisibleChanged);
            // 
            // BtnStergeClient
            // 
            this.BtnStergeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnStergeClient.FlatAppearance.BorderSize = 0;
            this.BtnStergeClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeClient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnStergeClient.ForeColor = System.Drawing.Color.White;
            this.BtnStergeClient.Location = new System.Drawing.Point(450, 350);
            this.BtnStergeClient.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStergeClient.Name = "BtnStergeClient";
            this.BtnStergeClient.Size = new System.Drawing.Size(125, 40);
            this.BtnStergeClient.TabIndex = 27;
            this.BtnStergeClient.Text = "Sterge";
            this.BtnStergeClient.UseVisualStyleBackColor = false;
            this.BtnStergeClient.Click += new System.EventHandler(this.BtnStergeClient_Click);
            // 
            // LsBxAfisareClienti
            // 
            this.LsBxAfisareClienti.BackColor = System.Drawing.Color.White;
            this.LsBxAfisareClienti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareClienti.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareClienti.ForeColor = System.Drawing.Color.Black;
            this.LsBxAfisareClienti.FormattingEnabled = true;
            this.LsBxAfisareClienti.ItemHeight = 20;
            this.LsBxAfisareClienti.Location = new System.Drawing.Point(0, 0);
            this.LsBxAfisareClienti.Margin = new System.Windows.Forms.Padding(4);
            this.LsBxAfisareClienti.Name = "LsBxAfisareClienti";
            this.LsBxAfisareClienti.Size = new System.Drawing.Size(1000, 400);
            this.LsBxAfisareClienti.TabIndex = 25;
            this.LsBxAfisareClienti.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareClienti_SelectedIndexChanged);
            // 
            // LblTitluAfisareClienti
            // 
            this.LblTitluAfisareClienti.AutoSize = true;
            this.LblTitluAfisareClienti.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareClienti.ForeColor = System.Drawing.Color.White;
            this.LblTitluAfisareClienti.Location = new System.Drawing.Point(270, 75);
            this.LblTitluAfisareClienti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitluAfisareClienti.Name = "LblTitluAfisareClienti";
            this.LblTitluAfisareClienti.Size = new System.Drawing.Size(243, 40);
            this.LblTitluAfisareClienti.TabIndex = 26;
            this.LblTitluAfisareClienti.Text = "Afisare Clienti";
            // 
            // UCAfisareClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.PnlAfisareClienti);
            this.Name = "UCAfisareClienti";
            this.Size = new System.Drawing.Size(1000, 580);
            this.Load += new System.EventHandler(this.UCAfisareClienti_Load);
            this.PnlAfisareClienti.ResumeLayout(false);
            this.PnlAfisareClienti.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareClienti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnStergeClient;
        private System.Windows.Forms.ListBox LsBxAfisareClienti;
        private System.Windows.Forms.Label LblTitluAfisareClienti;
    }
}
