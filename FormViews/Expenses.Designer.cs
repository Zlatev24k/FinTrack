namespace FinTrack.Views
{
    partial class Expenses
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            listBox1 = new ListBox();
            tabPage2 = new TabPage();
            label2 = new Label();
            listBox2 = new ListBox();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            listBox3 = new ListBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            listBox4 = new ListBox();
            button4 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Expense";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(282, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 34);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(558, 318);
            button2.Name = "button2";
            button2.Size = new Size(226, 80);
            button2.TabIndex = 3;
            button2.Text = "Add Expense to Balance";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(558, 54);
            button1.Name = "button1";
            button1.Size = new Size(226, 77);
            button1.TabIndex = 2;
            button1.Text = "Add Type of Expense";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(6, 16);
            label1.Name = "label1";
            label1.Size = new Size(199, 35);
            label1.TabIndex = 1;
            label1.Text = "Type of Expense:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(6, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(254, 344);
            listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(listBox2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Your Expenses";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(295, 22);
            label2.Name = "label2";
            label2.Size = new Size(202, 40);
            label2.TabIndex = 1;
            label2.Text = "Your Expenses:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(206, 78);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(380, 324);
            listBox2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(listBox3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update Expense";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(listBox4);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete Expense";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 338);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 34);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(282, 47);
            label3.Name = "label3";
            label3.Size = new Size(254, 23);
            label3.TabIndex = 6;
            label3.Text = "Write name for type of Expense:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(282, 315);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 7;
            label4.Text = "Amount";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(8, 77);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(233, 324);
            listBox3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(8, 39);
            label5.Name = "label5";
            label5.Size = new Size(178, 35);
            label5.TabIndex = 1;
            label5.Text = "Your Expenses:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(368, 77);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(197, 34);
            textBox3.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(368, 39);
            label6.Name = "label6";
            label6.Size = new Size(166, 35);
            label6.TabIndex = 3;
            label6.Text = "New Amount:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(368, 147);
            button3.Name = "button3";
            button3.Size = new Size(197, 60);
            button3.TabIndex = 4;
            button3.Text = "Update Amount";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(8, 47);
            label7.Name = "label7";
            label7.Size = new Size(178, 35);
            label7.TabIndex = 2;
            label7.Text = "Your Expenses:";
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(8, 85);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(233, 324);
            listBox4.TabIndex = 3;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(264, 85);
            button4.Name = "button4";
            button4.Size = new Size(197, 60);
            button4.TabIndex = 5;
            button4.Text = "Delete Amount";
            button4.UseVisualStyleBackColor = true;
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Expenses";
            Text = "Expenses";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label2;
        private ListBox listBox2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private ListBox listBox3;
        private Label label6;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private ListBox listBox4;
        private Label label7;
    }
}