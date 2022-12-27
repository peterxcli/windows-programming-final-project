namespace spending_tracker.Forms;

partial class OptionsForm
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
            this.textBoxCurrency = new MaterialSkin.Controls.MaterialTextBox();
            this.buttonApply = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.AnimateReadOnly = false;
            this.textBoxCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCurrency.Depth = 0;
            this.textBoxCurrency.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCurrency.Hint = "currency";
            this.textBoxCurrency.LeadingIcon = null;
            this.textBoxCurrency.Location = new System.Drawing.Point(7, 81);
            this.textBoxCurrency.MaxLength = 50;
            this.textBoxCurrency.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCurrency.Multiline = false;
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(240, 50);
            this.textBoxCurrency.TabIndex = 1;
            this.textBoxCurrency.Text = "";
            this.textBoxCurrency.TrailingIcon = null;
            this.textBoxCurrency.TextChanged += new System.EventHandler(this.textBoxCurrency_TextChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonApply.Depth = 0;
            this.buttonApply.HighEmphasis = true;
            this.buttonApply.Icon = null;
            this.buttonApply.Location = new System.Drawing.Point(7, 146);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonApply.Size = new System.Drawing.Size(67, 36);
            this.buttonApply.TabIndex = 2;
            this.buttonApply.Text = "Apply";
            this.buttonApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonApply.UseAccentColor = false;
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 191);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.textBoxCurrency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private MaterialSkin.Controls.MaterialTextBox textBoxCurrency;
    private MaterialSkin.Controls.MaterialButton buttonApply;
}