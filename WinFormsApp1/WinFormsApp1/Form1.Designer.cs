namespace WinFormsApp1
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
            dzielnaTextBox = new TextBox();
            wynikTextBox = new TextBox();
            dzielnikTextBox = new TextBox();
            Oblicz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // dzielnaTextBox
            // 
            dzielnaTextBox.Location = new Point(67, 139);
            dzielnaTextBox.Name = "dzielnaTextBox";
            dzielnaTextBox.Size = new Size(125, 27);
            dzielnaTextBox.TabIndex = 0;
            // 
            // wynikTextBox
            // 
            wynikTextBox.Location = new Point(562, 139);
            wynikTextBox.Name = "wynikTextBox";
            wynikTextBox.Size = new Size(125, 27);
            wynikTextBox.TabIndex = 1;
            // 
            // dzielnikTextBox
            // 
            dzielnikTextBox.Location = new Point(312, 139);
            dzielnikTextBox.Name = "dzielnikTextBox";
            dzielnikTextBox.Size = new Size(125, 27);
            dzielnikTextBox.TabIndex = 2;
            // 
            // Oblicz
            // 
            Oblicz.Location = new Point(343, 307);
            Oblicz.Name = "Oblicz";
            Oblicz.Size = new Size(94, 29);
            Oblicz.TabIndex = 3;
            Oblicz.Text = "Oblicz";
            Oblicz.UseVisualStyleBackColor = true;
            Oblicz.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 116);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 4;
            label1.Text = "Dzielna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 116);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Dzielnik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(604, 116);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 6;
            label3.Text = "Wynik";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Oblicz);
            Controls.Add(dzielnikTextBox);
            Controls.Add(wynikTextBox);
            Controls.Add(dzielnaTextBox);
            Name = "Form1";
            Text = "Kalkulator dzielenia dwóch liczb";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dzielnaTextBox;
        private TextBox wynikTextBox;
        private TextBox dzielnikTextBox;
        private Button Oblicz;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
