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
            this.Hora = new System.Windows.Forms.Label();
            this.Setmana = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.Dissabte = new System.Windows.Forms.Label();
            this.Divendres = new System.Windows.Forms.Label();
            this.Dijous = new System.Windows.Forms.Label();
            this.Dimecres = new System.Windows.Forms.Label();
            this.Dimarts = new System.Windows.Forms.Label();
            this.Dilluns = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Controls.Add(this.Setmana);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 673);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Hora
            // 
            this.Hora.BackColor = System.Drawing.Color.White;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(0, 46);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(1254, 26);
            this.Hora.TabIndex = 4;
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setmana
            // 
            this.Setmana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145)))));
            this.Setmana.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setmana.ForeColor = System.Drawing.Color.White;
            this.Setmana.Location = new System.Drawing.Point(0, 0);
            this.Setmana.Name = "Setmana";
            this.Setmana.Size = new System.Drawing.Size(1257, 45);
            this.Setmana.TabIndex = 3;
            this.Setmana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(128)))), ((int)(((byte)(151)))));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Dissabte, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.Divendres, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dijous, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dimecres, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dimarts, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dilluns, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 591);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(5, 524);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 63);
            this.label11.TabIndex = 15;
            this.label11.Text = "18:30\r\n20:00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dissabte
            // 
            this.Dissabte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dissabte.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dissabte.ForeColor = System.Drawing.Color.White;
            this.Dissabte.Location = new System.Drawing.Point(1074, 2);
            this.Dissabte.Name = "Dissabte";
            this.Dissabte.Size = new System.Drawing.Size(170, 63);
            this.Dissabte.TabIndex = 6;
            this.Dissabte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Divendres
            // 
            this.Divendres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Divendres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divendres.ForeColor = System.Drawing.Color.White;
            this.Divendres.Location = new System.Drawing.Point(895, 2);
            this.Divendres.Name = "Divendres";
            this.Divendres.Size = new System.Drawing.Size(170, 63);
            this.Divendres.TabIndex = 5;
            this.Divendres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dijous
            // 
            this.Dijous.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dijous.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dijous.ForeColor = System.Drawing.Color.White;
            this.Dijous.Location = new System.Drawing.Point(717, 2);
            this.Dijous.Name = "Dijous";
            this.Dijous.Size = new System.Drawing.Size(170, 63);
            this.Dijous.TabIndex = 4;
            this.Dijous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dimecres
            // 
            this.Dimecres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dimecres.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dimecres.ForeColor = System.Drawing.Color.White;
            this.Dimecres.Location = new System.Drawing.Point(539, 2);
            this.Dimecres.Name = "Dimecres";
            this.Dimecres.Size = new System.Drawing.Size(170, 63);
            this.Dimecres.TabIndex = 3;
            this.Dimecres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dimarts
            // 
            this.Dimarts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dimarts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dimarts.ForeColor = System.Drawing.Color.White;
            this.Dimarts.Location = new System.Drawing.Point(361, 2);
            this.Dimarts.Name = "Dimarts";
            this.Dimarts.Size = new System.Drawing.Size(170, 63);
            this.Dimarts.TabIndex = 2;
            this.Dimarts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dilluns
            // 
            this.Dilluns.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Dilluns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dilluns.ForeColor = System.Drawing.Color.White;
            this.Dilluns.Location = new System.Drawing.Point(183, 2);
            this.Dilluns.Name = "Dilluns";
            this.Dilluns.Size = new System.Drawing.Size(170, 63);
            this.Dilluns.TabIndex = 0;
            this.Dilluns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 63);
            this.label4.TabIndex = 8;
            this.label4.Text = "Horaris";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 63);
            this.label6.TabIndex = 10;
            this.label6.Text = "17:00\r\n18:30";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 63);
            this.label5.TabIndex = 9;
            this.label5.Text = "15:30\r\n17:00";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 63);
            this.label3.TabIndex = 7;
            this.label3.Text = "14:00\r\n15:30";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 63);
            this.label7.TabIndex = 11;
            this.label7.Text = "11:00\r\n12:30";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 63);
            this.label8.TabIndex = 12;
            this.label8.Text = "12:30\r\n14:00";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 63);
            this.label9.TabIndex = 13;
            this.label9.Text = "8:00\n9:30";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 63);
            this.label10.TabIndex = 14;
            this.label10.Text = "9:30\r\n11:00";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Setmana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Dilluns;
        private System.Windows.Forms.Label Dissabte;
        private System.Windows.Forms.Label Divendres;
        private System.Windows.Forms.Label Dijous;
        private System.Windows.Forms.Label Dimecres;
        private System.Windows.Forms.Label Dimarts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Hora;
    }
}

