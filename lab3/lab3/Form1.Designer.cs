namespace lab3
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
            input1 = new Label();
            input2 = new Label();
            result = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            plus = new Button();
            minus = new Button();
            multiply = new Button();
            divided = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // input1
            // 
            input1.AutoSize = true;
            input1.Location = new Point(105, 100);
            input1.Name = "input1";
            input1.Size = new Size(41, 15);
            input1.TabIndex = 0;
            input1.Text = "input1";
            input1.Click += input1_Click;
            // 
            // input2
            // 
            input2.AutoSize = true;
            input2.Location = new Point(105, 135);
            input2.Name = "input2";
            input2.Size = new Size(41, 15);
            input2.TabIndex = 1;
            input2.Text = "input2";
            input2.Click += input2_Click;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Location = new Point(105, 277);
            result.Name = "result";
            result.Size = new Size(36, 15);
            result.TabIndex = 2;
            result.Text = "result";
            result.Click += result_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(179, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // plus
            // 
            plus.Location = new Point(97, 201);
            plus.Name = "plus";
            plus.Size = new Size(75, 23);
            plus.TabIndex = 6;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.Location = new Point(190, 201);
            minus.Name = "minus";
            minus.Size = new Size(75, 23);
            minus.TabIndex = 7;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(285, 201);
            multiply.Name = "multiply";
            multiply.Size = new Size(75, 23);
            multiply.TabIndex = 8;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divided
            // 
            divided.Location = new Point(381, 201);
            divided.Name = "divided";
            divided.Size = new Size(75, 23);
            divided.TabIndex = 9;
            divided.Text = "/";
            divided.UseVisualStyleBackColor = true;
            divided.Click += divided_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(538, 81);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 10;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(divided);
            Controls.Add(multiply);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(result);
            Controls.Add(input2);
            Controls.Add(input1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label input1;
        private Label input2;
        private Label result;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button plus;
        private Button minus;
        private Button multiply;
        private Button divided;
        private ListBox listBox1;
    }
}