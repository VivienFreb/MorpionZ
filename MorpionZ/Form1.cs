using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MorpionZ
{
    public partial class frmAccueil : Form
    {
        bool Joueur = true; //True Joueur 1 False Joueur 2
        bool mode = true; //true 2P false 1P vs Robot 
        int[] tab = new int[8];
        int pointcritique = 0;
        int nomJoueur = 0;
        bool playerwin;
        bool player2win;
        bool Gif = true;
        SoundPlayer PlaySoundX = new SoundPlayer(Properties.Resources.playsoundX);
        SoundPlayer PlaySoundO = new SoundPlayer(Properties.Resources.playsoundX);
        Bitmap X = new Bitmap(Properties.Resources.X);
        Bitmap O = new Bitmap(Properties.Resources.O);
        int scorej1 = 0;
        int scorej2 = 0;
        public frmAccueil()
        {
            InitializeComponent();
            var pos = this.PointToScreen(demandeEntreeNom.Location);
            pos = pictureWallpaper.PointToClient(pos);
            demandeEntreeNom.Parent = pictureWallpaper;
            demandeEntreeNom.Location = pos;
            pos = this.PointToScreen(affichageScore.Location);
            pos = pictureWallpaper.PointToClient(pos);
            affichageScore.Parent = pictureWallpaper;
            affichageScore.Location = pos;
            pos = this.PointToScreen(nomScore1.Location);
            pos = pictureWallpaper.PointToClient(pos);
            nomScore1.Parent = pictureWallpaper;
            nomScore1.Location = pos;
            pos = this.PointToScreen(score1.Location);
            pos = pictureWallpaper.PointToClient(pos);
            score1.Parent = pictureWallpaper;
            score1.Location = pos;
            pos = this.PointToScreen(nomScore2.Location);
            pos = pictureWallpaper.PointToClient(pos);
            nomScore2.Parent = pictureWallpaper;
            nomScore2.Location = pos;
            pos = this.PointToScreen(score2.Location);
            pos = pictureWallpaper.PointToClient(pos);
            score2.Parent = pictureWallpaper;
            score2.Location = pos;
            pos = this.PointToScreen(affichageGagnant.Location);
            pos = pictureWallpaper.PointToClient(pos);
            affichageGagnant.Parent = pictureWallpaper;
            affichageGagnant.Location = pos;


            for (int i = 0; i < 8; i++)
            {
                tab[i] = 0;
            }

        }

        private void VerificationGagnant1J()
        {
            for (int i = 0; i < 8; i++)
            {
                if (tab[i] == 15)
                {
                    scorej1++;
                    affichageGagnant.Text = nomScore1.Text + " a gagné !! ";
                    affichageGagnant.ForeColor = Color.FromArgb(0, 122, 199);
                    score1.Text = scorej1.ToString();
                    playerwin = true;
                    desactiverTable();
                    break;
                }
                if (tab[i] == 9)
                {
                    scorej2++;
                    affichageGagnant.Text = nomScore2.Text + " a gagné !! ";
                    affichageGagnant.ForeColor = Color.FromArgb(0, 122, 199);
                    score2.Text = scorej2.ToString();
                    player2win = true;
                    desactiverTable();
                    break;
                }
            }
        }


        private void VerificationGagnant2J()
        {
            for (int i = 0; i < 8; i++)
            {
                if (tab[i] == 15)
                {
                    scorej1++;
                    affichageGagnant.Text = nomScore1.Text + " a gagné !! ";
                    affichageGagnant.ForeColor = Color.Red;
                    score1.Text = scorej1.ToString();
                    playerwin = true;
                    desactiverTable();
                    break;
                }
                if (tab[i] == 9)
                {
                    scorej2++;
                    affichageGagnant.Text = nomScore2.Text + " a gagné !! ";
                    affichageGagnant.ForeColor = Color.FromArgb(0, 122, 199);
                    score2.Text = scorej2.ToString();
                    player2win = true;
                    desactiverTable();
                    break;
                }
            }
        }


        public void resetTable()
        {
            Joueur = true;
            cmdPic1.Image = null;
            cmdPic1.Enabled = true;
            cmdPic1.Tag = null;
            cmdPic2.Image = null;
            cmdPic2.Enabled = true;
            cmdPic2.Tag = null;
            cmdPic3.Image = null;
            cmdPic3.Enabled = true;
            cmdPic3.Tag = null;
            cmdPic4.Image = null;
            cmdPic4.Enabled = true;
            cmdPic4.Tag = null;
            cmdPic5.Image = null;
            cmdPic5.Enabled = true;
            cmdPic5.Tag = null;
            cmdPic6.Image = null;
            cmdPic6.Enabled = true;
            cmdPic6.Tag = null;
            cmdPic7.Image = null;
            cmdPic7.Enabled = true;
            cmdPic7.Tag = null;
            cmdPic8.Image = null;
            cmdPic8.Enabled = true;
            cmdPic8.Tag = null;
            cmdPic9.Image = null;
            cmdPic9.Enabled = true;
            cmdPic9.Tag = null;
        }
        public void desactiverTable()
        {
            cmdPic1.Enabled = false;
            cmdPic2.Enabled = false;
            cmdPic3.Enabled = false;
            cmdPic4.Enabled = false;
            cmdPic5.Enabled = false;
            cmdPic6.Enabled = false;
            cmdPic7.Enabled = false;
            cmdPic8.Enabled = false;
            cmdPic9.Enabled = false;
        }

        public void MatchNul()
        {
            if (cmdPic1.Enabled == false && cmdPic2.Enabled == false && cmdPic3.Enabled == false && cmdPic4.Enabled == false && cmdPic5.Enabled == false && cmdPic6.Enabled == false && cmdPic7.Enabled == false && cmdPic8.Enabled == false && cmdPic9.Enabled == false)
            {
                if (playerwin != true && player2win != true)
                {
                    affichageGagnant.ForeColor = Color.Lime;
                    affichageGagnant.Text = "Match nul!";
                }

            }
        }

        private void Player(int i)
        {
            switch (i)
            {
                case 1:
                    PlaySoundX.Play();
                    cmdPic1.Image = X;
                    cmdPic1.Tag = "X";
                    cmdPic1.Enabled = false;
                    tab[0] += 5;
                    tab[3] += 5;
                    tab[7] += 5;
                    break;
                case 2:
                    PlaySoundX.Play();
                    cmdPic2.Image = X;
                    cmdPic2.Tag = "X";
                    cmdPic2.Enabled = false;
                    tab[0] += 5;
                    tab[4] += 5;
                    break;
                case 3:
                    PlaySoundX.Play();
                    cmdPic3.Image = X;
                    cmdPic3.Tag = "X";
                    cmdPic3.Enabled = false;
                    tab[0] += 5;
                    tab[5] += 5;
                    tab[6] += 5;
                    break;
                case 4:
                    PlaySoundX.Play();
                    cmdPic4.Image = X;
                    cmdPic4.Tag = "X";
                    cmdPic4.Enabled = false;
                    tab[1] += 5;
                    tab[3] += 5;
                    break;
                case 5:
                    PlaySoundX.Play();
                    cmdPic5.Image = X;
                    cmdPic5.Tag = "X";
                    cmdPic5.Enabled = false;
                    tab[1] += 5;
                    tab[4] += 5;
                    tab[6] += 5;
                    tab[7] += 5;
                    break;
                case 6:
                    PlaySoundX.Play();
                    cmdPic6.Image = X;
                    cmdPic6.Tag = "X";
                    cmdPic6.Enabled = false;
                    tab[1] += 5;
                    tab[5] += 5;
                    break;
                case 7:
                    PlaySoundX.Play();
                    cmdPic7.Image = X;
                    cmdPic7.Tag = "X";
                    cmdPic7.Enabled = false;
                    tab[2] += 5;
                    tab[3] += 5;
                    tab[6] += 5;
                    break;
                case 8:
                    PlaySoundX.Play();
                    cmdPic8.Image = X;
                    cmdPic8.Tag = "X";
                    cmdPic8.Enabled = false;
                    tab[2] += 5;
                    tab[4] += 5;
                    break;
                case 9:
                    PlaySoundX.Play();
                    cmdPic9.Image = X;
                    cmdPic9.Tag = "X";
                    cmdPic9.Enabled = false;
                    tab[2] += 5;
                    tab[5] += 5;
                    tab[7] += 5;
                    break;
            }

            if (mode == true)
                VerificationGagnant2J();
            else
                VerificationGagnant1J();

            if (mode == false)
            {
                if (playerwin == false)
                {
                    pointcritique = ComputerSearching();
                    if (pointcritique == -1)
                    {
                        ComputerPlaying(-1);
                    }
                    else
                    {
                        ComputerPlaying(pointcritique);
                    }
                }
            }
            else
            {
                if (playerwin == false)
                {
                    Joueur = false;
                }
            }

        }

        private void Player2(int i)
        {
            switch (i)
            {
                case 1:
                    PlaySoundO.Play();
                    cmdPic1.Image = O;
                    cmdPic1.Tag = "O";
                    cmdPic1.Enabled = false;
                    tab[0] += 3;
                    tab[3] += 3;
                    tab[7] += 3;
                    break;
                case 2:
                    PlaySoundO.Play();
                    cmdPic2.Image = O;
                    cmdPic2.Tag = "O";
                    cmdPic2.Enabled = false;
                    tab[0] += 3;
                    tab[4] += 3;
                    break;
                case 3:
                    PlaySoundO.Play();
                    cmdPic3.Image = O;
                    cmdPic3.Tag = "O";
                    cmdPic3.Enabled = false;
                    tab[0] += 3;
                    tab[5] += 3;
                    tab[6] += 3;
                    break;
                case 4:
                    PlaySoundO.Play();
                    cmdPic4.Image = O;
                    cmdPic4.Tag = "O";
                    cmdPic4.Enabled = false;
                    tab[1] += 3;
                    tab[3] += 3;
                    break;
                case 5:
                    PlaySoundO.Play();
                    cmdPic5.Image = O;
                    cmdPic5.Tag = "O";
                    cmdPic5.Enabled = false;
                    tab[1] += 3;
                    tab[4] += 3;
                    tab[6] += 3;
                    tab[7] += 3;
                    break;
                case 6:
                    PlaySoundO.Play();
                    cmdPic6.Image = O;
                    cmdPic6.Tag = "O";
                    cmdPic6.Enabled = false;
                    tab[1] += 3;
                    tab[5] += 3;
                    break;
                case 7:
                    PlaySoundO.Play();
                    cmdPic7.Image = O;
                    cmdPic7.Tag = "O";
                    cmdPic7.Enabled = false;
                    tab[2] += 3;
                    tab[3] += 3;
                    tab[6] += 3;
                    break;
                case 8:
                    PlaySoundO.Play();
                    cmdPic8.Image = O;
                    cmdPic8.Tag = "O";
                    cmdPic8.Enabled = false;
                    tab[2] += 3;
                    tab[4] += 3;
                    break;
                case 9:
                    PlaySoundO.Play();
                    cmdPic9.Image = O;
                    cmdPic9.Tag = "O";
                    cmdPic9.Enabled = false;
                    tab[2] += 3;
                    tab[5] += 3;
                    tab[7] += 3;
                    break;
            }

            if (mode == true)
                VerificationGagnant2J();
            else
                VerificationGagnant1J();

            if (mode == false)
            {
                if (playerwin == false)
                {
                    pointcritique = ComputerSearching();
                    if (pointcritique == -1)
                    {
                        ComputerPlaying(-1);
                    }
                    else
                    {
                        ComputerPlaying(pointcritique);
                    }
                }
            }
            else
            {
                if (player2win == false)
                {
                    Joueur = true;
                }
            }

        }

        private void ComputerPlaying(int p)
        {
            switch (p)
            {
                case -1:


                case 0:
                    if (cmdPic1.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic1.Image = O;
                        cmdPic1.Tag = "O";
                        cmdPic1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[7] += 3;
                    }
                    else if (cmdPic2.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic2.Image = O;
                        cmdPic2.Tag = "O";
                        cmdPic2.Enabled = false;
                        tab[0] += 3;
                        tab[4] += 3;
                    }
                    else if (cmdPic3.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic3.Image = O;
                        cmdPic3.Tag = "O";
                        cmdPic3.Enabled = false;
                        tab[0] += 3;
                        tab[5] += 3;
                        tab[6] += 3;
                    }

                    break;

                case 1:
                    if (cmdPic4.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic4.Image = O;
                        cmdPic4.Tag = "O";
                        cmdPic4.Enabled = false;
                        tab[1] += 3;
                        tab[3] += 3;
                    }
                    else
                    {
                        if (cmdPic5.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic5.Image = O;
                            cmdPic5.Tag = "O";
                            cmdPic5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else
                        {
                            if (cmdPic6.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic6.Image = O;
                                cmdPic6.Tag = "O";
                                cmdPic6.Enabled = false;
                                tab[1] += 3;
                                tab[5] += 3;
                            }
                        }
                    }
                    break;

                case 2:
                    if (cmdPic7.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic7.Image = O;
                        cmdPic7.Tag = "O";
                        cmdPic7.Enabled = false;
                        tab[2] += 3;
                        tab[3] += 3;
                        tab[6] += 3;
                    }
                    else
                    {
                        if (cmdPic8.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic8.Image = O;
                            cmdPic8.Tag = "O";
                            cmdPic8.Enabled = false;
                            tab[2] += 3;
                            tab[4] += 3;
                        }
                        else
                        {
                            if (cmdPic9.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic9.Image = O;
                                cmdPic9.Tag = "O";
                                cmdPic9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[7] += 3;
                            }
                        }
                    }
                    break;

                case 3:
                    if (cmdPic1.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic1.Image = O;
                        cmdPic1.Tag = "O";
                        cmdPic1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[7] += 3;
                    }
                    else
                    {
                        if (cmdPic4.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic4.Image = O;
                            cmdPic4.Tag = "O";
                            cmdPic4.Enabled = false;
                            tab[1] += 3;
                            tab[3] += 3;
                        }
                        else
                        {
                            if (cmdPic7.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic7.Image = O;
                                cmdPic7.Tag = "O";
                                cmdPic7.Enabled = false;
                                tab[2] += 3;
                                tab[3] += 3;
                                tab[6] += 3;
                            }
                        }
                    }
                    break;
                case 4:
                    if (cmdPic2.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic2.Image = O;
                        cmdPic2.Tag = "O";
                        cmdPic2.Enabled = false;
                        tab[0] += 3;
                        tab[4] += 3;
                    }
                    else
                    {
                        if (cmdPic5.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic5.Image = O;
                            cmdPic5.Tag = "O";
                            cmdPic5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else
                        {
                            if (cmdPic8.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic8.Image = O;
                                cmdPic8.Tag = "O";
                                cmdPic8.Enabled = false;
                                tab[2] += 3;
                                tab[4] += 3;
                            }
                        }
                    }
                    break;

                case 5:
                    if (cmdPic3.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic3.Image = O;
                        cmdPic3.Tag = "O";
                        cmdPic3.Enabled = false;
                        tab[0] += 3;
                        tab[5] += 3;
                        tab[6] += 3;
                    }
                    else
                    {
                        if (cmdPic6.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic6.Image = O;
                            cmdPic6.Tag = "O";
                            cmdPic6.Enabled = false;
                            tab[1] += 3;
                            tab[5] += 3;
                        }
                        else
                        {
                            if (cmdPic9.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic9.Image = O;
                                cmdPic9.Tag = "O";
                                cmdPic9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[7] += 3;
                            }
                        }
                    }
                    break;
                case 6:
                    if (cmdPic3.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic3.Image = O;
                        cmdPic3.Tag = "O";
                        cmdPic3.Enabled = false;
                        tab[0] += 3;
                        tab[5] += 3;
                        tab[6] += 3;
                    }
                    else
                    {
                        if (cmdPic5.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic5.Image = O;
                            cmdPic5.Tag = "O";
                            cmdPic5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else
                        {
                            if (cmdPic7.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic7.Image = O;
                                cmdPic7.Tag = "O";
                                cmdPic7.Enabled = false;
                                tab[2] += 3;
                                tab[3] += 3;
                                tab[6] += 3;
                            }
                        }
                    }
                    break;

                case 7:
                    if (cmdPic1.Tag == null)
                    {
                        PlaySoundO.Play();
                        cmdPic1.Image = O;
                        cmdPic1.Tag = "O";
                        cmdPic1.Enabled = false;
                        tab[0] += 3;
                        tab[3] += 3;
                        tab[7] += 3;
                    }
                    else
                    {
                        if (cmdPic5.Tag == null)
                        {
                            PlaySoundO.Play();
                            cmdPic5.Image = O;
                            cmdPic5.Tag = "O";
                            cmdPic5.Enabled = false;
                            tab[1] += 3;
                            tab[4] += 3;
                            tab[6] += 3;
                            tab[7] += 3;
                        }
                        else
                        {
                            if (cmdPic9.Tag == null)
                            {
                                PlaySoundO.Play();
                                cmdPic9.Image = O;
                                cmdPic9.Tag = "O";
                                cmdPic9.Enabled = false;
                                tab[2] += 3;
                                tab[5] += 3;
                                tab[7] += 3;
                            }
                        }
                    }
                    break;

            }

            VerificationGagnant1J();
        }

        private int ComputerSearching()
        {
            pointcritique = -1;
            for (int i = 0; i < 8; i++)
            {
                if (tab[i] == 6)
                {
                    pointcritique = i;
                    break;
                }
                else
                {
                    if (tab[i] == 10)
                    {
                        pointcritique = i;
                        break;
                    }
                }
            }
            return (pointcritique);
        }

        private void cmdPic1_Click(object sender, EventArgs e)
        {
            cmdPic1.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(1);
                    else
                        Player2(1);
                    MatchNul();
                    break;

                case false:
                    Player(1);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic2_Click(object sender, EventArgs e)
        {
            cmdPic2.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(2);
                    else
                        Player2(2);
                    MatchNul();
                    break;

                case false:
                    Player(2);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic3_Click(object sender, EventArgs e)
        {
            cmdPic3.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(3);
                    else
                        Player2(3);
                    MatchNul();
                    break;

                case false:
                    Player(3);
                    MatchNul();
                    break;
            }
        }
        private void cmdPic4_Click(object sender, EventArgs e)
        {
            cmdPic4.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(4);
                    else
                        Player2(4);
                    MatchNul();
                    break;

                case false:
                    Player(4);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic5_Click(object sender, EventArgs e)
        {
            cmdPic5.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(5);
                    else
                        Player2(5);
                    MatchNul();
                    break;

                case false:
                    Player(5);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic6_Click(object sender, EventArgs e)
        {
            cmdPic6.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(6);
                    else
                        Player2(6);
                    MatchNul();
                    break;

                case false:
                    Player(6);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic7_Click(object sender, EventArgs e)
        {
            cmdPic7.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(7);
                    else
                        Player2(7);
                    MatchNul();
                    break;

                case false:
                    Player(7);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic8_Click(object sender, EventArgs e)
        {
            cmdPic8.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(8);
                    else
                        Player2(8);
                    MatchNul();
                    break;

                case false:
                    Player(8);
                    MatchNul();
                    break;
            }
        }

        private void cmdPic9_Click(object sender, EventArgs e)
        {
            cmdPic9.Enabled = false;
            switch (mode)
            {
                case true:
                    if (Joueur == true)
                        Player(9);
                    else
                        Player2(9);
                    MatchNul();
                    break;

                case false:
                    Player(9);
                    MatchNul();
                    break;
            }
        }

        private void cmdNewGame_Click(object sender, EventArgs e)
        {
            resetTable();
            affichageGagnant.Text = "";
            for (int i = 0; i < 8; i++)
            {
                tab[i] = 0;
            }
            pointcritique = 0;
            playerwin = false;
            player2win = false;
        }

        private void cmdTurnBackground_Click(object sender, EventArgs e)
        {
            if (Gif == true)
            {
                pictureWallpaper.Enabled = false;
                Gif = false;
                /*
                demandeEntreeNom.BackColor = Color.White;
                nomScore1.BackColor = Color.White;
                score1.BackColor = Color.White;
                nomScore2.BackColor = Color.White;
                score2.BackColor = Color.White;
                affichageScore.BackColor = Color.White;
                */
            }
            else if (Gif == false)
            {
                pictureWallpaper.Enabled = true;
                Gif = true;
                /*
                demandeEntreeNom.BackColor = System.Drawing.Color.Transparent;
                nomScore1.BackColor = System.Drawing.Color.Transparent;
                score1.BackColor = System.Drawing.Color.Transparent;
                nomScore2.BackColor = System.Drawing.Color.Transparent;
                score2.BackColor = System.Drawing.Color.Transparent;
                affichageScore.BackColor = System.Drawing.Color.Transparent;
                */
            }
        }

        private void unJoueurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTable();
            for (int i = 0; i < 8; i++)
            {
                tab[i] = 0;
            }
            desactiverTable();
            playerwin = false;
            player2win = false;
            mode = false;
            scorej1 = 0;
            scorej2 = 0;
            score1.Text = scorej1.ToString();
            score2.Text = scorej2.ToString();
            nomScore2.Text = "Robot";
            demandeNomJoueur1.Text = "";
            validerNom.Visible = true;
            demandeNomJoueur1.Visible = true;
            demandeEntreeNom.Visible = true;
            demandeEntreeNom.Text = "Entrez nom joueur 1";
        }

        private void deuxJoueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetTable();
            for (int i = 0; i < 8; i++)
            {
                tab[i] = 0;
            }
            desactiverTable();
            playerwin = false;
            player2win = false;
            mode = true;
            scorej1 = 0;
            scorej2 = 0;
            score1.Text = scorej1.ToString();
            score2.Text = scorej2.ToString();
            demandeNomJoueur1.Text = "";
            validerNom.Visible = true;
            demandeNomJoueur1.Visible = true;
            demandeEntreeNom.Visible = true;
            demandeEntreeNom.Text = "Entrez nom joueur 1";
            nomJoueur = 0;
        }

        private void validerNom_Click(object sender, EventArgs e)
        {
            if (mode == true)
            {
                if (nomJoueur == 0)
                {
                    nomJoueur++;
                    demandeEntreeNom.Text = "Entrez nom joueur 2";
                    demandeNomJoueur1.Text = "";
                }
                else if (nomJoueur == 1)
                {
                    validerNom.Visible = false;
                    demandeNomJoueur1.Visible = false;
                    demandeEntreeNom.Visible = false;
                    resetTable();
                }
            }
            else
            {
                demandeEntreeNom.Text = "Entrez nom joueur 1";
                validerNom.Visible = false;
                demandeNomJoueur1.Visible = false;
                demandeEntreeNom.Visible = false;
                resetTable();
            }

        }

        private void demandeNomJoueur1_TextChanged(object sender, EventArgs e)
        {
            if (mode == true)
            {
                if (nomJoueur == 0)
                {
                    nomScore1.Text = demandeNomJoueur1.Text;
                }
                else if (nomJoueur == 1)
                {
                    nomScore2.Text = demandeNomJoueur1.Text;
                }
            }
            else
            {
                nomScore1.Text = demandeNomJoueur1.Text;
            }
        }

        private void cmdResetScore_Click(object sender, EventArgs e)
        {
            scorej1 = 0;
            scorej2 = 0;
            score1.Text = scorej1.ToString();
            score2.Text = scorej2.ToString();
        }

        private void cmdQuit_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir quitter?",
                                     "Confirmation",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }           
        }

    }
}
