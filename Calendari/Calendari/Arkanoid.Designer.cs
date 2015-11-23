namespace Calendari
{
    partial class Arkanoid
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
            this.Plataforma = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Plataforma
            // 
            this.Plataforma.AutoSize = true;
            this.Plataforma.Location = new System.Drawing.Point(324, 609);
            this.Plataforma.Name = "Plataforma";
            this.Plataforma.Size = new System.Drawing.Size(89, 13);
            this.Plataforma.TabIndex = 0;
            this.Plataforma.Text = "Soc la plataforma";
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Arkanoid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 631);
            this.Controls.Add(this.Plataforma);
            this.Name = "Arkanoid";
            this.Text = "Arkanoid";
            this.Load += new System.EventHandler(this.Arkanoid_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Arkanoid_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plataforma;
        private System.Windows.Forms.Timer timer1;
    }
}