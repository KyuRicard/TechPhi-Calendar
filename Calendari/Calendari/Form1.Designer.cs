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
            this.components = new System.ComponentModel.Container();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Setmana = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dilluns = new System.Windows.Forms.TextBox();
            this.Dimarts = new System.Windows.Forms.TextBox();
            this.Dimecres = new System.Windows.Forms.TextBox();
            this.Dijous = new System.Windows.Forms.TextBox();
            this.Divendres = new System.Windows.Forms.TextBox();
            this.Dissabte = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Setmana);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 673);
            this.panel1.TabIndex = 1;
            // 
            // Setmana
            // 
            this.Setmana.Enabled = false;
            this.Setmana.Location = new System.Drawing.Point(0, 0);
            this.Setmana.Name = "Setmana";
            this.Setmana.ReadOnly = true;
            this.Setmana.Size = new System.Drawing.Size(1257, 20);
            this.Setmana.TabIndex = 3;
            this.Setmana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Goldenrod;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.Dissabte, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Divendres, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dijous, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dimecres, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dimarts, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dilluns, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 647);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1257, 673);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(599, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plataforma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 85F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(537, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 128);
            this.label2.TabIndex = 7;
            this.label2.Text = "Text";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // Dilluns
            // 
            this.Dilluns.BackColor = System.Drawing.Color.Goldenrod;
            this.Dilluns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dilluns.Enabled = false;
            this.Dilluns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dilluns.Location = new System.Drawing.Point(183, 5);
            this.Dilluns.Multiline = true;
            this.Dilluns.Name = "Dilluns";
            this.Dilluns.ReadOnly = true;
            this.Dilluns.Size = new System.Drawing.Size(170, 56);
            this.Dilluns.TabIndex = 0;
            this.Dilluns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dimarts
            // 
            this.Dimarts.BackColor = System.Drawing.Color.Goldenrod;
            this.Dimarts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dimarts.Enabled = false;
            this.Dimarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dimarts.Location = new System.Drawing.Point(361, 5);
            this.Dimarts.Multiline = true;
            this.Dimarts.Name = "Dimarts";
            this.Dimarts.ReadOnly = true;
            this.Dimarts.Size = new System.Drawing.Size(170, 56);
            this.Dimarts.TabIndex = 2;
            this.Dimarts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dimecres
            // 
            this.Dimecres.BackColor = System.Drawing.Color.Goldenrod;
            this.Dimecres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dimecres.Enabled = false;
            this.Dimecres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dimecres.Location = new System.Drawing.Point(539, 5);
            this.Dimecres.Multiline = true;
            this.Dimecres.Name = "Dimecres";
            this.Dimecres.ReadOnly = true;
            this.Dimecres.Size = new System.Drawing.Size(170, 56);
            this.Dimecres.TabIndex = 3;
            this.Dimecres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dijous
            // 
            this.Dijous.BackColor = System.Drawing.Color.Goldenrod;
            this.Dijous.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dijous.Enabled = false;
            this.Dijous.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dijous.Location = new System.Drawing.Point(717, 5);
            this.Dijous.Multiline = true;
            this.Dijous.Name = "Dijous";
            this.Dijous.ReadOnly = true;
            this.Dijous.Size = new System.Drawing.Size(170, 56);
            this.Dijous.TabIndex = 4;
            this.Dijous.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Divendres
            // 
            this.Divendres.BackColor = System.Drawing.Color.Goldenrod;
            this.Divendres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Divendres.Enabled = false;
            this.Divendres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divendres.Location = new System.Drawing.Point(895, 5);
            this.Divendres.Multiline = true;
            this.Divendres.Name = "Divendres";
            this.Divendres.ReadOnly = true;
            this.Divendres.Size = new System.Drawing.Size(170, 56);
            this.Divendres.TabIndex = 5;
            this.Divendres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dissabte
            // 
            this.Dissabte.BackColor = System.Drawing.Color.Goldenrod;
            this.Dissabte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dissabte.Enabled = false;
            this.Dissabte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dissabte.Location = new System.Drawing.Point(1073, 5);
            this.Dissabte.Multiline = true;
            this.Dissabte.Name = "Dissabte";
            this.Dissabte.ReadOnly = true;
            this.Dissabte.Size = new System.Drawing.Size(170, 56);
            this.Dissabte.TabIndex = 6;
            this.Dissabte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calendari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Calendari";
            this.Text = "Calendari";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calendari_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calendari_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Setmana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dissabte;
        private System.Windows.Forms.TextBox Divendres;
        private System.Windows.Forms.TextBox Dijous;
        private System.Windows.Forms.TextBox Dimecres;
        private System.Windows.Forms.TextBox Dimarts;
        private System.Windows.Forms.TextBox Dilluns;
    }
}

