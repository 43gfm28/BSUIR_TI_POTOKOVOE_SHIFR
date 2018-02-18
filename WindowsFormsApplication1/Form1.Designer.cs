namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_lsfr1 = new System.Windows.Forms.TextBox();
            this.label_lsfr1 = new System.Windows.Forms.Label();
            this.button_shifr = new System.Windows.Forms.Button();
            this.label_lsfr2 = new System.Windows.Forms.Label();
            this.textBox_lsfr2 = new System.Windows.Forms.TextBox();
            this.label_lsfr3 = new System.Windows.Forms.Label();
            this.textBox_lsfr3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_lsfr1
            // 
            this.textBox_lsfr1.Location = new System.Drawing.Point(114, 6);
            this.textBox_lsfr1.Name = "textBox_lsfr1";
            this.textBox_lsfr1.Size = new System.Drawing.Size(198, 26);
            this.textBox_lsfr1.TabIndex = 0;
            this.textBox_lsfr1.Text = "1111111111111111111111111";
            this.textBox_lsfr1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lsfr1_KeyPress);
            // 
            // label_lsfr1
            // 
            this.label_lsfr1.AutoSize = true;
            this.label_lsfr1.Location = new System.Drawing.Point(12, 12);
            this.label_lsfr1.Name = "label_lsfr1";
            this.label_lsfr1.Size = new System.Drawing.Size(96, 20);
            this.label_lsfr1.TabIndex = 1;
            this.label_lsfr1.Text = " LSFR1(25):";
            // 
            // button_shifr
            // 
            this.button_shifr.Location = new System.Drawing.Point(180, 576);
            this.button_shifr.Name = "button_shifr";
            this.button_shifr.Size = new System.Drawing.Size(142, 45);
            this.button_shifr.TabIndex = 2;
            this.button_shifr.Text = "Зашифровать";
            this.button_shifr.UseVisualStyleBackColor = true;
            this.button_shifr.Click += new System.EventHandler(this.button_shifr_Click);
            // 
            // label_lsfr2
            // 
            this.label_lsfr2.AutoSize = true;
            this.label_lsfr2.Location = new System.Drawing.Point(12, 48);
            this.label_lsfr2.Name = "label_lsfr2";
            this.label_lsfr2.Size = new System.Drawing.Size(96, 20);
            this.label_lsfr2.TabIndex = 4;
            this.label_lsfr2.Text = " LSFR2(33):";
            // 
            // textBox_lsfr2
            // 
            this.textBox_lsfr2.Location = new System.Drawing.Point(114, 48);
            this.textBox_lsfr2.Name = "textBox_lsfr2";
            this.textBox_lsfr2.Size = new System.Drawing.Size(198, 26);
            this.textBox_lsfr2.TabIndex = 3;
            this.textBox_lsfr2.Text = "111111111111111111111111111111111";
            this.textBox_lsfr2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lsfr2_KeyPress);
            // 
            // label_lsfr3
            // 
            this.label_lsfr3.AutoSize = true;
            this.label_lsfr3.Location = new System.Drawing.Point(12, 86);
            this.label_lsfr3.Name = "label_lsfr3";
            this.label_lsfr3.Size = new System.Drawing.Size(96, 20);
            this.label_lsfr3.TabIndex = 6;
            this.label_lsfr3.Text = " LSFR3(23):";
            // 
            // textBox_lsfr3
            // 
            this.textBox_lsfr3.Location = new System.Drawing.Point(114, 86);
            this.textBox_lsfr3.Name = "textBox_lsfr3";
            this.textBox_lsfr3.Size = new System.Drawing.Size(198, 26);
            this.textBox_lsfr3.TabIndex = 5;
            this.textBox_lsfr3.Text = "11111111111111111111111";
            this.textBox_lsfr3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lsfr3_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Открыть файл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Открыть файл";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "LFSR1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Геффе:";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(405, 496);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 45);
            this.button6.TabIndex = 14;
            this.button6.Text = "Расшифровать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(405, 576);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 45);
            this.button7.TabIndex = 13;
            this.button7.Text = "Зашифровать";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(727, 496);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 45);
            this.button10.TabIndex = 18;
            this.button10.Text = "Расшифровать";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(727, 576);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(142, 45);
            this.button11.TabIndex = 17;
            this.button11.Text = "Зашифровать";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(789, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "RC4:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "1 2 3 4 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "RC4:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(506, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(456, 342);
            this.textBox2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 633);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_lsfr3);
            this.Controls.Add(this.textBox_lsfr3);
            this.Controls.Add(this.label_lsfr2);
            this.Controls.Add(this.textBox_lsfr2);
            this.Controls.Add(this.button_shifr);
            this.Controls.Add(this.label_lsfr1);
            this.Controls.Add(this.textBox_lsfr1);
            this.Name = "Form1";
            this.Text = "Потоковое Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_lsfr1;
        private System.Windows.Forms.Label label_lsfr1;
        private System.Windows.Forms.Button button_shifr;
        private System.Windows.Forms.Label label_lsfr2;
        private System.Windows.Forms.TextBox textBox_lsfr2;
        private System.Windows.Forms.Label label_lsfr3;
        private System.Windows.Forms.TextBox textBox_lsfr3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

