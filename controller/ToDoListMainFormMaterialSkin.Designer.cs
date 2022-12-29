namespace life_assistant.controller;

partial class ToDoListMainFormMaterialSkin
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
            this.textbar = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // textbar
            // 
            this.textbar.AnimateReadOnly = false;
            this.textbar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbar.Depth = 0;
            this.textbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textbar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textbar.LeadingIcon = null;
            this.textbar.Location = new System.Drawing.Point(2, 602);
            this.textbar.Margin = new System.Windows.Forms.Padding(2);
            this.textbar.MaxLength = 50;
            this.textbar.MouseState = MaterialSkin.MouseState.OUT;
            this.textbar.Multiline = false;
            this.textbar.Name = "textbar";
            this.textbar.Size = new System.Drawing.Size(512, 50);
            this.textbar.TabIndex = 1;
            this.textbar.Text = "";
            this.textbar.TrailingIcon = null;
            this.textbar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbar_KeyDown);
            this.textbar.Hint = "add new task";
            // 
            // ToDoListMainFormMaterialSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(516, 654);
            this.Controls.Add(this.textbar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ToDoListMainFormMaterialSkin";
            this.Padding = new System.Windows.Forms.Padding(2, 41, 2, 2);
            this.ShowIcon = false;
            this.Text = "To Do List";
            this.ResumeLayout(false);

    }

    #endregion
    private MaterialSkin.Controls.MaterialTextBox textbar;
}
