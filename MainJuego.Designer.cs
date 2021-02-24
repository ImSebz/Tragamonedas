namespace JuegoTragamonedas
{
    partial class MainJuego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainJuego));
            this.panelJuego1 = new System.Windows.Forms.Panel();
            this.panelJuego3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panelJuego2 = new System.Windows.Forms.Panel();
            this.imagenBotonPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStop1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBotonPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJuego1
            // 
            this.panelJuego1.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego1.Location = new System.Drawing.Point(250, 175);
            this.panelJuego1.Name = "panelJuego1";
            this.panelJuego1.Size = new System.Drawing.Size(195, 190);
            this.panelJuego1.TabIndex = 1;
            // 
            // panelJuego3
            // 
            this.panelJuego3.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego3.Location = new System.Drawing.Point(699, 175);
            this.panelJuego3.Name = "panelJuego3";
            this.panelJuego3.Size = new System.Drawing.Size(195, 190);
            this.panelJuego3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panelJuego2
            // 
            this.panelJuego2.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego2.Location = new System.Drawing.Point(479, 175);
            this.panelJuego2.Name = "panelJuego2";
            this.panelJuego2.Size = new System.Drawing.Size(195, 190);
            this.panelJuego2.TabIndex = 2;
            // 
            // imagenBotonPlay
            // 
            this.imagenBotonPlay.BackColor = System.Drawing.Color.Transparent;
            this.imagenBotonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenBotonPlay.Image = global::JuegoTragamonedas.Properties.Resources.Play_Blanco;
            this.imagenBotonPlay.Location = new System.Drawing.Point(879, 459);
            this.imagenBotonPlay.Name = "imagenBotonPlay";
            this.imagenBotonPlay.Size = new System.Drawing.Size(252, 84);
            this.imagenBotonPlay.TabIndex = 7;
            this.imagenBotonPlay.TabStop = false;
            this.imagenBotonPlay.Click += new System.EventHandler(this.imagenBotonPlay_Click);
            // 
            // pictureBoxStop3
            // 
            this.pictureBoxStop3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStop3.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Stop_Blanco;
            this.pictureBoxStop3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStop3.Image = global::JuegoTragamonedas.Properties.Resources.Stop_Blanco;
            this.pictureBoxStop3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop3.InitialImage")));
            this.pictureBoxStop3.Location = new System.Drawing.Point(699, 376);
            this.pictureBoxStop3.Name = "pictureBoxStop3";
            this.pictureBoxStop3.Size = new System.Drawing.Size(197, 77);
            this.pictureBoxStop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop3.TabIndex = 6;
            this.pictureBoxStop3.TabStop = false;
            this.pictureBoxStop3.Click += new System.EventHandler(this.pictureBoxStop3_Click);
            // 
            // pictureBoxStop2
            // 
            this.pictureBoxStop2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStop2.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Stop_Blanco;
            this.pictureBoxStop2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStop2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop2.InitialImage")));
            this.pictureBoxStop2.Location = new System.Drawing.Point(479, 376);
            this.pictureBoxStop2.Name = "pictureBoxStop2";
            this.pictureBoxStop2.Size = new System.Drawing.Size(197, 77);
            this.pictureBoxStop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop2.TabIndex = 5;
            this.pictureBoxStop2.TabStop = false;
            this.pictureBoxStop2.Click += new System.EventHandler(this.pictureBoxStop2_Click);
            // 
            // pictureBoxStop1
            // 
            this.pictureBoxStop1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxStop1.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Stop_Blanco;
            this.pictureBoxStop1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxStop1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxStop1.InitialImage")));
            this.pictureBoxStop1.Location = new System.Drawing.Point(252, 376);
            this.pictureBoxStop1.Name = "pictureBoxStop1";
            this.pictureBoxStop1.Size = new System.Drawing.Size(196, 77);
            this.pictureBoxStop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop1.TabIndex = 4;
            this.pictureBoxStop1.TabStop = false;
            this.pictureBoxStop1.Click += new System.EventHandler(this.pictureBoxStop1_Click);
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHelp.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Help;
            this.pictureBoxHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHelp.Location = new System.Drawing.Point(49, 459);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(223, 84);
            this.pictureBoxHelp.TabIndex = 8;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBoxHelp_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Exit;
            this.pictureBoxExit.Location = new System.Drawing.Point(472, 459);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(221, 84);
            this.pictureBoxExit.TabIndex = 9;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // MainJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::JuegoTragamonedas.Properties.Resources.Casino_completo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1169, 617);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.pictureBoxHelp);
            this.Controls.Add(this.imagenBotonPlay);
            this.Controls.Add(this.pictureBoxStop3);
            this.Controls.Add(this.pictureBoxStop2);
            this.Controls.Add(this.pictureBoxStop1);
            this.Controls.Add(this.panelJuego3);
            this.Controls.Add(this.panelJuego2);
            this.Controls.Add(this.panelJuego1);
            this.DoubleBuffered = true;
            this.Name = "MainJuego";
            this.Text = "Tragamonedas";
            this.Load += new System.EventHandler(this.MainJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenBotonPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelJuego1;
        private System.Windows.Forms.Panel panelJuego2;
        private System.Windows.Forms.Panel panelJuego3;
        private System.Windows.Forms.PictureBox pictureBoxStop1;
        private System.Windows.Forms.PictureBox pictureBoxStop2;
        private System.Windows.Forms.PictureBox pictureBoxStop3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox imagenBotonPlay;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.PictureBox pictureBoxExit;
    }
}

