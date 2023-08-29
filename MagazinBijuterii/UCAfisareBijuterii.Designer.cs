namespace MagazinBijuterii
{
    partial class UCAfisareBijuterii
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
            this.PnlAfisareBijuterii = new System.Windows.Forms.Panel();
            this.LblTitluAfisareBijuterii = new System.Windows.Forms.Label();
            this.PnlListBoxBijuterii = new System.Windows.Forms.Panel();
            this.BtnStergeBijuterii = new System.Windows.Forms.Button();
            this.LsBxAfisareBijuterii = new System.Windows.Forms.ListBox();
            this.PnlAfisareBijuterii.SuspendLayout();
            this.PnlListBoxBijuterii.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlAfisareBijuterii
            // 
            this.PnlAfisareBijuterii.Controls.Add(this.LblTitluAfisareBijuterii);
            this.PnlAfisareBijuterii.Controls.Add(this.PnlListBoxBijuterii);
            this.PnlAfisareBijuterii.Location = new System.Drawing.Point(0, 0);
            this.PnlAfisareBijuterii.Name = "PnlAfisareBijuterii";
            this.PnlAfisareBijuterii.Size = new System.Drawing.Size(1000, 580);
            this.PnlAfisareBijuterii.TabIndex = 1;
            // 
            // LblTitluAfisareBijuterii
            // 
            this.LblTitluAfisareBijuterii.AutoSize = true;
            this.LblTitluAfisareBijuterii.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluAfisareBijuterii.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitluAfisareBijuterii.Location = new System.Drawing.Point(270, 75);
            this.LblTitluAfisareBijuterii.Name = "LblTitluAfisareBijuterii";
            this.LblTitluAfisareBijuterii.Size = new System.Drawing.Size(251, 38);
            this.LblTitluAfisareBijuterii.TabIndex = 21;
            this.LblTitluAfisareBijuterii.Text = "Afisare Bijuterii";
            // 
            // PnlListBoxBijuterii
            // 
            this.PnlListBoxBijuterii.BackColor = System.Drawing.Color.White;
            this.PnlListBoxBijuterii.Controls.Add(this.BtnStergeBijuterii);
            this.PnlListBoxBijuterii.Controls.Add(this.LsBxAfisareBijuterii);
            this.PnlListBoxBijuterii.Location = new System.Drawing.Point(0, 150);
            this.PnlListBoxBijuterii.Name = "PnlListBoxBijuterii";
            this.PnlListBoxBijuterii.Size = new System.Drawing.Size(1000, 400);
            this.PnlListBoxBijuterii.TabIndex = 24;
            // 
            // BtnStergeBijuterii
            // 
            this.BtnStergeBijuterii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnStergeBijuterii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnStergeBijuterii.FlatAppearance.BorderSize = 0;
            this.BtnStergeBijuterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStergeBijuterii.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStergeBijuterii.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStergeBijuterii.Location = new System.Drawing.Point(450, 350);
            this.BtnStergeBijuterii.Name = "BtnStergeBijuterii";
            this.BtnStergeBijuterii.Size = new System.Drawing.Size(125, 40);
            this.BtnStergeBijuterii.TabIndex = 23;
            this.BtnStergeBijuterii.Text = "Sterge";
            this.BtnStergeBijuterii.UseVisualStyleBackColor = false;
            this.BtnStergeBijuterii.Click += new System.EventHandler(this.BtnStergeBijuterii_Click);
            // 
            // LsBxAfisareBijuterii
            // 
            this.LsBxAfisareBijuterii.BackColor = System.Drawing.Color.White;
            this.LsBxAfisareBijuterii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LsBxAfisareBijuterii.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LsBxAfisareBijuterii.ForeColor = System.Drawing.Color.Black;
            this.LsBxAfisareBijuterii.FormattingEnabled = true;
            this.LsBxAfisareBijuterii.ItemHeight = 20;
            this.LsBxAfisareBijuterii.Location = new System.Drawing.Point(0, 4);
            this.LsBxAfisareBijuterii.Margin = new System.Windows.Forms.Padding(4);
            this.LsBxAfisareBijuterii.Name = "LsBxAfisareBijuterii";
            this.LsBxAfisareBijuterii.Size = new System.Drawing.Size(1000, 400);
            this.LsBxAfisareBijuterii.TabIndex = 22;
            this.LsBxAfisareBijuterii.SelectedIndexChanged += new System.EventHandler(this.LsBxAfisareBijuterii_SelectedIndexChanged);
            this.LsBxAfisareBijuterii.VisibleChanged += new System.EventHandler(this.PnlAfisareBijuterii_VisibleChanged);
            // 
            // UCAfisareBijuterii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.Controls.Add(this.PnlAfisareBijuterii);
            this.Name = "UCAfisareBijuterii";
            this.Size = new System.Drawing.Size(1000, 580);
            this.Load += new System.EventHandler(this.UCAfisareBijuterii_Load);
            this.PnlAfisareBijuterii.ResumeLayout(false);
            this.PnlAfisareBijuterii.PerformLayout();
            this.PnlListBoxBijuterii.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlAfisareBijuterii;
        private System.Windows.Forms.Label LblTitluAfisareBijuterii;
        private System.Windows.Forms.Panel PnlListBoxBijuterii;
        private System.Windows.Forms.Button BtnStergeBijuterii;
        private System.Windows.Forms.ListBox LsBxAfisareBijuterii;
    }
}
