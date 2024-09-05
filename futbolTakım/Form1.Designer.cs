namespace futbolTakım
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(85, 133);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "sırala";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(465, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(465, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(465, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(465, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(143, 27);
            textBox4.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Galatasaray", "Fenerbahçe", "Beşiktaş" });
            comboBox1.Location = new Point(62, 76);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(62, 203);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 204);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 79);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 7;
            label1.Text = "Takım Kaptanı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 137);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 8;
            label2.Text = "Top. Gol Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 198);
            label3.Name = "label3";
            label3.Size = new Size(135, 20);
            label3.TabIndex = 9;
            label3.Text = "Şampiyonluk Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(309, 251);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 10;
            label4.Text = "Türkiye Kupası Sayısı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}