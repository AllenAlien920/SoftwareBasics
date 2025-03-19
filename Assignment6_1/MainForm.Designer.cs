namespace Assignment6_1;

partial class MainForm
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
        AddButton = new System.Windows.Forms.Button();
        DeleteButton = new System.Windows.Forms.Button();
        ModifyButton = new System.Windows.Forms.Button();
        SearchButton = new System.Windows.Forms.Button();
        dataGridViewOrders = new System.Windows.Forms.DataGridView();
        ButtonPanel = new System.Windows.Forms.TableLayoutPanel();
        textBox = new System.Windows.Forms.TextBox();
        SearchComboBox = new System.Windows.Forms.ComboBox();
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
        ButtonPanel.SuspendLayout();
        SuspendLayout();
        // 
        // AddButton
        // 
        AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
        AddButton.Location = new System.Drawing.Point(3, 3);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(173, 106);
        AddButton.TabIndex = 0;
        AddButton.Text = "Add";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += Add_Click;
        // 
        // DeleteButton
        // 
        DeleteButton.AutoSize = true;
        DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
        DeleteButton.Location = new System.Drawing.Point(3, 339);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(173, 108);
        DeleteButton.TabIndex = 1;
        DeleteButton.Text = "Delete";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += Delete_Click;
        // 
        // ModifyButton
        // 
        ModifyButton.Dock = System.Windows.Forms.DockStyle.Fill;
        ModifyButton.Location = new System.Drawing.Point(3, 115);
        ModifyButton.Name = "ModifyButton";
        ModifyButton.Size = new System.Drawing.Size(173, 106);
        ModifyButton.TabIndex = 2;
        ModifyButton.Text = "Modify";
        ModifyButton.UseVisualStyleBackColor = true;
        ModifyButton.Click += Modify_Click;
        // 
        // SearchButton
        // 
        SearchButton.AutoSize = true;
        SearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
        SearchButton.Location = new System.Drawing.Point(3, 227);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new System.Drawing.Size(173, 106);
        SearchButton.TabIndex = 3;
        SearchButton.Text = "Search";
        SearchButton.UseVisualStyleBackColor = true;
        SearchButton.Click += Search_Click;
        // 
        // dataGridViewOrders
        // 
        dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Right;
        dataGridViewOrders.Location = new System.Drawing.Point(346, 0);
        dataGridViewOrders.Name = "dataGridViewOrders";
        dataGridViewOrders.RowHeadersWidth = 51;
        dataGridViewOrders.Size = new System.Drawing.Size(454, 450);
        dataGridViewOrders.TabIndex = 5;
        dataGridViewOrders.Text = "dataGridView1";
        // 
        // ButtonPanel
        // 
        ButtonPanel.ColumnCount = 1;
        ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        ButtonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        ButtonPanel.Controls.Add(AddButton, 0, 0);
        ButtonPanel.Controls.Add(ModifyButton, 0, 1);
        ButtonPanel.Controls.Add(DeleteButton, 0, 3);
        ButtonPanel.Controls.Add(SearchButton, 0, 2);
        ButtonPanel.Dock = System.Windows.Forms.DockStyle.Left;
        ButtonPanel.Location = new System.Drawing.Point(0, 0);
        ButtonPanel.Name = "ButtonPanel";
        ButtonPanel.RowCount = 4;
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        ButtonPanel.Size = new System.Drawing.Size(179, 450);
        ButtonPanel.TabIndex = 4;
        // 
        // textBox
        // 
        textBox.Location = new System.Drawing.Point(182, 227);
        textBox.Name = "textBox";
        textBox.Size = new System.Drawing.Size(158, 27);
        textBox.TabIndex = 7;
        // 
        // SearchComboBox
        // 
        SearchComboBox.FormattingEnabled = true;
        SearchComboBox.Items.AddRange(new object[] { "Product", "Customer" });
        SearchComboBox.Location = new System.Drawing.Point(182, 115);
        SearchComboBox.Name = "SearchComboBox";
        SearchComboBox.Size = new System.Drawing.Size(158, 28);
        SearchComboBox.TabIndex = 6;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(SearchComboBox);
        Controls.Add(textBox);
        Controls.Add(dataGridViewOrders);
        Controls.Add(ButtonPanel);
        Location = new System.Drawing.Point(19, 19);
        Text = "Ordering Service";
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
        ButtonPanel.ResumeLayout(false);
        ButtonPanel.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ComboBox SearchComboBox;
    private System.Windows.Forms.TextBox textBox;

    private System.Windows.Forms.DataGridView dataGridViewOrders;

    private System.Windows.Forms.TableLayoutPanel ButtonPanel;

    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button ModifyButton;
    private System.Windows.Forms.Button SearchButton;

    #endregion
}