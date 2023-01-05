namespace life_assistant.controller.random_lunch_helper;

partial class EditLunchListForm
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
            this.textbar = new MaterialSkin.Controls.MaterialTextBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.listBox1 = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // textbar
            // 
            this.textbar.AnimateReadOnly = false;
            this.textbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbar.Depth = 0;
            this.textbar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbar.LeadingIcon = null;
            this.textbar.Location = new System.Drawing.Point(29, 345);
            this.textbar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textbar.MaxLength = 50;
            this.textbar.MouseState = MaterialSkin.MouseState.OUT;
            this.textbar.Multiline = false;
            this.textbar.Name = "textbar";
            this.textbar.Size = new System.Drawing.Size(282, 50);
            this.textbar.TabIndex = 0;
            this.textbar.Text = "";
            this.textbar.TrailingIcon = null;
            this.textbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbar_KeyDown);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(328, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(71, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button1.UseAccentColor = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button2.Depth = 0;
            this.button2.HighEmphasis = true;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(412, 359);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(73, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderColor = System.Drawing.Color.LightGray;
            this.listBox1.Depth = 0;
            this.listBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.Location = new System.Drawing.Point(29, 73);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndex = -1;
            this.listBox1.SelectedItem = null;
            this.listBox1.Size = new System.Drawing.Size(425, 247);
            this.listBox1.TabIndex = 3;
            // 
            // EditLunchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 408);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditLunchListForm";
            this.Padding = new System.Windows.Forms.Padding(2, 32, 2, 2);
            this.Text = "Modify";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox textbar;
    private MaterialSkin.Controls.MaterialButton button1;
    private MaterialSkin.Controls.MaterialButton button2;
    private MaterialSkin.Controls.MaterialListBox listBox1;
}