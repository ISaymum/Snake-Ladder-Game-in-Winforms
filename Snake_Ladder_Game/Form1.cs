using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snake_Ladder_Game
{
    public partial class EcranAcceuil : Form
    {
        int flag = 0; //Tour du joueur vert
        bool vert = false, rouge = false;

        int x=-1, y=450, valeurDe, p=0;
        int rx = -1, ry = 450, q=1 ;

        int cheat=0;

        private void bRestart_Click(object sender, EventArgs e)
        {
            flag = 0;
            vert = false;
            rouge = false;
            x = 0;
            y = 450;
            rx = 0;
            ry = 450;
            q = 1;
            p = 0;
            bCharger.Enabled = true;
            bSauvegarder.Enabled = true;
            bRoll.Enabled = true;
            bRoll2.Enabled = true;
            bTriche.Enabled = true;
            pbPawn2B.Visible = false;
            pbPawn1B.Visible = false;
        }

        public EcranAcceuil()
        {
            InitializeComponent();
        }


        private void bCharger_Click(object sender, EventArgs e)
        {
            string chemin ="sauvegarde.txt";
            string info = File.ReadAllText(chemin);
            string[] positionJoueur = info.Split(',');
            p = int.Parse(positionJoueur[0]);
            q = int.Parse(positionJoueur[1]);
            x = int.Parse(positionJoueur[2]);
            y = int.Parse(positionJoueur[3]);
            rx = int.Parse(positionJoueur[4]);
            ry = int.Parse(positionJoueur[5]);
            rouge = true;
            vert = true;
            if (vert == true && x>=0)
            {
                x += 1;
                p = Logique.Deplacement(ref x, ref y, p, valeurDe, pbPawn1B, lValeurPosition);
                p = Logique.Serpent(ref x, ref y, p, pbPawn1B);
                p = Logique.Echelle(ref x, ref y, p, pbPawn1B);
                lValeurPosition.Text = p.ToString();
                pbPawn1B.Visible = true;
            }
            if (rouge == true && rx>=0)
            {
                rx += 1;
                q = Logique.Deplacement(ref rx, ref ry, q, valeurDe, pbPawn2B, lValeurPosition2);
                q = Logique.Serpent(ref rx, ref ry, q, pbPawn2B);
                q = Logique.Echelle(ref rx, ref ry, q, pbPawn2B);
                lValeurPosition2.Text = q.ToString();
                pbPawn2B.Visible = true;
            }

        }

        private void EcranAcceuil_Load(object sender, EventArgs e)
        {
            bRestart.Enabled = false;
            CacherLabel();
            if (flag==0)
            {
                bRoll2.Enabled = false;
                lJoueur.Text = "Joueur vert";
            }
            pbPawn2B.Visible = false;
            pbPawn1B.Visible = false;
            pbDice.Image = Image.FromFile(@"./img/DiceRoll.png");
            pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        
        //Lancé de dé
        private void bRoll_Click(object sender, EventArgs e)
        {
            valeurDe= Logique.lanceDe(pbDice);
            lValueDice.Text = valeurDe.ToString();

            //Initalisation des serpents, échelles et mouvement
            if(vert == true)
            {
                p = Logique.Deplacement(ref x, ref y,  p, valeurDe, pbPawn1B, lValeurPosition);
                p = Logique.Serpent(ref x, ref y, p, pbPawn1B);
                p = Logique.Echelle(ref x, ref y, p, pbPawn1B);
                lValeurPosition.Text = p.ToString();
            }

            //Début du jeu et placement du pion seulement si la valeur du dé vaut 6
            if (lValueDice.Text=="6" && vert == false)           
            {
                pbPawn1B.Visible = true;//Affiche le pion  sur le board
                pbPawn1.Visible = false;//Cache le pion du menu
                vert = true;
                pbPawn1B.Location = new Point(x, y);
                lValueX.Text = x.ToString();
                lValueY.Text = y.ToString();
                lValeurPosition.Text = p.ToString();
                
            }

            if (p>=100)
            {
                MessageBox.Show("Victoire du joueur Vert !");
                bCharger.Enabled = false;
                bSauvegarder.Enabled = false;
                bRoll.Enabled = false;
                bRoll2.Enabled = false;
                bTriche.Enabled = false;
                bRestart.Enabled = true;
            }

            if (valeurDe == 6 && p<100)
            {
                flag = 0;
            }
            else if(p<100)
            {
                flag = 1;
                bRoll2.Enabled = true;
                bRoll.Enabled = false;
                lJoueur.Text = "Joueur rouge";
            }


        }
        private void bRoll2_Click(object sender, EventArgs e)
        {
            valeurDe = Logique.lanceDe(pbDice);
            lValueDice.Text = valeurDe.ToString();

            if (rouge == true)
            {
                q = Logique.Deplacement(ref rx, ref ry, q, valeurDe, pbPawn2B, lValeurPosition2);
                q = Logique.Serpent(ref rx, ref ry, q, pbPawn2B);
                q = Logique.Echelle(ref rx, ref ry, q, pbPawn2B);
                lValeurPosition2.Text = q.ToString();
            }

            if (lValueDice.Text == "6" && rouge == false)
            {
                pbPawn2B.Visible = true;//Affiche le pion  sur le board
                pbPawn2.Visible = false;//Cache le pion du menu
                rouge = true;
                pbPawn2B.Location = new Point(rx, ry);
                lValueX.Text = rx.ToString();
                lValueY.Text = ry.ToString();
                lValeurPosition2.Text = p.ToString();

            }
            if (q >= 100)
            {
                MessageBox.Show("Victoire du joueur Rouge!");
                bRoll2.Enabled = false;
                bCharger.Enabled = false;
                bSauvegarder.Enabled = false;
                bRoll.Enabled = false;
                bRoll2.Enabled = false;
                bTriche.Enabled = false;
                bRestart.Enabled = true;
            }

            if (valeurDe==6 && q<100)
            {
                flag = 0;
            }
            else if(q<100)
            {
                flag = 1;
                bRoll2.Enabled = false;
                bRoll.Enabled = true;
                lJoueur.Text = "Joueur vert";
            }
        }
        private void bTriche_Click(object sender, EventArgs e)
        {
            
            cheat++;
            //MessageBox.Show(cheat.ToString());
            if (cheat == 1)
            {
                valeurDe = 6;
                rx = 0;
                ry = 450;
                q = 1;
                rouge = true;
                pbDice.Image = Image.FromFile(@"./img/Dice" + valeurDe + ".png");
                pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (rouge == true)
                {
                    
                    pbPawn2B.Location = new Point(rx, ry);
                    lValeurPosition2.Text = q.ToString();
                    pbPawn2B.Visible = true;
                }
            }
            else if(cheat == 2)
            {
                valeurDe = 3;
                rx = 0;
                ry = 200;
                q = 51;
                rouge = true;
                pbDice.Image = Image.FromFile(@"./img/Dice" + valeurDe + ".png");
                pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (rouge == true)
                {
                    
                    pbPawn2B.Location = new Point(rx, ry);
                    lValeurPosition2.Text = q.ToString();
                    pbPawn2B.Visible = true;
                }
            }
            else if(cheat == 3)
            {
                valeurDe = 6;
                rx = 300;
                ry = 200;
                q = 57;
                rouge = true;
                pbDice.Image = Image.FromFile(@"./img/Dice" + valeurDe + ".png");
                pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (rouge == true)
                {
                    
                    pbPawn2B.Location = new Point(rx, ry);
                    lValeurPosition2.Text = q.ToString();
                    pbPawn2B.Visible = true;
                }
            }
            else if(cheat == 4)
            {
                valeurDe = 6;
                rx = 200;
                ry = 0;
                q = 95;
                rouge = true;
                pbDice.Image = Image.FromFile(@"./img/Dice" + valeurDe + ".png");
                pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (rouge == true)
                {
                    
                    pbPawn2B.Location = new Point(rx, ry);
                    lValeurPosition2.Text = q.ToString();
                    pbPawn2B.Visible = true;
                    
                }
            }
            else if(cheat == 5)
            {
                valeurDe = 5;
                rx = 0;
                ry = 450;
                q = 100;
                rouge = true;
                pbDice.Image = Image.FromFile(@"./img/Dice" + valeurDe + ".png");
                pbDice.SizeMode = PictureBoxSizeMode.StretchImage;
                if (rouge == true)
                {
                    
                    //pbPawn2B.Location = new Point(rx, ry);
                    lValeurPosition2.Text = q.ToString();
                    pbPawn2B.Visible = true;
                    q = Logique.Deplacement(ref rx, ref ry, q, valeurDe, pbPawn2B, lValeurPosition2);
                    MessageBox.Show("Victoire du joueur rouge!");

                    bCharger.Enabled = false;
                    bSauvegarder.Enabled = false;
                    bRoll.Enabled = false;
                    bRoll2.Enabled = false;
                    bTriche.Enabled = false;
                    bRestart.Enabled = true;
                }
                
            }
            
            
        }
        //Label de test et personalisation
        public void CacherLabel()
        {
            lDice.Visible = false;
            //lValueDice.Visible = false;
            lX.Visible = false;
            lY.Visible = false;
            lValueX.Visible = false;
            lValueY.Visible = false;
            lPosition.Visible = false;
            lPosition2.Visible = false;
            //lValeurPosition.Visible = false;
            //lValeurPosition2.Visible = false;
        }
       
        private void bSauvegarder_Click(object sender, EventArgs e)
        {
            
            string chemin = "sauvegarde.txt";
            
            if (!File.Exists(chemin))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(chemin))
                {
                    sw.WriteLine(p.ToString() + "," + q.ToString()+","+x.ToString()+","+y.ToString()+","+rx.ToString()+","+ry.ToString());
                    
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(chemin))
                {
                    sw.WriteLine(p.ToString() + "," + q.ToString() + "," + x.ToString() + "," + y.ToString() + "," + rx.ToString() + "," + ry.ToString());
                }
            }         

        }

    }
}
