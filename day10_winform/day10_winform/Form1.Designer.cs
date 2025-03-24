namespace day10_winform
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
            question_text = new TextBox();
            solution_textbox = new TextBox();
            solution_label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(468, 47);
            button1.Name = "button1";
            button1.Size = new Size(162, 77);
            button1.TabIndex = 0;
            button1.Text = "คำนวณ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // question_text
            // 
            question_text.Font = new Font("Segoe UI", 20F);
            question_text.Location = new Point(43, 47);
            question_text.Multiline = true;
            question_text.Name = "question_text";
            question_text.Size = new Size(377, 71);
            question_text.TabIndex = 1;
            question_text.TextChanged += textBox1_TextChanged;
            // 
            // solution_textbox
            // 
            solution_textbox.Font = new Font("Segoe UI", 20F);
            solution_textbox.ForeColor = Color.Blue;
            solution_textbox.Location = new Point(43, 172);
            solution_textbox.Multiline = true;
            solution_textbox.Name = "solution_textbox";
            solution_textbox.Size = new Size(167, 71);
            solution_textbox.TabIndex = 2;
            solution_textbox.Text = "0";
            // 
            // solution_label
            // 
            solution_label.AutoSize = true;
            solution_label.BackColor = SystemColors.ButtonHighlight;
            solution_label.Font = new Font("Segoe UI", 20F);
            solution_label.ForeColor = Color.Red;
            solution_label.Location = new Point(382, 172);
            solution_label.Name = "solution_label";
            solution_label.Size = new Size(38, 46);
            solution_label.TabIndex = 3;
            solution_label.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(solution_label);
            Controls.Add(solution_textbox);
            Controls.Add(question_text);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox question_text;
        private TextBox solution_textbox;
        private Label solution_label;
    }
}
