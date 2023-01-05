namespace life_assistant.controller.study_schedule;

partial class Add_plan
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
            this.textBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.textBox3 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.button1 = new MaterialSkin.Controls.MaterialButton();
            this.button2 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AnimateReadOnly = false;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Depth = 0;
            this.textBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.Hint = "Date";
            this.textBox1.LeadingIcon = null;
            this.textBox1.Location = new System.Drawing.Point(142, 87);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 50;
            this.textBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 50);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "";
            this.textBox1.TrailingIcon = null;
            // 
            // textBox2
            // 
            this.textBox2.AnimateReadOnly = false;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Depth = 0;
            this.textBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox2.Hint = "Subject";
            this.textBox2.LeadingIcon = null;
            this.textBox2.Location = new System.Drawing.Point(373, 87);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 50;
            this.textBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 50);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "";
            this.textBox2.TrailingIcon = null;
            // 
            // textBox3
            // 
            this.textBox3.AllowPromptAsInput = true;
            this.textBox3.AnimateReadOnly = false;
            this.textBox3.AsciiOnly = false;
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox3.BeepOnError = false;
            this.textBox3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBox3.Depth = 0;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox3.HidePromptOnLeave = false;
            this.textBox3.HideSelection = true;
            this.textBox3.Hint = "Plan";
            this.textBox3.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.textBox3.LeadingIcon = null;
            this.textBox3.Location = new System.Drawing.Point(40, 201);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Mask = "";
            this.textBox3.MaxLength = 32767;
            this.textBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.PrefixSuffixText = null;
            this.textBox3.PromptChar = '_';
            this.textBox3.ReadOnly = false;
            this.textBox3.RejectInputOnFirstFailure = false;
            this.textBox3.ResetOnPrompt = true;
            this.textBox3.ResetOnSpace = true;
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.ShortcutsEnabled = true;
            this.textBox3.Size = new System.Drawing.Size(577, 48);
            this.textBox3.SkipLiterals = true;
            this.textBox3.TabIndex = 6;
            this.textBox3.TabStop = false;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox3.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBox3.TrailingIcon = null;
            this.textBox3.UseSystemPasswordChar = false;
            this.textBox3.ValidatingType = null;
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button1.Depth = 0;
            this.button1.HighEmphasis = true;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(398, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
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
            this.button2.Location = new System.Drawing.Point(148, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button2.Size = new System.Drawing.Size(64, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button2.UseAccentColor = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 372);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_plan";
            this.Padding = new System.Windows.Forms.Padding(2, 53, 2, 2);
            this.Text = "Add_plan";
            this.Load += new System.EventHandler(this.Add_plan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private MaterialSkin.Controls.MaterialButton button1;
    private MaterialSkin.Controls.MaterialButton button2;
    public MaterialSkin.Controls.MaterialTextBox textBox1;
    public MaterialSkin.Controls.MaterialTextBox textBox2;
    public MaterialSkin.Controls.MaterialMaskedTextBox textBox3;
}