using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake_Ladder_Game
{
    class Logique
    {
        
        public static int lanceDe(PictureBox px)
        {
            int dice = 0;
            
            Random r = new Random();
            dice = r.Next(1, 7);

            px.Image = Image.FromFile(@"./img/Dice" + dice + ".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;

            return dice;
        }// Méthode de lancement de dé
        public static int Deplacement(ref int x, ref int y, int p, int dice, PictureBox px, Label l)
        {
            //Condition pour éviter le dépassement du board
            if (dice + p >= 100)
            {
                //l.Text = "Vous avez atteint la fin !";
                //l.ForeColor = System.Drawing.Color.Red;
                px.Location = new Point(450, 0);
                p = 100;
                MessageBox.Show("Fin de partie");
                return p;
                
                
            }
            for (int i = 0; i < dice; i++)// déplace le pion selon la valeur du dé sur X
            {
                //Conditions pour les cases des dizaines
                if (p == 10)
                {
                    x = 0;
                    y = 400;
                    
                }
                else if (p == 20)
                {
                    x = 0;
                    y = 350;
                    
                }
                else if (p == 30)
                {
                    x = 0;
                    y = 300;
                    
                }
                else if (p == 40)
                {
                    x = 0;
                    y = 250;
                    
                }
                else if (p == 50)
                {
                    x = 0;
                    y = 200;
                    
                }
                else if (p == 60)
                {
                    x = 0;
                    y = 150;
                    
                }
                else if (p == 70)
                {
                    x = 0;
                    y = 100;
                    
                }
                else if (p == 80)
                {
                    x = 0;
                    y = 50;
                    
                }
                else if (p == 90)
                {
                    x = 0;
                    y = 0;
                    
                }
                

                else
                {
                    x += 50;
                }

                
                px.Location = new Point(x, y);
                p++;
                

            }
            
            return p;
        }//Méthode de déplacement

        public static int Serpent(ref int x, ref int y, int p, PictureBox px)
        {
            if (p == 25)
            {
                x = 200;
                y = 450;
                p = 5;
            }
            else if (p == 34)
            {
                x = 0;
                y = 450;
                p = 1;
            }
            else if (p == 47)
            {
                x = 400;
                y = 400;
                p = 19;
            }
            else if (p == 65)
            {
                x = 50;
                y = 200;
                p = 52;
            }
            else if (p == 87)
            {
                x = 300;
                y = 200;
                p = 57;
            }
            else if (p == 91)
            {
                x = 0;
                y = 150;
                p = 61;
            }
            else if (p == 99)
            {
                x = 400;
                y = 150;
                p = 69;
            }
            px.Location = new Point(x, y);
            //p++;
            return p;

        }//Méthode morsure du serpent

        public static int Echelle(ref int x, ref int y, int p, PictureBox px)
        {
            int tp = 0;
            Random r = new Random();
            if (p == 3)
            {
                x = 0;
                y = 200;
                p = 51;
            }
            else if (p == 6)
            {
                x = 300;
                y = 350;
                p = 27;
            }
            else if (p == 95)
            {
                tp = r.Next(-5, 6);
                if (tp == -5)
                {
                    x = 450;
                    y = 50;
                    p = 90;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==-4)
                {
                    x = 0;
                    y = 0;
                    p = 91;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==-3)
                {
                    x = 50;
                    y = 0;
                    p = 92;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==-2)
                {
                    x = 100;
                    y = 0;
                    p = 93;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==-1)
                {
                    x = 150;
                    y = 0;
                    p = 94;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==0)
                {
                    x = 200;
                    y = 0;
                    p = 95;
                    //MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp==1)
                {
                    x = 250;
                    y = 0;
                    p = 96;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 2)
                {
                    x = 300;
                    y = 0;
                    p = 97;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 3)
                {
                    x = 350;
                    y = 0;
                    p = 98;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 4)
                {
                    x = 400;
                    y = 0;
                    p = 99;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 5)
                {
                    x = 450;
                    y = 0;
                    p = 100;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }


            }
            else if (p==58)
            {
                tp = r.Next(-5, 6);
                if (tp == -5)
                {
                    x = 100;
                    y = 200;
                    p = 53;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -4)
                {
                    x = 150;
                    y = 200;
                    p = 54;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -3)
                {
                    x = 200;
                    y = 200;
                    p = 55;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -2)
                {
                    x = 250;
                    y = 200;
                    p = 56;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -1)
                {
                    x = 300;
                    y = 200;
                    p = 57;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == 0)
                {
                    x = 350;
                    y = 200;
                    p = 58;
                    //MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == 1)
                {
                    x = 400;
                    y = 200;
                    p = 59;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 2)
                {
                    x = 450;
                    y = 200;
                    p = 60;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 3)
                {
                    x = 0;
                    y = 150;
                    p = 61;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 4)
                {
                    x = 50;
                    y = 150;
                    p = 62;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
                else if (tp == 5)
                {
                    x = 100;
                    y = 150;
                    p = 63;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp + 1) + " case");
                }
            }
            else if (p == 26)
            {
                tp = r.Next(-5, 6);
                if (tp == -5)
                {
                    x = 0;
                    y = 350;
                    p = 21;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -4)
                {
                    x = 50;
                    y = 350;
                    p = 22;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -3)
                {
                    x = 100;
                    y = 350;
                    p = 23;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -2)
                {
                    x = 150;
                    y = 350;
                    p = 24;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == -1)
                {
                    x = 200;
                    y = 350;
                    p = 25;
                    MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == 0)
                {
                    x = 250;
                    y = 350;
                    p = 26;
                    //MessageBox.Show("Vous avez été téléporté de : " + tp + " case");
                }
                else if (tp == 1)
                {
                    x = 300;
                    y = 350;
                    p = 27;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp+1) + " case");
                }
                else if (tp == 2)
                {
                    x = 350;
                    y = 350;
                    p = 28;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp+1) + " case");
                }
                else if (tp == 3)
                {
                    x = 400;
                    y = 350;
                    p = 29;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp+1) + " case");
                }
                else if (tp == 4)
                {
                    x = 450;
                    y = 350;
                    p = 30;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp+1) + " case");
                }
                else if (tp == 5)
                {
                    x = 0;
                    y = 300;
                    p = 31;
                    MessageBox.Show("Vous avez été téléporté de : " + (tp+1) + " case");
                }
            }

            else if (p == 20)
            {
                x = 450;
                y = 150;
                p = 70;
            }
            else if (p == 36)
            {
                x = 200;
                y = 200;
                p = 55;
            }
            else if (p == 63)
            {
                x = 200;
                y = 0;
                p = 95;
            }
            else if (p == 68)
            {
                x = 350;
                y = 0;
                p = 98;
            }

            px.Location = new Point(x, y);
            //p++;
            return p;

        }//Méthode grimper Échelles
    }
}
