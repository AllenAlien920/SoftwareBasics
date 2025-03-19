using System.ComponentModel;

namespace Assignment6_1;

partial class OrderForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        Cancel = new System.Windows.Forms.Button();
        Save = new System.Windows.Forms.Button();
        dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).BeginInit();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(Cancel, 1, 0);
        tableLayoutPanel1.Controls.Add(Save, 0, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 234);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new System.Drawing.Size(462, 100);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // Cancel
        // 
        Cancel.Location = new System.Drawing.Point(234, 3);
        Cancel.Name = "Cancel";
        Cancel.Size = new System.Drawing.Size(225, 94);
        Cancel.TabIndex = 1;
        Cancel.Text = "Cancel";
        Cancel.UseVisualStyleBackColor = true;
        Cancel.Click += Cancel_Click;
        // 
        // Save
        // 
        Save.Location = new System.Drawing.Point(3, 3);
        Save.Name = "Save";
        Save.Size = new System.Drawing.Size(225, 94);
        Save.TabIndex = 0;
        Save.Text = "Save";
        Save.UseVisualStyleBackColor = true;
        Save.Click += Save_Click;
        // 
        // dataGridViewOrderDetails
        // 
        dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewOrderDetails.Dock = System.Windows.Forms.DockStyle.Top;
        dataGridViewOrderDetails.Location = new System.Drawing.Point(0, 0);
        dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
        dataGridViewOrderDetails.RowHeadersWidth = 51;
        dataGridViewOrderDetails.Size = new System.Drawing.Size(462, 231);
        dataGridViewOrderDetails.TabIndex = 1;
        dataGridViewOrderDetails.Text = "dataGridView1";
        // 
        // OrderForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(462, 334);
        Controls.Add(dataGridViewOrderDetails);
        Controls.Add(tableLayoutPanel1);
        Location = new System.Drawing.Point(19, 19);
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewOrderDetails).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridViewOrderDetails;

    private System.Windows.Forms.Button Save;

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

    private System.Windows.Forms.Button Cancel;

    #endregion
}