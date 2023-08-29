namespace MagazinBijuterii
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Navbar = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblTitlu = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BtnSetari = new System.Windows.Forms.Button();
            this.BtnClienti = new System.Windows.Forms.Button();
            this.BtnAngajati = new System.Windows.Forms.Button();
            this.BtnBijuterii = new System.Windows.Forms.Button();
            this.BtnAcasa = new System.Windows.Forms.Button();
            this.PanelAcasa = new System.Windows.Forms.Panel();
            this.LblDescriere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBijuterii = new System.Windows.Forms.Panel();
            this.ButonModificaBijuterie = new System.Windows.Forms.Button();
            this.ButonCautaBijuterie = new System.Windows.Forms.Button();
            this.ButonAfiseazaBijuterie = new System.Windows.Forms.Button();
            this.ButonAdaugaBijuterie = new System.Windows.Forms.Button();
            this.PanelAngajati = new System.Windows.Forms.Panel();
            this.ButonModificaAngajat = new System.Windows.Forms.Button();
            this.ButonCautaAngajat = new System.Windows.Forms.Button();
            this.ButonAfiseazaAngajat = new System.Windows.Forms.Button();
            this.ButonAdaugaAngajat = new System.Windows.Forms.Button();
            this.PanelClienti = new System.Windows.Forms.Panel();
            this.ButonModificaClient = new System.Windows.Forms.Button();
            this.ButonCautaClient = new System.Windows.Forms.Button();
            this.ButonAfiseazaClient = new System.Windows.Forms.Button();
            this.ButonAdaugaClient = new System.Windows.Forms.Button();
            this.PanelLogare = new System.Windows.Forms.Panel();
            this.TxtBxParola = new System.Windows.Forms.TextBox();
            this.LblParola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MesajParola = new System.Windows.Forms.Label();
            this.PanelSetari = new System.Windows.Forms.Panel();
            this.LblParolaActuala = new System.Windows.Forms.Label();
            this.LblNouaParola = new System.Windows.Forms.Label();
            this.TxtParolaActuala = new System.Windows.Forms.TextBox();
            this.TxtParolaNoua = new System.Windows.Forms.TextBox();
            this.LblSetari = new System.Windows.Forms.Label();
            this.LblModificareParolaAvertisment = new System.Windows.Forms.Label();
            this.BtnModificaParola = new System.Windows.Forms.Button();
            this.Navbar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelAcasa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelBijuterii.SuspendLayout();
            this.PanelAngajati.SuspendLayout();
            this.PanelClienti.SuspendLayout();
            this.PanelLogare.SuspendLayout();
            this.PanelSetari.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.Navbar.Controls.Add(this.BtnExit);
            this.Navbar.Controls.Add(this.LblTitlu);
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1275, 70);
            this.Navbar.TabIndex = 0;
            this.Navbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseDown);
            this.Navbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseMove);
            this.Navbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Navbar_MouseUp);
            // 
            // BtnExit
            // 
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::MagazinBijuterii.Properties.Resources.exit30;
            this.BtnExit.Location = new System.Drawing.Point(1185, 18);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(40, 40);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblTitlu
            // 
            this.LblTitlu.AutoSize = true;
            this.LblTitlu.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitlu.ForeColor = System.Drawing.Color.White;
            this.LblTitlu.Location = new System.Drawing.Point(38, 18);
            this.LblTitlu.Name = "LblTitlu";
            this.LblTitlu.Size = new System.Drawing.Size(163, 52);
            this.LblTitlu.TabIndex = 3;
            this.LblTitlu.Text = "Jewels";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.MainPanel.Controls.Add(this.BtnSetari);
            this.MainPanel.Controls.Add(this.BtnClienti);
            this.MainPanel.Controls.Add(this.BtnAngajati);
            this.MainPanel.Controls.Add(this.BtnBijuterii);
            this.MainPanel.Controls.Add(this.BtnAcasa);
            this.MainPanel.Location = new System.Drawing.Point(0, 70);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(250, 630);
            this.MainPanel.TabIndex = 1;
            // 
            // BtnSetari
            // 
            this.BtnSetari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetari.FlatAppearance.BorderSize = 0;
            this.BtnSetari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetari.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetari.ForeColor = System.Drawing.Color.White;
            this.BtnSetari.Image = global::MagazinBijuterii.Properties.Resources.icon_settings;
            this.BtnSetari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSetari.Location = new System.Drawing.Point(20, 450);
            this.BtnSetari.Name = "BtnSetari";
            this.BtnSetari.Size = new System.Drawing.Size(230, 50);
            this.BtnSetari.TabIndex = 6;
            this.BtnSetari.Text = "Setari";
            this.BtnSetari.UseVisualStyleBackColor = true;
            this.BtnSetari.Click += new System.EventHandler(this.BtnSetari_Click);
            // 
            // BtnClienti
            // 
            this.BtnClienti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClienti.FlatAppearance.BorderSize = 0;
            this.BtnClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClienti.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienti.ForeColor = System.Drawing.Color.White;
            this.BtnClienti.Image = global::MagazinBijuterii.Properties.Resources.icon_employee_40px;
            this.BtnClienti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClienti.Location = new System.Drawing.Point(20, 370);
            this.BtnClienti.Name = "BtnClienti";
            this.BtnClienti.Size = new System.Drawing.Size(230, 50);
            this.BtnClienti.TabIndex = 5;
            this.BtnClienti.Text = "Clienti";
            this.BtnClienti.UseVisualStyleBackColor = true;
            this.BtnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
            // 
            // BtnAngajati
            // 
            this.BtnAngajati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAngajati.FlatAppearance.BorderSize = 0;
            this.BtnAngajati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAngajati.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAngajati.ForeColor = System.Drawing.Color.White;
            this.BtnAngajati.Image = global::MagazinBijuterii.Properties.Resources.icon_manager_40px;
            this.BtnAngajati.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAngajati.Location = new System.Drawing.Point(20, 290);
            this.BtnAngajati.Name = "BtnAngajati";
            this.BtnAngajati.Size = new System.Drawing.Size(230, 50);
            this.BtnAngajati.TabIndex = 4;
            this.BtnAngajati.Text = "Angajati";
            this.BtnAngajati.UseVisualStyleBackColor = true;
            this.BtnAngajati.Click += new System.EventHandler(this.BtnAngajati_Click);
            // 
            // BtnBijuterii
            // 
            this.BtnBijuterii.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBijuterii.FlatAppearance.BorderSize = 0;
            this.BtnBijuterii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBijuterii.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBijuterii.ForeColor = System.Drawing.Color.White;
            this.BtnBijuterii.Image = global::MagazinBijuterii.Properties.Resources.icon_jewel_40px;
            this.BtnBijuterii.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBijuterii.Location = new System.Drawing.Point(20, 210);
            this.BtnBijuterii.Name = "BtnBijuterii";
            this.BtnBijuterii.Size = new System.Drawing.Size(230, 50);
            this.BtnBijuterii.TabIndex = 3;
            this.BtnBijuterii.Text = "Bijuterii";
            this.BtnBijuterii.UseVisualStyleBackColor = true;
            this.BtnBijuterii.Click += new System.EventHandler(this.BtnBijuterii_Click);
            // 
            // BtnAcasa
            // 
            this.BtnAcasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcasa.FlatAppearance.BorderSize = 0;
            this.BtnAcasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcasa.ForeColor = System.Drawing.Color.White;
            this.BtnAcasa.Image = global::MagazinBijuterii.Properties.Resources.icon_home_40px1;
            this.BtnAcasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcasa.Location = new System.Drawing.Point(20, 130);
            this.BtnAcasa.Name = "BtnAcasa";
            this.BtnAcasa.Size = new System.Drawing.Size(230, 50);
            this.BtnAcasa.TabIndex = 2;
            this.BtnAcasa.Text = "Acasa";
            this.BtnAcasa.UseVisualStyleBackColor = true;
            this.BtnAcasa.Click += new System.EventHandler(this.BtnAcasa_Click);
            // 
            // PanelAcasa
            // 
            this.PanelAcasa.Controls.Add(this.LblDescriere);
            this.PanelAcasa.Controls.Add(this.pictureBox1);
            this.PanelAcasa.Location = new System.Drawing.Point(250, 70);
            this.PanelAcasa.Name = "PanelAcasa";
            this.PanelAcasa.Size = new System.Drawing.Size(1000, 630);
            this.PanelAcasa.TabIndex = 2;
            // 
            // LblDescriere
            // 
            this.LblDescriere.AutoSize = true;
            this.LblDescriere.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescriere.ForeColor = System.Drawing.Color.Black;
            this.LblDescriere.Location = new System.Drawing.Point(101, 398);
            this.LblDescriere.Name = "LblDescriere";
            this.LblDescriere.Size = new System.Drawing.Size(765, 174);
            this.LblDescriere.TabIndex = 2;
            this.LblDescriere.Text = resources.GetString("LblDescriere.Text");
            this.LblDescriere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MagazinBijuterii.Properties.Resources.diamond_icon;
            this.pictureBox1.Location = new System.Drawing.Point(275, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 366);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelBijuterii
            // 
            this.PanelBijuterii.Controls.Add(this.ButonModificaBijuterie);
            this.PanelBijuterii.Controls.Add(this.ButonCautaBijuterie);
            this.PanelBijuterii.Controls.Add(this.ButonAfiseazaBijuterie);
            this.PanelBijuterii.Controls.Add(this.ButonAdaugaBijuterie);
            this.PanelBijuterii.Location = new System.Drawing.Point(250, 70);
            this.PanelBijuterii.Name = "PanelBijuterii";
            this.PanelBijuterii.Size = new System.Drawing.Size(1000, 630);
            this.PanelBijuterii.TabIndex = 0;
            // 
            // ButonModificaBijuterie
            // 
            this.ButonModificaBijuterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonModificaBijuterie.FlatAppearance.BorderSize = 0;
            this.ButonModificaBijuterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonModificaBijuterie.Image = global::MagazinBijuterii.Properties.Resources.edit_icon_40px;
            this.ButonModificaBijuterie.Location = new System.Drawing.Point(600, 40);
            this.ButonModificaBijuterie.Name = "ButonModificaBijuterie";
            this.ButonModificaBijuterie.Size = new System.Drawing.Size(55, 55);
            this.ButonModificaBijuterie.TabIndex = 3;
            this.ButonModificaBijuterie.UseVisualStyleBackColor = false;
            this.ButonModificaBijuterie.Click += new System.EventHandler(this.BtnModificareBijuterie_Click);
            // 
            // ButonCautaBijuterie
            // 
            this.ButonCautaBijuterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonCautaBijuterie.FlatAppearance.BorderSize = 0;
            this.ButonCautaBijuterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonCautaBijuterie.Image = global::MagazinBijuterii.Properties.Resources.search_icon_40px;
            this.ButonCautaBijuterie.Location = new System.Drawing.Point(490, 40);
            this.ButonCautaBijuterie.Name = "ButonCautaBijuterie";
            this.ButonCautaBijuterie.Size = new System.Drawing.Size(55, 55);
            this.ButonCautaBijuterie.TabIndex = 2;
            this.ButonCautaBijuterie.UseVisualStyleBackColor = false;
            this.ButonCautaBijuterie.Click += new System.EventHandler(this.ButonCautareBijuterie_Click);
            // 
            // ButonAfiseazaBijuterie
            // 
            this.ButonAfiseazaBijuterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAfiseazaBijuterie.FlatAppearance.BorderSize = 0;
            this.ButonAfiseazaBijuterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAfiseazaBijuterie.Image = global::MagazinBijuterii.Properties.Resources.show_icon_40px;
            this.ButonAfiseazaBijuterie.Location = new System.Drawing.Point(380, 40);
            this.ButonAfiseazaBijuterie.Name = "ButonAfiseazaBijuterie";
            this.ButonAfiseazaBijuterie.Size = new System.Drawing.Size(55, 55);
            this.ButonAfiseazaBijuterie.TabIndex = 1;
            this.ButonAfiseazaBijuterie.UseVisualStyleBackColor = false;
            this.ButonAfiseazaBijuterie.Click += new System.EventHandler(this.ButonAfisareBijuterie_Click);
            // 
            // ButonAdaugaBijuterie
            // 
            this.ButonAdaugaBijuterie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAdaugaBijuterie.FlatAppearance.BorderSize = 0;
            this.ButonAdaugaBijuterie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugaBijuterie.Image = global::MagazinBijuterii.Properties.Resources.plus_icon_40px;
            this.ButonAdaugaBijuterie.Location = new System.Drawing.Point(270, 40);
            this.ButonAdaugaBijuterie.Margin = new System.Windows.Forms.Padding(0);
            this.ButonAdaugaBijuterie.Name = "ButonAdaugaBijuterie";
            this.ButonAdaugaBijuterie.Size = new System.Drawing.Size(55, 55);
            this.ButonAdaugaBijuterie.TabIndex = 0;
            this.ButonAdaugaBijuterie.UseVisualStyleBackColor = false;
            this.ButonAdaugaBijuterie.Click += new System.EventHandler(this.ButonAdaugareBijuterie_Click);
            // 
            // PanelAngajati
            // 
            this.PanelAngajati.Controls.Add(this.ButonModificaAngajat);
            this.PanelAngajati.Controls.Add(this.ButonCautaAngajat);
            this.PanelAngajati.Controls.Add(this.ButonAfiseazaAngajat);
            this.PanelAngajati.Controls.Add(this.ButonAdaugaAngajat);
            this.PanelAngajati.Location = new System.Drawing.Point(250, 70);
            this.PanelAngajati.Name = "PanelAngajati";
            this.PanelAngajati.Size = new System.Drawing.Size(1000, 630);
            this.PanelAngajati.TabIndex = 4;
            // 
            // ButonModificaAngajat
            // 
            this.ButonModificaAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonModificaAngajat.FlatAppearance.BorderSize = 0;
            this.ButonModificaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonModificaAngajat.Image = global::MagazinBijuterii.Properties.Resources.edit_icon_40px;
            this.ButonModificaAngajat.Location = new System.Drawing.Point(600, 40);
            this.ButonModificaAngajat.Name = "ButonModificaAngajat";
            this.ButonModificaAngajat.Size = new System.Drawing.Size(55, 55);
            this.ButonModificaAngajat.TabIndex = 7;
            this.ButonModificaAngajat.UseVisualStyleBackColor = false;
            this.ButonModificaAngajat.Click += new System.EventHandler(this.BtnModificareAngajat_Click);
            // 
            // ButonCautaAngajat
            // 
            this.ButonCautaAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonCautaAngajat.FlatAppearance.BorderSize = 0;
            this.ButonCautaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonCautaAngajat.Image = global::MagazinBijuterii.Properties.Resources.search_icon_40px;
            this.ButonCautaAngajat.Location = new System.Drawing.Point(490, 40);
            this.ButonCautaAngajat.Name = "ButonCautaAngajat";
            this.ButonCautaAngajat.Size = new System.Drawing.Size(55, 55);
            this.ButonCautaAngajat.TabIndex = 6;
            this.ButonCautaAngajat.UseVisualStyleBackColor = false;
            this.ButonCautaAngajat.Click += new System.EventHandler(this.BtnCautareAngajat_Click);
            // 
            // ButonAfiseazaAngajat
            // 
            this.ButonAfiseazaAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAfiseazaAngajat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButonAfiseazaAngajat.FlatAppearance.BorderSize = 0;
            this.ButonAfiseazaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAfiseazaAngajat.Image = global::MagazinBijuterii.Properties.Resources.show_icon_40px;
            this.ButonAfiseazaAngajat.Location = new System.Drawing.Point(380, 40);
            this.ButonAfiseazaAngajat.Name = "ButonAfiseazaAngajat";
            this.ButonAfiseazaAngajat.Size = new System.Drawing.Size(55, 55);
            this.ButonAfiseazaAngajat.TabIndex = 5;
            this.ButonAfiseazaAngajat.UseVisualStyleBackColor = false;
            this.ButonAfiseazaAngajat.Click += new System.EventHandler(this.BtnAfisareAngajati_Click);
            // 
            // ButonAdaugaAngajat
            // 
            this.ButonAdaugaAngajat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAdaugaAngajat.FlatAppearance.BorderSize = 0;
            this.ButonAdaugaAngajat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugaAngajat.Image = global::MagazinBijuterii.Properties.Resources.plus_icon_40px;
            this.ButonAdaugaAngajat.Location = new System.Drawing.Point(270, 40);
            this.ButonAdaugaAngajat.Margin = new System.Windows.Forms.Padding(0);
            this.ButonAdaugaAngajat.Name = "ButonAdaugaAngajat";
            this.ButonAdaugaAngajat.Size = new System.Drawing.Size(55, 55);
            this.ButonAdaugaAngajat.TabIndex = 4;
            this.ButonAdaugaAngajat.UseVisualStyleBackColor = false;
            this.ButonAdaugaAngajat.Click += new System.EventHandler(this.BtnAdaugareAngajat_Click);
            // 
            // PanelClienti
            // 
            this.PanelClienti.Controls.Add(this.ButonModificaClient);
            this.PanelClienti.Controls.Add(this.ButonCautaClient);
            this.PanelClienti.Controls.Add(this.ButonAfiseazaClient);
            this.PanelClienti.Controls.Add(this.ButonAdaugaClient);
            this.PanelClienti.Location = new System.Drawing.Point(250, 70);
            this.PanelClienti.Name = "PanelClienti";
            this.PanelClienti.Size = new System.Drawing.Size(1000, 630);
            this.PanelClienti.TabIndex = 8;
            // 
            // ButonModificaClient
            // 
            this.ButonModificaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonModificaClient.FlatAppearance.BorderSize = 0;
            this.ButonModificaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonModificaClient.Image = global::MagazinBijuterii.Properties.Resources.edit_icon_40px;
            this.ButonModificaClient.Location = new System.Drawing.Point(600, 40);
            this.ButonModificaClient.Name = "ButonModificaClient";
            this.ButonModificaClient.Size = new System.Drawing.Size(55, 55);
            this.ButonModificaClient.TabIndex = 7;
            this.ButonModificaClient.UseVisualStyleBackColor = false;
            // 
            // ButonCautaClient
            // 
            this.ButonCautaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonCautaClient.FlatAppearance.BorderSize = 0;
            this.ButonCautaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonCautaClient.Image = global::MagazinBijuterii.Properties.Resources.search_icon_40px;
            this.ButonCautaClient.Location = new System.Drawing.Point(490, 40);
            this.ButonCautaClient.Name = "ButonCautaClient";
            this.ButonCautaClient.Size = new System.Drawing.Size(55, 55);
            this.ButonCautaClient.TabIndex = 6;
            this.ButonCautaClient.UseVisualStyleBackColor = false;
            this.ButonCautaClient.Click += new System.EventHandler(this.BtnCautareeClienti_Click);
            // 
            // ButonAfiseazaClient
            // 
            this.ButonAfiseazaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAfiseazaClient.FlatAppearance.BorderSize = 0;
            this.ButonAfiseazaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAfiseazaClient.Image = global::MagazinBijuterii.Properties.Resources.show_icon_40px;
            this.ButonAfiseazaClient.Location = new System.Drawing.Point(380, 40);
            this.ButonAfiseazaClient.Name = "ButonAfiseazaClient";
            this.ButonAfiseazaClient.Size = new System.Drawing.Size(55, 55);
            this.ButonAfiseazaClient.TabIndex = 5;
            this.ButonAfiseazaClient.UseVisualStyleBackColor = false;
            this.ButonAfiseazaClient.Click += new System.EventHandler(this.BtnAfisareClienti_Click);
            // 
            // ButonAdaugaClient
            // 
            this.ButonAdaugaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButonAdaugaClient.FlatAppearance.BorderSize = 0;
            this.ButonAdaugaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonAdaugaClient.Image = global::MagazinBijuterii.Properties.Resources.plus_icon_40px;
            this.ButonAdaugaClient.Location = new System.Drawing.Point(270, 40);
            this.ButonAdaugaClient.Margin = new System.Windows.Forms.Padding(0);
            this.ButonAdaugaClient.Name = "ButonAdaugaClient";
            this.ButonAdaugaClient.Size = new System.Drawing.Size(55, 55);
            this.ButonAdaugaClient.TabIndex = 4;
            this.ButonAdaugaClient.UseVisualStyleBackColor = false;
            this.ButonAdaugaClient.Click += new System.EventHandler(this.BtnAdaugareClient_Click);
            // 
            // PanelLogare
            // 
            this.PanelLogare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.PanelLogare.Controls.Add(this.MesajParola);
            this.PanelLogare.Controls.Add(this.label1);
            this.PanelLogare.Controls.Add(this.LblParola);
            this.PanelLogare.Controls.Add(this.TxtBxParola);
            this.PanelLogare.Location = new System.Drawing.Point(0, 70);
            this.PanelLogare.Name = "PanelLogare";
            this.PanelLogare.Size = new System.Drawing.Size(250, 630);
            this.PanelLogare.TabIndex = 3;
            // 
            // TxtBxParola
            // 
            this.TxtBxParola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxParola.Location = new System.Drawing.Point(20, 250);
            this.TxtBxParola.Name = "TxtBxParola";
            this.TxtBxParola.Size = new System.Drawing.Size(200, 36);
            this.TxtBxParola.TabIndex = 0;
            this.TxtBxParola.UseSystemPasswordChar = true;
            this.TxtBxParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBxParola_KeyDown);
            // 
            // LblParola
            // 
            this.LblParola.AutoSize = true;
            this.LblParola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParola.ForeColor = System.Drawing.Color.White;
            this.LblParola.Location = new System.Drawing.Point(20, 210);
            this.LblParola.Name = "LblParola";
            this.LblParola.Size = new System.Drawing.Size(89, 27);
            this.LblParola.TabIndex = 1;
            this.LblParola.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 2;
            // 
            // MesajParola
            // 
            this.MesajParola.AutoSize = true;
            this.MesajParola.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesajParola.ForeColor = System.Drawing.Color.Firebrick;
            this.MesajParola.Location = new System.Drawing.Point(22, 306);
            this.MesajParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MesajParola.Name = "MesajParola";
            this.MesajParola.Size = new System.Drawing.Size(0, 21);
            this.MesajParola.TabIndex = 4;
            // 
            // PanelSetari
            // 
            this.PanelSetari.Controls.Add(this.BtnModificaParola);
            this.PanelSetari.Controls.Add(this.LblModificareParolaAvertisment);
            this.PanelSetari.Controls.Add(this.LblSetari);
            this.PanelSetari.Controls.Add(this.TxtParolaNoua);
            this.PanelSetari.Controls.Add(this.TxtParolaActuala);
            this.PanelSetari.Controls.Add(this.LblNouaParola);
            this.PanelSetari.Controls.Add(this.LblParolaActuala);
            this.PanelSetari.Location = new System.Drawing.Point(251, 71);
            this.PanelSetari.Name = "PanelSetari";
            this.PanelSetari.Size = new System.Drawing.Size(1000, 630);
            this.PanelSetari.TabIndex = 8;
            // 
            // LblParolaActuala
            // 
            this.LblParolaActuala.AutoSize = true;
            this.LblParolaActuala.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblParolaActuala.ForeColor = System.Drawing.Color.White;
            this.LblParolaActuala.Location = new System.Drawing.Point(246, 264);
            this.LblParolaActuala.Name = "LblParolaActuala";
            this.LblParolaActuala.Size = new System.Drawing.Size(317, 27);
            this.LblParolaActuala.TabIndex = 0;
            this.LblParolaActuala.Text = "Introduceti parola actuala: ";
            // 
            // LblNouaParola
            // 
            this.LblNouaParola.AutoSize = true;
            this.LblNouaParola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNouaParola.ForeColor = System.Drawing.Color.White;
            this.LblNouaParola.Location = new System.Drawing.Point(246, 321);
            this.LblNouaParola.Name = "LblNouaParola";
            this.LblNouaParola.Size = new System.Drawing.Size(282, 27);
            this.LblNouaParola.TabIndex = 1;
            this.LblNouaParola.Text = "Introduceti noua parola:";
            // 
            // TxtParolaActuala
            // 
            this.TxtParolaActuala.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParolaActuala.Location = new System.Drawing.Point(589, 255);
            this.TxtParolaActuala.Name = "TxtParolaActuala";
            this.TxtParolaActuala.Size = new System.Drawing.Size(200, 36);
            this.TxtParolaActuala.TabIndex = 2;
            // 
            // TxtParolaNoua
            // 
            this.TxtParolaNoua.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtParolaNoua.Location = new System.Drawing.Point(589, 312);
            this.TxtParolaNoua.Name = "TxtParolaNoua";
            this.TxtParolaNoua.Size = new System.Drawing.Size(200, 36);
            this.TxtParolaNoua.TabIndex = 3;
            // 
            // LblSetari
            // 
            this.LblSetari.AutoSize = true;
            this.LblSetari.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetari.ForeColor = System.Drawing.Color.White;
            this.LblSetari.Location = new System.Drawing.Point(481, 136);
            this.LblSetari.Name = "LblSetari";
            this.LblSetari.Size = new System.Drawing.Size(118, 44);
            this.LblSetari.TabIndex = 4;
            this.LblSetari.Text = "Setari";
            // 
            // LblModificareParolaAvertisment
            // 
            this.LblModificareParolaAvertisment.AutoSize = true;
            this.LblModificareParolaAvertisment.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModificareParolaAvertisment.Location = new System.Drawing.Point(352, 380);
            this.LblModificareParolaAvertisment.Name = "LblModificareParolaAvertisment";
            this.LblModificareParolaAvertisment.Size = new System.Drawing.Size(0, 27);
            this.LblModificareParolaAvertisment.TabIndex = 5;
            // 
            // BtnModificaParola
            // 
            this.BtnModificaParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnModificaParola.FlatAppearance.BorderSize = 0;
            this.BtnModificaParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificaParola.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaParola.ForeColor = System.Drawing.Color.White;
            this.BtnModificaParola.Location = new System.Drawing.Point(402, 448);
            this.BtnModificaParola.Name = "BtnModificaParola";
            this.BtnModificaParola.Size = new System.Drawing.Size(270, 50);
            this.BtnModificaParola.TabIndex = 6;
            this.BtnModificaParola.Text = "Actualizare parola";
            this.BtnModificaParola.UseVisualStyleBackColor = false;
            this.BtnModificaParola.Click += new System.EventHandler(this.BtnActualizeazaParola_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(1275, 700);
            this.Controls.Add(this.PanelAcasa);
            this.Controls.Add(this.PanelLogare);
            this.Controls.Add(this.PanelSetari);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PanelClienti);
            this.Controls.Add(this.PanelAngajati);
            this.Controls.Add(this.PanelBijuterii);
            this.Controls.Add(this.Navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.PanelAcasa.ResumeLayout(false);
            this.PanelAcasa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelBijuterii.ResumeLayout(false);
            this.PanelAngajati.ResumeLayout(false);
            this.PanelClienti.ResumeLayout(false);
            this.PanelLogare.ResumeLayout(false);
            this.PanelLogare.PerformLayout();
            this.PanelSetari.ResumeLayout(false);
            this.PanelSetari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnClienti;
        private System.Windows.Forms.Button BtnAngajati;
        private System.Windows.Forms.Button BtnBijuterii;
        private System.Windows.Forms.Button BtnAcasa;
        private System.Windows.Forms.Panel PanelAcasa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelBijuterii;
        private System.Windows.Forms.Button ButonModificaBijuterie;
        private System.Windows.Forms.Button ButonCautaBijuterie;
        private System.Windows.Forms.Button ButonAfiseazaBijuterie;
        private System.Windows.Forms.Button ButonAdaugaBijuterie;
        private System.Windows.Forms.Panel PanelAngajati;
        private System.Windows.Forms.Button ButonModificaAngajat;
        private System.Windows.Forms.Button ButonCautaAngajat;
        private System.Windows.Forms.Button ButonAfiseazaAngajat;
        private System.Windows.Forms.Button ButonAdaugaAngajat;
        private System.Windows.Forms.Panel PanelClienti;
        private System.Windows.Forms.Button ButonModificaClient;
        private System.Windows.Forms.Button ButonCautaClient;
        private System.Windows.Forms.Button ButonAfiseazaClient;
        private System.Windows.Forms.Button ButonAdaugaClient;
        private System.Windows.Forms.Label LblDescriere;
        private System.Windows.Forms.Label LblTitlu;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnSetari;
        private System.Windows.Forms.Panel PanelLogare;
        private System.Windows.Forms.Label MesajParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblParola;
        private System.Windows.Forms.TextBox TxtBxParola;
        private System.Windows.Forms.Panel PanelSetari;
        private System.Windows.Forms.Label LblSetari;
        private System.Windows.Forms.TextBox TxtParolaNoua;
        private System.Windows.Forms.TextBox TxtParolaActuala;
        private System.Windows.Forms.Label LblNouaParola;
        private System.Windows.Forms.Label LblParolaActuala;
        private System.Windows.Forms.Label LblModificareParolaAvertisment;
        private System.Windows.Forms.Button BtnModificaParola;
    }
}

