namespace BMR
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Masa = new System.Windows.Forms.Label();
            this.Wzrost = new System.Windows.Forms.Label();
            this.Wiek = new System.Windows.Forms.Label();
            this.BMR = new System.Windows.Forms.Label();
            this.Oblicz = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(67, 283);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 38);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Masa
            // 
            this.Masa.AutoSize = true;
            this.Masa.Location = new System.Drawing.Point(64, 99);
            this.Masa.Name = "Masa";
            this.Masa.Size = new System.Drawing.Size(33, 13);
            this.Masa.TabIndex = 3;
            this.Masa.Text = "Masa";
            // 
            // Wzrost
            // 
            this.Wzrost.AutoSize = true;
            this.Wzrost.Location = new System.Drawing.Point(67, 179);
            this.Wzrost.Name = "Wzrost";
            this.Wzrost.Size = new System.Drawing.Size(40, 13);
            this.Wzrost.TabIndex = 4;
            this.Wzrost.Text = "Wzrost";
            // 
            // Wiek
            // 
            this.Wiek.AutoSize = true;
            this.Wiek.Location = new System.Drawing.Point(67, 264);
            this.Wiek.Name = "Wiek";
            this.Wiek.Size = new System.Drawing.Size(32, 13);
            this.Wiek.TabIndex = 5;
            this.Wiek.Text = "Wiek";
            // 
            // BMR
            // 
            this.BMR.AutoSize = true;
            this.BMR.Location = new System.Drawing.Point(356, 44);
            this.BMR.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.BMR.Name = "BMR";
            this.BMR.Size = new System.Drawing.Size(31, 13);
            this.BMR.TabIndex = 6;
            this.BMR.Text = "BMR";
            // 
            // Oblicz
            // 
            this.Oblicz.Location = new System.Drawing.Point(429, 198);
            this.Oblicz.Name = "Oblicz";
            this.Oblicz.Size = new System.Drawing.Size(156, 38);
            this.Oblicz.TabIndex = 7;
            this.Oblicz.Text = "Oblicz";
            this.Oblicz.UseVisualStyleBackColor = true;
            this.Oblicz.Click += new System.EventHandler(this.Oblicz_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(429, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Kobieta";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(429, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Mężczyzna";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Wyczyść";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Oblicz);
            this.Controls.Add(this.BMR);
            this.Controls.Add(this.Wiek);
            this.Controls.Add(this.Wzrost);
            this.Controls.Add(this.Masa);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Masa;
        private System.Windows.Forms.Label Wzrost;
        private System.Windows.Forms.Label Wiek;
        private System.Windows.Forms.Label BMR;
        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

