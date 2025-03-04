namespace ödevdegisken
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(106, 241);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 32);
            label1.TabIndex = 3;
            label1.Text = "ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 174);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 4;
            label2.Text = "soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 241);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 5;
            label3.Text = "yaş:";
            // 
            // button1
            // 
            button1.Location = new Point(79, 310);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(399, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(302, 284);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
    }
}
