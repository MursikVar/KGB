namespace Лабораторная_работа_1
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
            btnClickThis = new Button();
            lblHelloWorld = new Label();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            button6 = new Button();
            label4 = new Label();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnClickThis
            // 
            btnClickThis.Location = new Point(152, 30);
            btnClickThis.Name = "btnClickThis";
            btnClickThis.Size = new Size(75, 23);
            btnClickThis.TabIndex = 0;
            btnClickThis.Text = "ClickThis";
            btnClickThis.UseVisualStyleBackColor = true;
            btnClickThis.Click += btnClickThis_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(168, 56);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(38, 15);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(233, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Show";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(248, 56);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Result";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(438, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Leave += textBox1_Leave;
            // 
            // button2
            // 
            button2.Location = new Point(414, 64);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 5;
            button2.Text = "Ввод матрицы 1 …";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(414, 93);
            button3.Name = "button3";
            button3.Size = new Size(124, 23);
            button3.TabIndex = 6;
            button3.Text = "Ввод матрицы 2 …";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(414, 122);
            button4.Name = "button4";
            button4.Size = new Size(238, 23);
            button4.TabIndex = 7;
            button4.Text = "Результат";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 38);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 9;
            label2.Text = "n = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(544, 68);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // button6
            // 
            button6.Location = new Point(414, 151);
            button6.Name = "button6";
            button6.Size = new Size(238, 23);
            button6.TabIndex = 12;
            button6.Text = "Сохранить в файле “Res_Matr.txt” ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(544, 97);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // button5
            // 
            button5.Location = new Point(414, 180);
            button5.Name = "button5";
            button5.Size = new Size(238, 23);
            button5.TabIndex = 14;
            button5.Text = "Сложение Матриц";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.Location = new Point(414, 209);
            button7.Name = "button7";
            button7.Size = new Size(238, 23);
            button7.TabIndex = 15;
            button7.Text = "Разность Матриц";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(414, 338);
            button8.Name = "button8";
            button8.Size = new Size(227, 23);
            button8.TabIndex = 16;
            button8.Text = "Умножение Вектора на константу";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(414, 282);
            button9.Name = "button9";
            button9.Size = new Size(124, 23);
            button9.TabIndex = 17;
            button9.Text = "Ввод вектора";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(414, 309);
            button10.Name = "button10";
            button10.Size = new Size(124, 23);
            button10.TabIndex = 18;
            button10.Text = "Ввод константы";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(544, 286);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 19;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 313);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 20;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(label4);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblHelloWorld);
            Controls.Add(btnClickThis);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Произведение Матриц";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClickThis;
        private Label lblHelloWorld;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private Label label3;
        private Button button6;
        private Label label4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label5;
        private Label label6;
    }
}
