namespace _9
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(688, 176);
            button1.Name = "button1";
            button1.Size = new Size(179, 57);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(331, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(331, 579);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(721, 579);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 39);
            textBox3.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(331, 284);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 228);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 146);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 5;
            label1.Text = "Factorial de un número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 586);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 6;
            label2.Text = "Factorial de un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(622, 586);
            label3.Name = "label3";
            label3.Size = new Size(37, 32);
            label3.TabIndex = 7;
            label3.Text = "es";
            // 
            // button2
            // 
            button2.Location = new Point(681, 260);
            button2.Name = "button2";
            button2.Size = new Size(197, 85);
            button2.TabIndex = 8;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 753);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
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
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}