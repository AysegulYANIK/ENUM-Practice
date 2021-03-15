namespace EnumPractice
{
    partial class Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dosyaTipi = new System.Windows.Forms.Label();
            this.dosyaUzantisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Tipi";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dosya Uzantısı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "DÖNÜŞTÜR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dosyaTipi
            // 
            this.dosyaTipi.AutoSize = true;
            this.dosyaTipi.Location = new System.Drawing.Point(334, 33);
            this.dosyaTipi.Name = "dosyaTipi";
            this.dosyaTipi.Size = new System.Drawing.Size(57, 13);
            this.dosyaTipi.TabIndex = 5;
            this.dosyaTipi.Text = "Dosya Tipi";
            this.dosyaTipi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dosyaUzantisi
            // 
            this.dosyaUzantisi.AutoSize = true;
            this.dosyaUzantisi.Location = new System.Drawing.Point(334, 66);
            this.dosyaUzantisi.Name = "dosyaUzantisi";
            this.dosyaUzantisi.Size = new System.Drawing.Size(77, 13);
            this.dosyaUzantisi.TabIndex = 6;
            this.dosyaUzantisi.Text = "Dosya Uzantısı";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 162);
            this.Controls.Add(this.dosyaUzantisi);
            this.Controls.Add(this.dosyaTipi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form";
            this.Text = "ENUM TRANSLATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dosyaTipi;
        private System.Windows.Forms.Label dosyaUzantisi;
    }
}

