namespace FinTrack.Views;

partial class FinancialTracker
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
        label1 = new Label();
        textBox1 = new TextBox();
        button1 = new Button();
        button2 = new Button();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15F);
        label1.Location = new Point(294, 147);
        label1.Name = "label1";
        label1.Size = new Size(186, 35);
        label1.TabIndex = 0;
        label1.Text = "Your Balance is:";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(294, 185);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(186, 27);
        textBox1.TabIndex = 1;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 14F);
        button1.Location = new Point(12, 338);
        button1.Name = "button1";
        button1.Size = new Size(194, 71);
        button1.TabIndex = 2;
        button1.Text = "Income";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 14F);
        button2.Location = new Point(594, 338);
        button2.Name = "button2";
        button2.Size = new Size(194, 71);
        button2.TabIndex = 3;
        button2.Text = "Expenses";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 13F);
        label2.Location = new Point(57, 305);
        label2.Name = "label2";
        label2.Size = new Size(104, 30);
        label2.TabIndex = 4;
        label2.Text = "See your:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 13F);
        label3.Location = new Point(643, 305);
        label3.Name = "label3";
        label3.Size = new Size(104, 30);
        label3.TabIndex = 5;
        label3.Text = "See your:";
        // 
        // FinancialTracker
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "FinancialTracker";
        Text = "Financial Tracker";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Button button1;
    private Button button2;
    private Label label2;
    private Label label3;
}
