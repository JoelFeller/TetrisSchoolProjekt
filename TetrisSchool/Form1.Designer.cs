namespace TetrisSchool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblPlayingfield = new System.Windows.Forms.Label();
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlayingfield
            // 
            this.lblPlayingfield.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblPlayingfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlayingfield.Image = ((System.Drawing.Image)(resources.GetObject("lblPlayingfield.Image")));
            this.lblPlayingfield.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPlayingfield.Location = new System.Drawing.Point(10, 11);
            this.lblPlayingfield.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayingfield.Name = "lblPlayingfield";
            this.lblPlayingfield.Size = new System.Drawing.Size(406, 600);
            this.lblPlayingfield.TabIndex = 0;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.Silver;
            this.lblInstructions.Location = new System.Drawing.Point(529, 471);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(106, 139);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "Controls:\r\n\r\nArrow Up or W:\r\nArrow Left or A:\r\nArrow Right or D:\r\nArrow Down or S" +
    ":\r\nSpace:\r\nShift:\r\nEscape:";
            // 
            // lblControls
            // 
            this.lblControls.BackColor = System.Drawing.Color.Silver;
            this.lblControls.Location = new System.Drawing.Point(629, 471);
            this.lblControls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(237, 139);
            this.lblControls.TabIndex = 2;
            this.lblControls.Text = resources.GetString("lblControls.Text");
            this.lblControls.Click += new System.EventHandler(this.lblControls_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(907, 617);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblPlayingfield);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlayingfield;
        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblControls;
    }
}

