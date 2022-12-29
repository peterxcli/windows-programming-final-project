namespace life_assistant;

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
            this.label1 = new System.Windows.Forms.Label();
            this.CntBar = new System.Windows.Forms.Label();
            this.textbar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            // 
            // CntBar
            // 
            this.CntBar.AutoSize = true;
            this.CntBar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CntBar.Location = new System.Drawing.Point(625, 18);
            this.CntBar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CntBar.Name = "CntBar";
            this.CntBar.Size = new System.Drawing.Size(82, 91);
            this.CntBar.TabIndex = 0;
            this.CntBar.Text = "0";
            // 
            // textbar
            // 
            this.textbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textbar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbar.Location = new System.Drawing.Point(0, 970);
            this.textbar.Name = "textbar";
            this.textbar.Size = new System.Drawing.Size(802, 62);
            this.textbar.TabIndex = 1;
            this.textbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbar_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(802, 1032);
            this.Controls.Add(this.textbar);
            this.Controls.Add(this.CntBar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private Label CntBar;
    private TextBox textbar;
}
