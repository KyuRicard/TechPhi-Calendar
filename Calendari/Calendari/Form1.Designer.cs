namespace Calendari
{
    partial class Calendari
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
            this.Setmana = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Setmana
            // 
            this.Setmana.Enabled = false;
            this.Setmana.Location = new System.Drawing.Point(12, 1);
            this.Setmana.Name = "Setmana";
            this.Setmana.ReadOnly = true;
            this.Setmana.Size = new System.Drawing.Size(491, 20);
            this.Setmana.TabIndex = 0;
            this.Setmana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calendari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 509);
            this.Controls.Add(this.Setmana);
            this.Name = "Calendari";
            this.Text = "Prototip del calendari";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendari_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calendari_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Setmana;
    }
}

