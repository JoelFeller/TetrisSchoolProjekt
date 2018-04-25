namespace TetrisSchool
{
    partial class Tetris
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.gameGrid = new System.Windows.Forms.Panel();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.textBoxHighScore = new System.Windows.Forms.TextBox();
            this.labelHighscore = new System.Windows.Forms.Label();
            this.labelReiheVoll = new System.Windows.Forms.Label();
            this.textBoxRowsCompleted = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.gameGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTick
            // 
            this.gameTick.Interval = 500;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // gameGrid
            // 
            this.gameGrid.Controls.Add(this.labelGameOver);
            this.gameGrid.Location = new System.Drawing.Point(9, 12);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(310, 558);
            this.gameGrid.TabIndex = 8;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Enabled = false;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(3, 177);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(291, 55);
            this.labelGameOver.TabIndex = 28;
            this.labelGameOver.Text = "YOU LOSE!";
            this.labelGameOver.Visible = false;
            // 
            // textBoxHighScore
            // 
            this.textBoxHighScore.Enabled = false;
            this.textBoxHighScore.Location = new System.Drawing.Point(351, 404);
            this.textBoxHighScore.Name = "textBoxHighScore";
            this.textBoxHighScore.ReadOnly = true;
            this.textBoxHighScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxHighScore.TabIndex = 23;
            this.textBoxHighScore.TabStop = false;
            // 
            // labelHighscore
            // 
            this.labelHighscore.AutoSize = true;
            this.labelHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscore.Location = new System.Drawing.Point(326, 384);
            this.labelHighscore.Name = "labelHighscore";
            this.labelHighscore.Size = new System.Drawing.Size(105, 16);
            this.labelHighscore.TabIndex = 22;
            this.labelHighscore.Text = "HIGH SCORE:";
            // 
            // labelReiheVoll
            // 
            this.labelReiheVoll.AutoSize = true;
            this.labelReiheVoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReiheVoll.Location = new System.Drawing.Point(326, 326);
            this.labelReiheVoll.Name = "labelReiheVoll";
            this.labelReiheVoll.Size = new System.Drawing.Size(154, 16);
            this.labelReiheVoll.TabIndex = 21;
            this.labelReiheVoll.Text = "ENTFERNTE REIHE:";
            // 
            // textBoxRowsCompleted
            // 
            this.textBoxRowsCompleted.Enabled = false;
            this.textBoxRowsCompleted.Location = new System.Drawing.Point(351, 346);
            this.textBoxRowsCompleted.Name = "textBoxRowsCompleted";
            this.textBoxRowsCompleted.ReadOnly = true;
            this.textBoxRowsCompleted.Size = new System.Drawing.Size(100, 20);
            this.textBoxRowsCompleted.TabIndex = 20;
            this.textBoxRowsCompleted.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(324, 268);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(73, 16);
            this.labelScore.TabIndex = 19;
            this.labelScore.Text = "PUNKTE:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.CausesValidation = false;
            this.textBoxScore.Enabled = false;
            this.textBoxScore.Location = new System.Drawing.Point(351, 288);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxScore.TabIndex = 18;
            this.textBoxScore.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonStart.CausesValidation = false;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(330, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 53);
            this.buttonStart.TabIndex = 26;
            this.buttonStart.TabStop = false;
            this.buttonStart.Text = "&START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Red;
            this.buttonQuit.Location = new System.Drawing.Point(330, 517);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(121, 53);
            this.buttonQuit.TabIndex = 27;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(470, 12);
            this.labelInstructions.MaximumSize = new System.Drawing.Size(425, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(425, 256);
            this.labelInstructions.TabIndex = 28;
            this.labelInstructions.Text = resources.GetString("labelInstructions.Text");
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 580);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxHighScore);
            this.Controls.Add(this.labelHighscore);
            this.Controls.Add(this.labelReiheVoll);
            this.Controls.Add(this.textBoxRowsCompleted);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.gameGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tetris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Tetris_PreviewKeyDown);
            this.gameGrid.ResumeLayout(false);
            this.gameGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.Panel gameGrid;
        private System.Windows.Forms.TextBox textBoxHighScore;
        private System.Windows.Forms.Label labelHighscore;
        private System.Windows.Forms.Label labelReiheVoll;
        private System.Windows.Forms.TextBox textBoxRowsCompleted;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelInstructions;
    }
}

