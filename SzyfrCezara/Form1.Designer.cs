namespace SzyfrCezara
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
            this.szyfrowanie_button = new System.Windows.Forms.Button();
            this.deszyfrowanie_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.do_zaszyfrowania = new System.Windows.Forms.TextBox();
            this.klucz_txt = new System.Windows.Forms.TextBox();
            this.wynik_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // szyfrowanie_button
            // 
            this.szyfrowanie_button.Location = new System.Drawing.Point(329, 359);
            this.szyfrowanie_button.Name = "szyfrowanie_button";
            this.szyfrowanie_button.Size = new System.Drawing.Size(91, 65);
            this.szyfrowanie_button.TabIndex = 0;
            this.szyfrowanie_button.Text = "Szyfruj";
            this.szyfrowanie_button.UseVisualStyleBackColor = true;
            this.szyfrowanie_button.Click += new System.EventHandler(this.szyfrowanie_button_Click);
            // 
            // deszyfrowanie_button
            // 
            this.deszyfrowanie_button.Location = new System.Drawing.Point(450, 359);
            this.deszyfrowanie_button.Name = "deszyfrowanie_button";
            this.deszyfrowanie_button.Size = new System.Drawing.Size(91, 65);
            this.deszyfrowanie_button.TabIndex = 1;
            this.deszyfrowanie_button.Text = "Deszyfruj";
            this.deszyfrowanie_button.UseVisualStyleBackColor = true;
            this.deszyfrowanie_button.Click += new System.EventHandler(this.deszyfrowanie_button_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klucz szyfrowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zaszyfrowany/Odszyfrowany tekst";
            // 
            // do_zaszyfrowania
            // 
            this.do_zaszyfrowania.Location = new System.Drawing.Point(34, 74);
            this.do_zaszyfrowania.Name = "do_zaszyfrowania";
            this.do_zaszyfrowania.Size = new System.Drawing.Size(399, 26);
            this.do_zaszyfrowania.TabIndex = 5;
            // 
            // klucz_txt
            // 
            this.klucz_txt.Location = new System.Drawing.Point(34, 155);
            this.klucz_txt.Name = "klucz_txt";
            this.klucz_txt.Size = new System.Drawing.Size(399, 26);
            this.klucz_txt.TabIndex = 6;
            // 
            // wynik_txt
            // 
            this.wynik_txt.Location = new System.Drawing.Point(34, 245);
            this.wynik_txt.Name = "wynik_txt";
            this.wynik_txt.Size = new System.Drawing.Size(399, 26);
            this.wynik_txt.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.wynik_txt);
            this.Controls.Add(this.klucz_txt);
            this.Controls.Add(this.do_zaszyfrowania);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deszyfrowanie_button);
            this.Controls.Add(this.szyfrowanie_button);
            this.Name = "Form1";
            this.Text = "Szyfr Cezara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button szyfrowanie_button;
        private System.Windows.Forms.Button deszyfrowanie_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox do_zaszyfrowania;
        private System.Windows.Forms.TextBox klucz_txt;
        private System.Windows.Forms.TextBox wynik_txt;
    }
}

