namespace Assignment1_2;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        comboBox1 = new System.Windows.Forms.ComboBox();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(326, 202);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(120, 40);
        button1.TabIndex = 0;
        button1.Text = "Calculate\r\n";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
        comboBox1.Location = new System.Drawing.Point(326, 95);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(120, 28);
        comboBox1.TabIndex = 1;
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(72, 95);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(120, 27);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(569, 95);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(120, 27);
        textBox2.TabIndex = 3;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(326, 351);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(120, 23);
        label1.TabIndex = 4;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(label1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.Button button1;

    #endregion
}