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
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.gameGrid = new System.Windows.Forms.Panel();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.textBoxHighScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRowsCompleted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
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
            this.gameGrid.Location = new System.Drawing.Point(12, 47);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(310, 558);
            this.gameGrid.TabIndex = 8;
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.Location = new System.Drawing.Point(37, 71);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(578, 128);
            this.labelGameOver.TabIndex = 28;
            this.labelGameOver.Text = "YOU LOSE!";
            this.labelGameOver.Visible = false;
            // 
            // textBoxHighScore
            // 
            this.textBoxHighScore.Enabled = false;
            this.textBoxHighScore.Location = new System.Drawing.Point(372, 400);
            this.textBoxHighScore.Name = "textBoxHighScore";
            this.textBoxHighScore.ReadOnly = true;
            this.textBoxHighScore.Size = new System.Drawing.Size(100, 20);
            this.textBoxHighScore.TabIndex = 23;
            this.textBoxHighScore.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(347, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "HIGH SCORE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "ROWS COMPLETED:";
            // 
            // textBoxRowsCompleted
            // 
            this.textBoxRowsCompleted.Enabled = false;
            this.textBoxRowsCompleted.Location = new System.Drawing.Point(372, 342);
            this.textBoxRowsCompleted.Name = "textBoxRowsCompleted";
            this.textBoxRowsCompleted.ReadOnly = true;
            this.textBoxRowsCompleted.Size = new System.Drawing.Size(100, 20);
            this.textBoxRowsCompleted.TabIndex = 20;
            this.textBoxRowsCompleted.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "SCORE:";
            // 
            // textBoxScore
            // 
            this.textBoxScore.CausesValidation = false;
            this.textBoxScore.Enabled = false;
            this.textBoxScore.Location = new System.Drawing.Point(372, 284);
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
            this.buttonStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(351, 47);
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
            this.buttonQuit.Location = new System.Drawing.Point(349, 552);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(121, 53);
            this.buttonQuit.TabIndex = 27;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 617);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxHighScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRowsCompleted);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRowsCompleted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Label labelGameOver;
    }
}

