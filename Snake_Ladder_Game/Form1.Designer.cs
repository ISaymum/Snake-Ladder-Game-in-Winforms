
namespace Snake_Ladder_Game
{
    partial class EcranAcceuil
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.bTriche = new System.Windows.Forms.Button();
            this.bSauvegarder = new System.Windows.Forms.Button();
            this.bCharger = new System.Windows.Forms.Button();
            this.lJoueur = new System.Windows.Forms.Label();
            this.lValeurPosition2 = new System.Windows.Forms.Label();
            this.lPosition2 = new System.Windows.Forms.Label();
            this.bRoll2 = new System.Windows.Forms.Button();
            this.lValeurPosition = new System.Windows.Forms.Label();
            this.lPosition = new System.Windows.Forms.Label();
            this.bRoll = new System.Windows.Forms.Button();
            this.lValueY = new System.Windows.Forms.Label();
            this.lValueX = new System.Windows.Forms.Label();
            this.lValueDice = new System.Windows.Forms.Label();
            this.lY = new System.Windows.Forms.Label();
            this.lX = new System.Windows.Forms.Label();
            this.lDice = new System.Windows.Forms.Label();
            this.pbDice = new System.Windows.Forms.PictureBox();
            this.pPlayers = new System.Windows.Forms.Panel();
            this.pbPawn2 = new System.Windows.Forms.PictureBox();
            this.pbPawn1 = new System.Windows.Forms.PictureBox();
            this.pBoard = new System.Windows.Forms.Panel();
            this.pbPawn2B = new System.Windows.Forms.PictureBox();
            this.pbPawn1B = new System.Windows.Forms.PictureBox();
            this.bRestart = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).BeginInit();
            this.pPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn1)).BeginInit();
            this.pBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn2B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn1B)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.Silver;
            this.pMenu.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Fond;
            this.pMenu.Controls.Add(this.bTriche);
            this.pMenu.Controls.Add(this.bSauvegarder);
            this.pMenu.Controls.Add(this.bCharger);
            this.pMenu.Controls.Add(this.lJoueur);
            this.pMenu.Controls.Add(this.lValeurPosition2);
            this.pMenu.Controls.Add(this.lPosition2);
            this.pMenu.Controls.Add(this.bRoll2);
            this.pMenu.Controls.Add(this.lValeurPosition);
            this.pMenu.Controls.Add(this.lPosition);
            this.pMenu.Controls.Add(this.bRoll);
            this.pMenu.Controls.Add(this.lValueY);
            this.pMenu.Controls.Add(this.lValueX);
            this.pMenu.Controls.Add(this.lValueDice);
            this.pMenu.Controls.Add(this.lY);
            this.pMenu.Controls.Add(this.lX);
            this.pMenu.Controls.Add(this.lDice);
            this.pMenu.Controls.Add(this.pbDice);
            this.pMenu.Controls.Add(this.pPlayers);
            this.pMenu.Location = new System.Drawing.Point(518, 12);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(190, 500);
            this.pMenu.TabIndex = 1;
            // 
            // bTriche
            // 
            this.bTriche.BackColor = System.Drawing.Color.Black;
            this.bTriche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTriche.ForeColor = System.Drawing.Color.White;
            this.bTriche.Location = new System.Drawing.Point(1, 449);
            this.bTriche.Name = "bTriche";
            this.bTriche.Size = new System.Drawing.Size(189, 31);
            this.bTriche.TabIndex = 17;
            this.bTriche.Text = "Cheat";
            this.bTriche.UseVisualStyleBackColor = false;
            this.bTriche.Click += new System.EventHandler(this.bTriche_Click);
            // 
            // bSauvegarder
            // 
            this.bSauvegarder.BackColor = System.Drawing.Color.Chocolate;
            this.bSauvegarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSauvegarder.ForeColor = System.Drawing.Color.White;
            this.bSauvegarder.Location = new System.Drawing.Point(92, 322);
            this.bSauvegarder.Name = "bSauvegarder";
            this.bSauvegarder.Size = new System.Drawing.Size(93, 35);
            this.bSauvegarder.TabIndex = 16;
            this.bSauvegarder.Text = "Save";
            this.bSauvegarder.UseVisualStyleBackColor = false;
            this.bSauvegarder.Click += new System.EventHandler(this.bSauvegarder_Click);
            // 
            // bCharger
            // 
            this.bCharger.BackColor = System.Drawing.Color.Chocolate;
            this.bCharger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCharger.ForeColor = System.Drawing.Color.White;
            this.bCharger.Location = new System.Drawing.Point(0, 322);
            this.bCharger.Name = "bCharger";
            this.bCharger.Size = new System.Drawing.Size(93, 35);
            this.bCharger.TabIndex = 15;
            this.bCharger.Text = "Load";
            this.bCharger.UseVisualStyleBackColor = false;
            this.bCharger.Click += new System.EventHandler(this.bCharger_Click);
            // 
            // lJoueur
            // 
            this.lJoueur.BackColor = System.Drawing.Color.Turquoise;
            this.lJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lJoueur.ForeColor = System.Drawing.Color.White;
            this.lJoueur.Location = new System.Drawing.Point(1, 252);
            this.lJoueur.Name = "lJoueur";
            this.lJoueur.Size = new System.Drawing.Size(185, 35);
            this.lJoueur.TabIndex = 14;
            this.lJoueur.Text = "Green Pawn";
            this.lJoueur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lValeurPosition2
            // 
            this.lValeurPosition2.BackColor = System.Drawing.Color.Red;
            this.lValeurPosition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValeurPosition2.ForeColor = System.Drawing.Color.White;
            this.lValeurPosition2.Location = new System.Drawing.Point(0, 409);
            this.lValeurPosition2.Name = "lValeurPosition2";
            this.lValeurPosition2.Size = new System.Drawing.Size(185, 35);
            this.lValeurPosition2.TabIndex = 13;
            this.lValeurPosition2.Text = "Red position : ";
            this.lValeurPosition2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPosition2
            // 
            this.lPosition2.AutoSize = true;
            this.lPosition2.ForeColor = System.Drawing.Color.Red;
            this.lPosition2.Location = new System.Drawing.Point(18, 928);
            this.lPosition2.Name = "lPosition2";
            this.lPosition2.Size = new System.Drawing.Size(17, 13);
            this.lPosition2.TabIndex = 12;
            this.lPosition2.Text = "P:";
            // 
            // bRoll2
            // 
            this.bRoll2.BackColor = System.Drawing.Color.Red;
            this.bRoll2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRoll2.ForeColor = System.Drawing.Color.White;
            this.bRoll2.Location = new System.Drawing.Point(95, 291);
            this.bRoll2.Name = "bRoll2";
            this.bRoll2.Size = new System.Drawing.Size(93, 35);
            this.bRoll2.TabIndex = 11;
            this.bRoll2.Text = "Roll !";
            this.bRoll2.UseVisualStyleBackColor = false;
            this.bRoll2.Click += new System.EventHandler(this.bRoll2_Click);
            // 
            // lValeurPosition
            // 
            this.lValeurPosition.BackColor = System.Drawing.Color.Green;
            this.lValeurPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValeurPosition.ForeColor = System.Drawing.Color.White;
            this.lValeurPosition.Location = new System.Drawing.Point(0, 360);
            this.lValeurPosition.Name = "lValeurPosition";
            this.lValeurPosition.Size = new System.Drawing.Size(185, 35);
            this.lValeurPosition.TabIndex = 10;
            this.lValeurPosition.Text = "Green position :";
            this.lValeurPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.ForeColor = System.Drawing.Color.Green;
            this.lPosition.Location = new System.Drawing.Point(18, 950);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(17, 13);
            this.lPosition.TabIndex = 9;
            this.lPosition.Text = "P:";
            // 
            // bRoll
            // 
            this.bRoll.BackColor = System.Drawing.Color.Green;
            this.bRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRoll.ForeColor = System.Drawing.Color.White;
            this.bRoll.Location = new System.Drawing.Point(-2, 290);
            this.bRoll.Name = "bRoll";
            this.bRoll.Size = new System.Drawing.Size(93, 35);
            this.bRoll.TabIndex = 8;
            this.bRoll.Text = "Roll !";
            this.bRoll.UseVisualStyleBackColor = false;
            this.bRoll.Click += new System.EventHandler(this.bRoll_Click);
            // 
            // lValueY
            // 
            this.lValueY.AutoSize = true;
            this.lValueY.Location = new System.Drawing.Point(41, 915);
            this.lValueY.Name = "lValueY";
            this.lValueY.Size = new System.Drawing.Size(14, 13);
            this.lValueY.TabIndex = 7;
            this.lValueY.Text = "Y";
            // 
            // lValueX
            // 
            this.lValueX.AutoSize = true;
            this.lValueX.Location = new System.Drawing.Point(41, 897);
            this.lValueX.Name = "lValueX";
            this.lValueX.Size = new System.Drawing.Size(14, 13);
            this.lValueX.TabIndex = 6;
            this.lValueX.Text = "X";
            // 
            // lValueDice
            // 
            this.lValueDice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lValueDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValueDice.ForeColor = System.Drawing.Color.White;
            this.lValueDice.Location = new System.Drawing.Point(3, 111);
            this.lValueDice.Name = "lValueDice";
            this.lValueDice.Size = new System.Drawing.Size(185, 35);
            this.lValueDice.TabIndex = 5;
            this.lValueDice.Text = "Dice value";
            this.lValueDice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lY
            // 
            this.lY.AutoSize = true;
            this.lY.Location = new System.Drawing.Point(18, 915);
            this.lY.Name = "lY";
            this.lY.Size = new System.Drawing.Size(17, 13);
            this.lY.TabIndex = 4;
            this.lY.Text = "Y:";
            // 
            // lX
            // 
            this.lX.AutoSize = true;
            this.lX.Location = new System.Drawing.Point(18, 897);
            this.lX.Name = "lX";
            this.lX.Size = new System.Drawing.Size(17, 13);
            this.lX.TabIndex = 3;
            this.lX.Text = "X:";
            // 
            // lDice
            // 
            this.lDice.AutoSize = true;
            this.lDice.Location = new System.Drawing.Point(18, 973);
            this.lDice.Name = "lDice";
            this.lDice.Size = new System.Drawing.Size(32, 13);
            this.lDice.TabIndex = 2;
            this.lDice.Text = "Dice:";
            // 
            // pbDice
            // 
            this.pbDice.BackColor = System.Drawing.Color.Transparent;
            this.pbDice.Location = new System.Drawing.Point(44, 149);
            this.pbDice.Name = "pbDice";
            this.pbDice.Size = new System.Drawing.Size(100, 100);
            this.pbDice.TabIndex = 1;
            this.pbDice.TabStop = false;
            // 
            // pPlayers
            // 
            this.pPlayers.BackColor = System.Drawing.Color.Transparent;
            this.pPlayers.Controls.Add(this.pbPawn2);
            this.pPlayers.Controls.Add(this.pbPawn1);
            this.pPlayers.Location = new System.Drawing.Point(3, 3);
            this.pPlayers.Name = "pPlayers";
            this.pPlayers.Size = new System.Drawing.Size(198, 102);
            this.pPlayers.TabIndex = 0;
            // 
            // pbPawn2
            // 
            this.pbPawn2.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Pion11;
            this.pbPawn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPawn2.Location = new System.Drawing.Point(96, -3);
            this.pbPawn2.Name = "pbPawn2";
            this.pbPawn2.Size = new System.Drawing.Size(94, 100);
            this.pbPawn2.TabIndex = 2;
            this.pbPawn2.TabStop = false;
            // 
            // pbPawn1
            // 
            this.pbPawn1.BackColor = System.Drawing.Color.Transparent;
            this.pbPawn1.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Pion0;
            this.pbPawn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPawn1.Location = new System.Drawing.Point(3, -1);
            this.pbPawn1.Name = "pbPawn1";
            this.pbPawn1.Size = new System.Drawing.Size(94, 100);
            this.pbPawn1.TabIndex = 1;
            this.pbPawn1.TabStop = false;
            // 
            // pBoard
            // 
            this.pBoard.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Board;
            this.pBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoard.Controls.Add(this.pbPawn2B);
            this.pBoard.Controls.Add(this.pbPawn1B);
            this.pBoard.Location = new System.Drawing.Point(12, 11);
            this.pBoard.Name = "pBoard";
            this.pBoard.Size = new System.Drawing.Size(500, 500);
            this.pBoard.TabIndex = 0;
            // 
            // pbPawn2B
            // 
            this.pbPawn2B.BackColor = System.Drawing.Color.Transparent;
            this.pbPawn2B.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Pion11;
            this.pbPawn2B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPawn2B.Location = new System.Drawing.Point(0, 350);
            this.pbPawn2B.Name = "pbPawn2B";
            this.pbPawn2B.Size = new System.Drawing.Size(50, 50);
            this.pbPawn2B.TabIndex = 12;
            this.pbPawn2B.TabStop = false;
            // 
            // pbPawn1B
            // 
            this.pbPawn1B.BackColor = System.Drawing.Color.Transparent;
            this.pbPawn1B.BackgroundImage = global::Snake_Ladder_Game.Properties.Resources.Pion0;
            this.pbPawn1B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPawn1B.Location = new System.Drawing.Point(0, 450);
            this.pbPawn1B.Name = "pbPawn1B";
            this.pbPawn1B.Size = new System.Drawing.Size(50, 50);
            this.pbPawn1B.TabIndex = 3;
            this.pbPawn1B.TabStop = false;
            // 
            // bRestart
            // 
            this.bRestart.Location = new System.Drawing.Point(12, 517);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(500, 50);
            this.bRestart.TabIndex = 2;
            this.bRestart.Text = "Recommencer";
            this.bRestart.UseVisualStyleBackColor = true;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // EcranAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 579);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pBoard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAcceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.EcranAcceuil_Load);
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice)).EndInit();
            this.pPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn1)).EndInit();
            this.pBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn2B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPawn1B)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBoard;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.PictureBox pbPawn1;
        private System.Windows.Forms.Panel pPlayers;
        private System.Windows.Forms.PictureBox pbPawn2;
        private System.Windows.Forms.PictureBox pbDice;
        private System.Windows.Forms.Button bRoll;
        private System.Windows.Forms.Label lValueY;
        private System.Windows.Forms.Label lValueX;
        private System.Windows.Forms.Label lValueDice;
        private System.Windows.Forms.Label lY;
        private System.Windows.Forms.Label lX;
        private System.Windows.Forms.Label lDice;
        private System.Windows.Forms.PictureBox pbPawn1B;
        private System.Windows.Forms.Label lValeurPosition;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.Button bRoll2;
        private System.Windows.Forms.PictureBox pbPawn2B;
        private System.Windows.Forms.Label lValeurPosition2;
        private System.Windows.Forms.Label lPosition2;
        private System.Windows.Forms.Label lJoueur;
        private System.Windows.Forms.Button bSauvegarder;
        private System.Windows.Forms.Button bCharger;
        private System.Windows.Forms.Button bTriche;
        private System.Windows.Forms.Button bRestart;
    }
}

