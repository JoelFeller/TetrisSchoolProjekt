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
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.gameGrid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // gameGrid
            // 
            this.gameGrid.Location = new System.Drawing.Point(298, 29);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(310, 558);
            this.gameGrid.TabIndex = 8;
            // 
            // Tetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 617);
            this.Controls.Add(this.gameGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Tetris";
            this.Text = "Tetris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tetris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Tetris_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Panel gameGrid;
    }
}

