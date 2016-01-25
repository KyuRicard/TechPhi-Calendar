namespace Schedule_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Assignatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Professor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Torn = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.NumberOfTurns = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Asg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Prof = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Torn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTurns)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assigntura";
            // 
            // Assignatura
            // 
            this.Assignatura.Location = new System.Drawing.Point(16, 29);
            this.Assignatura.Name = "Assignatura";
            this.Assignatura.Size = new System.Drawing.Size(220, 20);
            this.Assignatura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Professor";
            // 
            // Professor
            // 
            this.Professor.Location = new System.Drawing.Point(16, 68);
            this.Professor.Name = "Professor";
            this.Professor.Size = new System.Drawing.Size(220, 20);
            this.Professor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dia";
            // 
            // Dia
            // 
            this.Dia.FormattingEnabled = true;
            this.Dia.Items.AddRange(new object[] {
            "Dilluns",
            "Dimarts",
            "Dimecres",
            "Dijous",
            "Divendres",
            "Dissabte"});
            this.Dia.Location = new System.Drawing.Point(16, 107);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(220, 21);
            this.Dia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Torn";
            // 
            // Torn
            // 
            this.Torn.Location = new System.Drawing.Point(16, 147);
            this.Torn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Torn.Name = "Torn";
            this.Torn.Size = new System.Drawing.Size(220, 20);
            this.Torn.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Afegir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumberOfTurns
            // 
            this.NumberOfTurns.Location = new System.Drawing.Point(16, 186);
            this.NumberOfTurns.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumberOfTurns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumberOfTurns.Name = "NumberOfTurns";
            this.NumberOfTurns.Size = new System.Drawing.Size(220, 20);
            this.NumberOfTurns.TabIndex = 10;
            this.NumberOfTurns.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number of turns";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(280, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Assignatura";
            // 
            // Asg
            // 
            this.Asg.AutoSize = true;
            this.Asg.Location = new System.Drawing.Point(406, 32);
            this.Asg.Name = "Asg";
            this.Asg.Size = new System.Drawing.Size(41, 13);
            this.Asg.TabIndex = 14;
            this.Asg.Text = "Assig...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Professor";
            // 
            // Prof
            // 
            this.Prof.AutoSize = true;
            this.Prof.Location = new System.Drawing.Point(406, 71);
            this.Prof.Name = "Prof";
            this.Prof.Size = new System.Drawing.Size(32, 13);
            this.Prof.TabIndex = 16;
            this.Prof.Text = "Profe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dia";
            // 
            // Day
            // 
            this.Day.AutoSize = true;
            this.Day.Location = new System.Drawing.Point(406, 110);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(26, 13);
            this.Day.TabIndex = 18;
            this.Day.Text = "Day";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Hora";
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(406, 149);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(30, 13);
            this.Hour.TabIndex = 20;
            this.Hour.Text = "Hora";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Eliminar Seleccionada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 250);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Hour);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Prof);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Asg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfTurns);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Torn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Professor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Assignatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Schedule Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Torn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfTurns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Assignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Professor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Torn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown NumberOfTurns;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Asg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Prof;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Button button2;
    }
}

