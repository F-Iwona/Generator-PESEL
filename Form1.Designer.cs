namespace Zadanie_2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Month = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kobieta = new System.Windows.Forms.RadioButton();
            this.Mezczyzna = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 30);
            this.label1.MinimumSize = new System.Drawing.Size(740, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj swoją datę urodzenia i płeć, aby\r\n\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Year.ForeColor = System.Drawing.SystemColors.Control;
            this.Year.Location = new System.Drawing.Point(40, 158);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(171, 39);
            this.Year.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(442, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Month.ForeColor = System.Drawing.SystemColors.Control;
            this.Month.Location = new System.Drawing.Point(241, 158);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(100, 39);
            this.Month.TabIndex = 3;
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(102)))));
            this.Day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Day.ForeColor = System.Drawing.SystemColors.Control;
            this.Day.Location = new System.Drawing.Point(367, 158);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(100, 39);
            this.Day.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(3, 308);
            this.label8.MinimumSize = new System.Drawing.Size(740, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(740, 32);
            this.label8.TabIndex = 5;
            this.label8.Text = "Twój wygenerowany numer PESEL to:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.MinimumSize = new System.Drawing.Size(740, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "wygenerować swój numer PESEL!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Kobieta
            // 
            this.Kobieta.AutoSize = true;
            this.Kobieta.Checked = true;
            this.Kobieta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Kobieta.Location = new System.Drawing.Point(527, 167);
            this.Kobieta.Name = "Kobieta";
            this.Kobieta.Size = new System.Drawing.Size(21, 20);
            this.Kobieta.TabIndex = 7;
            this.Kobieta.TabStop = true;
            this.Kobieta.UseVisualStyleBackColor = true;
            // 
            // Mezczyzna
            // 
            this.Mezczyzna.AutoSize = true;
            this.Mezczyzna.Location = new System.Drawing.Point(643, 167);
            this.Mezczyzna.Name = "Mezczyzna";
            this.Mezczyzna.Size = new System.Drawing.Size(21, 20);
            this.Mezczyzna.TabIndex = 8;
            this.Mezczyzna.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rok urodzenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(236, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Miesiąc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(362, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dzień:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(503, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kobieta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(605, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mężczyzna";
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Answer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer.Location = new System.Drawing.Point(29, 347);
            this.Answer.MinimumSize = new System.Drawing.Size(350, 100);
            this.Answer.Multiline = true;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Size = new System.Drawing.Size(718, 144);
            this.Answer.TabIndex = 14;
            this.Answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.Location = new System.Drawing.Point(184, 251);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 37);
            this.comboBox1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(163, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ilość numerów PESEL:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(746, 503);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mezczyzna);
            this.Controls.Add(this.Kobieta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator numeru PESEL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Month;
        private System.Windows.Forms.TextBox Day;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Kobieta;
        private System.Windows.Forms.RadioButton Mezczyzna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Answer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}

