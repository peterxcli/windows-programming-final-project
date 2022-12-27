namespace spending_tracker.Forms;

partial class ShowDescriptionForm
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
            this.richTextBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.richTextBoxDescription.Depth = 0;
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.HideSelection = true;
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 64);
            this.richTextBoxDescription.MaxLength = 32767;
            this.richTextBoxDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.SelectedText = "";
            this.richTextBoxDescription.SelectionLength = 0;
            this.richTextBoxDescription.SelectionStart = 0;
            this.richTextBoxDescription.ShortcutsEnabled = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(539, 461);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.TabStop = false;
            // 
            // ShowDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 528);
            this.Controls.Add(this.richTextBoxDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowDescriptionForm";
            this.Text = "Description";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ShowDescriptionForm_Load);
            this.ResumeLayout(false);

    }

    #endregion

    private MaterialSkin.Controls.MaterialMultiLineTextBox richTextBoxDescription;
}
