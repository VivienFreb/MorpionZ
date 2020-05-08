namespace MorpionZ
{
    partial class frmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
            this.cmdNewGame = new System.Windows.Forms.Button();
            this.cmdQuit = new System.Windows.Forms.Button();
            this.cmdPic3 = new System.Windows.Forms.PictureBox();
            this.cmdPic1 = new System.Windows.Forms.PictureBox();
            this.cmdPic2 = new System.Windows.Forms.PictureBox();
            this.cmdPic4 = new System.Windows.Forms.PictureBox();
            this.cmdPic5 = new System.Windows.Forms.PictureBox();
            this.cmdPic6 = new System.Windows.Forms.PictureBox();
            this.cmdPic7 = new System.Windows.Forms.PictureBox();
            this.cmdPic8 = new System.Windows.Forms.PictureBox();
            this.cmdPic9 = new System.Windows.Forms.PictureBox();
            this.affichageGagnant = new System.Windows.Forms.Label();
            this.menuJeu = new System.Windows.Forms.ToolStrip();
            this.choixJeu = new System.Windows.Forms.ToolStripDropDownButton();
            this.unJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deuxJoueursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdTurnBackground = new System.Windows.Forms.ToolStripButton();
            this.affichageScore = new System.Windows.Forms.Label();
            this.nomScore1 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.demandeNomJoueur1 = new System.Windows.Forms.TextBox();
            this.demandeEntreeNom = new System.Windows.Forms.Label();
            this.validerNom = new System.Windows.Forms.Button();
            this.nomScore2 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.cmdResetScore = new System.Windows.Forms.Button();
            this.pictureWallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic9)).BeginInit();
            this.menuJeu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdNewGame
            // 
            this.cmdNewGame.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.cmdNewGame.Location = new System.Drawing.Point(0, 508);
            this.cmdNewGame.Name = "cmdNewGame";
            this.cmdNewGame.Size = new System.Drawing.Size(187, 53);
            this.cmdNewGame.TabIndex = 10;
            this.cmdNewGame.Text = "Nouvelle partie";
            this.cmdNewGame.UseVisualStyleBackColor = true;
            this.cmdNewGame.Click += new System.EventHandler(this.cmdNewGame_Click);
            // 
            // cmdQuit
            // 
            this.cmdQuit.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.cmdQuit.Location = new System.Drawing.Point(299, 508);
            this.cmdQuit.Name = "cmdQuit";
            this.cmdQuit.Size = new System.Drawing.Size(187, 53);
            this.cmdQuit.TabIndex = 11;
            this.cmdQuit.Text = "Quitter";
            this.cmdQuit.UseVisualStyleBackColor = true;
            this.cmdQuit.Click += new System.EventHandler(this.cmdQuit_Click);
            // 
            // cmdPic3
            // 
            this.cmdPic3.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic3.Enabled = false;
            this.cmdPic3.Location = new System.Drawing.Point(222, 45);
            this.cmdPic3.Name = "cmdPic3";
            this.cmdPic3.Size = new System.Drawing.Size(99, 98);
            this.cmdPic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic3.TabIndex = 16;
            this.cmdPic3.TabStop = false;
            this.cmdPic3.Tag = "";
            this.cmdPic3.Click += new System.EventHandler(this.cmdPic3_Click);
            // 
            // cmdPic1
            // 
            this.cmdPic1.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cmdPic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic1.Enabled = false;
            this.cmdPic1.Location = new System.Drawing.Point(12, 45);
            this.cmdPic1.Name = "cmdPic1";
            this.cmdPic1.Size = new System.Drawing.Size(99, 98);
            this.cmdPic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic1.TabIndex = 17;
            this.cmdPic1.TabStop = false;
            this.cmdPic1.Tag = "";
            this.cmdPic1.Click += new System.EventHandler(this.cmdPic1_Click);
            // 
            // cmdPic2
            // 
            this.cmdPic2.BackColor = System.Drawing.Color.Linen;
            this.cmdPic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic2.Enabled = false;
            this.cmdPic2.Location = new System.Drawing.Point(117, 45);
            this.cmdPic2.Name = "cmdPic2";
            this.cmdPic2.Size = new System.Drawing.Size(99, 98);
            this.cmdPic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic2.TabIndex = 18;
            this.cmdPic2.TabStop = false;
            this.cmdPic2.Click += new System.EventHandler(this.cmdPic2_Click);
            // 
            // cmdPic4
            // 
            this.cmdPic4.BackColor = System.Drawing.Color.Linen;
            this.cmdPic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic4.Enabled = false;
            this.cmdPic4.Location = new System.Drawing.Point(12, 149);
            this.cmdPic4.Name = "cmdPic4";
            this.cmdPic4.Size = new System.Drawing.Size(99, 98);
            this.cmdPic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic4.TabIndex = 19;
            this.cmdPic4.TabStop = false;
            this.cmdPic4.Click += new System.EventHandler(this.cmdPic4_Click);
            // 
            // cmdPic5
            // 
            this.cmdPic5.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic5.Enabled = false;
            this.cmdPic5.Location = new System.Drawing.Point(117, 149);
            this.cmdPic5.Name = "cmdPic5";
            this.cmdPic5.Size = new System.Drawing.Size(99, 98);
            this.cmdPic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic5.TabIndex = 20;
            this.cmdPic5.TabStop = false;
            this.cmdPic5.Click += new System.EventHandler(this.cmdPic5_Click);
            // 
            // cmdPic6
            // 
            this.cmdPic6.BackColor = System.Drawing.Color.Linen;
            this.cmdPic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic6.Enabled = false;
            this.cmdPic6.Location = new System.Drawing.Point(222, 149);
            this.cmdPic6.Name = "cmdPic6";
            this.cmdPic6.Size = new System.Drawing.Size(99, 98);
            this.cmdPic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic6.TabIndex = 21;
            this.cmdPic6.TabStop = false;
            this.cmdPic6.Click += new System.EventHandler(this.cmdPic6_Click);
            // 
            // cmdPic7
            // 
            this.cmdPic7.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPic7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic7.Enabled = false;
            this.cmdPic7.Location = new System.Drawing.Point(12, 253);
            this.cmdPic7.Name = "cmdPic7";
            this.cmdPic7.Size = new System.Drawing.Size(99, 98);
            this.cmdPic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic7.TabIndex = 22;
            this.cmdPic7.TabStop = false;
            this.cmdPic7.Click += new System.EventHandler(this.cmdPic7_Click);
            // 
            // cmdPic8
            // 
            this.cmdPic8.BackColor = System.Drawing.Color.Linen;
            this.cmdPic8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic8.Enabled = false;
            this.cmdPic8.Location = new System.Drawing.Point(117, 253);
            this.cmdPic8.Name = "cmdPic8";
            this.cmdPic8.Size = new System.Drawing.Size(99, 98);
            this.cmdPic8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic8.TabIndex = 23;
            this.cmdPic8.TabStop = false;
            this.cmdPic8.Click += new System.EventHandler(this.cmdPic8_Click);
            // 
            // cmdPic9
            // 
            this.cmdPic9.BackColor = System.Drawing.Color.PowderBlue;
            this.cmdPic9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cmdPic9.Enabled = false;
            this.cmdPic9.Location = new System.Drawing.Point(222, 253);
            this.cmdPic9.Name = "cmdPic9";
            this.cmdPic9.Size = new System.Drawing.Size(99, 98);
            this.cmdPic9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cmdPic9.TabIndex = 24;
            this.cmdPic9.TabStop = false;
            this.cmdPic9.Click += new System.EventHandler(this.cmdPic9_Click);
            // 
            // affichageGagnant
            // 
            this.affichageGagnant.AutoSize = true;
            this.affichageGagnant.BackColor = System.Drawing.Color.Transparent;
            this.affichageGagnant.Font = new System.Drawing.Font("Cooper Black", 15.75F);
            this.affichageGagnant.ForeColor = System.Drawing.SystemColors.Info;
            this.affichageGagnant.Location = new System.Drawing.Point(12, 357);
            this.affichageGagnant.Name = "affichageGagnant";
            this.affichageGagnant.Size = new System.Drawing.Size(0, 24);
            this.affichageGagnant.TabIndex = 25;
            // 
            // menuJeu
            // 
            this.menuJeu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuJeu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choixJeu,
            this.toolStripSeparator1,
            this.cmdTurnBackground});
            this.menuJeu.Location = new System.Drawing.Point(0, 0);
            this.menuJeu.Name = "menuJeu";
            this.menuJeu.Size = new System.Drawing.Size(484, 25);
            this.menuJeu.TabIndex = 27;
            this.menuJeu.Text = "toolStrip1";
            // 
            // choixJeu
            // 
            this.choixJeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.choixJeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unJoueurToolStripMenuItem,
            this.deuxJoueursToolStripMenuItem});
            this.choixJeu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choixJeu.Image = ((System.Drawing.Image)(resources.GetObject("choixJeu.Image")));
            this.choixJeu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.choixJeu.Name = "choixJeu";
            this.choixJeu.Size = new System.Drawing.Size(38, 22);
            this.choixJeu.Text = "Jeu";
            // 
            // unJoueurToolStripMenuItem
            // 
            this.unJoueurToolStripMenuItem.Name = "unJoueurToolStripMenuItem";
            this.unJoueurToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.unJoueurToolStripMenuItem.Text = "Un joueur";
            this.unJoueurToolStripMenuItem.Click += new System.EventHandler(this.unJoueurToolStripMenuItem_Click);
            // 
            // deuxJoueursToolStripMenuItem
            // 
            this.deuxJoueursToolStripMenuItem.Name = "deuxJoueursToolStripMenuItem";
            this.deuxJoueursToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.deuxJoueursToolStripMenuItem.Text = "Deux joueurs";
            this.deuxJoueursToolStripMenuItem.Click += new System.EventHandler(this.deuxJoueursToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cmdTurnBackground
            // 
            this.cmdTurnBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdTurnBackground.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTurnBackground.Image = ((System.Drawing.Image)(resources.GetObject("cmdTurnBackground.Image")));
            this.cmdTurnBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdTurnBackground.Name = "cmdTurnBackground";
            this.cmdTurnBackground.Size = new System.Drawing.Size(119, 22);
            this.cmdTurnBackground.Text = "Arrière plan ON/OFF";
            this.cmdTurnBackground.Click += new System.EventHandler(this.cmdTurnBackground_Click);
            // 
            // affichageScore
            // 
            this.affichageScore.AutoSize = true;
            this.affichageScore.BackColor = System.Drawing.Color.Transparent;
            this.affichageScore.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affichageScore.ForeColor = System.Drawing.Color.White;
            this.affichageScore.Location = new System.Drawing.Point(350, 45);
            this.affichageScore.Name = "affichageScore";
            this.affichageScore.Size = new System.Drawing.Size(113, 32);
            this.affichageScore.TabIndex = 29;
            this.affichageScore.Text = "Scores";
            // 
            // nomScore1
            // 
            this.nomScore1.AutoSize = true;
            this.nomScore1.BackColor = System.Drawing.Color.Transparent;
            this.nomScore1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomScore1.ForeColor = System.Drawing.SystemColors.Info;
            this.nomScore1.Location = new System.Drawing.Point(342, 100);
            this.nomScore1.Name = "nomScore1";
            this.nomScore1.Size = new System.Drawing.Size(78, 31);
            this.nomScore1.TabIndex = 30;
            this.nomScore1.Text = "Joueur 1";
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.ForeColor = System.Drawing.SystemColors.Info;
            this.score1.Location = new System.Drawing.Point(336, 131);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(34, 42);
            this.score1.TabIndex = 31;
            this.score1.Text = "0";
            // 
            // demandeNomJoueur1
            // 
            this.demandeNomJoueur1.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.demandeNomJoueur1.Location = new System.Drawing.Point(122, 420);
            this.demandeNomJoueur1.Name = "demandeNomJoueur1";
            this.demandeNomJoueur1.Size = new System.Drawing.Size(248, 35);
            this.demandeNomJoueur1.TabIndex = 33;
            this.demandeNomJoueur1.TextChanged += new System.EventHandler(this.demandeNomJoueur1_TextChanged);
            // 
            // demandeEntreeNom
            // 
            this.demandeEntreeNom.AutoSize = true;
            this.demandeEntreeNom.BackColor = System.Drawing.Color.Transparent;
            this.demandeEntreeNom.Font = new System.Drawing.Font("Agency FB", 22F, System.Drawing.FontStyle.Bold);
            this.demandeEntreeNom.ForeColor = System.Drawing.SystemColors.Info;
            this.demandeEntreeNom.Location = new System.Drawing.Point(152, 381);
            this.demandeEntreeNom.Name = "demandeEntreeNom";
            this.demandeEntreeNom.Size = new System.Drawing.Size(193, 36);
            this.demandeEntreeNom.TabIndex = 34;
            this.demandeEntreeNom.Text = "Entrez nom joueur 1";
            // 
            // validerNom
            // 
            this.validerNom.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validerNom.Location = new System.Drawing.Point(195, 461);
            this.validerNom.Name = "validerNom";
            this.validerNom.Size = new System.Drawing.Size(99, 24);
            this.validerNom.TabIndex = 35;
            this.validerNom.Text = "Valider";
            this.validerNom.UseVisualStyleBackColor = true;
            this.validerNom.Click += new System.EventHandler(this.validerNom_Click);
            // 
            // nomScore2
            // 
            this.nomScore2.AutoSize = true;
            this.nomScore2.BackColor = System.Drawing.Color.Transparent;
            this.nomScore2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomScore2.ForeColor = System.Drawing.SystemColors.Info;
            this.nomScore2.Location = new System.Drawing.Point(336, 224);
            this.nomScore2.Name = "nomScore2";
            this.nomScore2.Size = new System.Drawing.Size(84, 31);
            this.nomScore2.TabIndex = 36;
            this.nomScore2.Text = "Joueur 2";
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.ForeColor = System.Drawing.SystemColors.Info;
            this.score2.Location = new System.Drawing.Point(336, 253);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(34, 42);
            this.score2.TabIndex = 37;
            this.score2.Text = "0";
            // 
            // cmdResetScore
            // 
            this.cmdResetScore.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetScore.Location = new System.Drawing.Point(356, 327);
            this.cmdResetScore.Name = "cmdResetScore";
            this.cmdResetScore.Size = new System.Drawing.Size(99, 24);
            this.cmdResetScore.TabIndex = 38;
            this.cmdResetScore.Text = "Reset";
            this.cmdResetScore.UseVisualStyleBackColor = true;
            this.cmdResetScore.Click += new System.EventHandler(this.cmdResetScore_Click);
            // 
            // pictureWallpaper
            // 
            this.pictureWallpaper.Image = ((System.Drawing.Image)(resources.GetObject("pictureWallpaper.Image")));
            this.pictureWallpaper.Location = new System.Drawing.Point(0, 0);
            this.pictureWallpaper.Name = "pictureWallpaper";
            this.pictureWallpaper.Size = new System.Drawing.Size(486, 563);
            this.pictureWallpaper.TabIndex = 12;
            this.pictureWallpaper.TabStop = false;
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 562);
            this.Controls.Add(this.cmdResetScore);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.nomScore2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.nomScore1);
            this.Controls.Add(this.affichageScore);
            this.Controls.Add(this.validerNom);
            this.Controls.Add(this.demandeEntreeNom);
            this.Controls.Add(this.demandeNomJoueur1);
            this.Controls.Add(this.menuJeu);
            this.Controls.Add(this.affichageGagnant);
            this.Controls.Add(this.cmdPic9);
            this.Controls.Add(this.cmdPic8);
            this.Controls.Add(this.cmdPic7);
            this.Controls.Add(this.cmdPic6);
            this.Controls.Add(this.cmdPic5);
            this.Controls.Add(this.cmdPic4);
            this.Controls.Add(this.cmdPic2);
            this.Controls.Add(this.cmdPic1);
            this.Controls.Add(this.cmdPic3);
            this.Controls.Add(this.cmdQuit);
            this.Controls.Add(this.cmdNewGame);
            this.Controls.Add(this.pictureWallpaper);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morpion Premium";
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdPic9)).EndInit();
            this.menuJeu.ResumeLayout(false);
            this.menuJeu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNewGame;
        private System.Windows.Forms.Button cmdQuit;
        private System.Windows.Forms.PictureBox cmdPic3;
        private System.Windows.Forms.PictureBox cmdPic1;
        private System.Windows.Forms.PictureBox cmdPic2;
        private System.Windows.Forms.PictureBox cmdPic4;
        private System.Windows.Forms.PictureBox cmdPic5;
        private System.Windows.Forms.PictureBox cmdPic6;
        private System.Windows.Forms.PictureBox cmdPic7;
        private System.Windows.Forms.PictureBox cmdPic8;
        private System.Windows.Forms.PictureBox cmdPic9;
        private System.Windows.Forms.Label affichageGagnant;
        private System.Windows.Forms.ToolStrip menuJeu;
        private System.Windows.Forms.ToolStripDropDownButton choixJeu;
        private System.Windows.Forms.ToolStripMenuItem unJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deuxJoueursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cmdTurnBackground;
        private System.Windows.Forms.Label affichageScore;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.TextBox demandeNomJoueur1;
        private System.Windows.Forms.Label demandeEntreeNom;
        private System.Windows.Forms.Button validerNom;
        private System.Windows.Forms.Label nomScore2;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Button cmdResetScore;
        private System.Windows.Forms.PictureBox pictureWallpaper;
        internal System.Windows.Forms.Label nomScore1;
    }
}

