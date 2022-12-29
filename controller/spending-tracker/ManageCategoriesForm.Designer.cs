namespace life_assistant.controller.spending_tracker;


partial class ManageCategoriesForm
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
            this.listBoxCategories = new MaterialSkin.Controls.MaterialListBox();
            this.contextMenuStripCategory = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.editToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.buttonAddEditCategory = new MaterialSkin.Controls.MaterialButton();
            this.textBoxNewCategory = new MaterialSkin.Controls.MaterialTextBox();
            this.contextMenuStripCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.BackColor = System.Drawing.Color.White;
            this.listBoxCategories.BorderColor = System.Drawing.Color.LightGray;
            this.listBoxCategories.ContextMenuStrip = this.contextMenuStripCategory;
            this.listBoxCategories.Depth = 0;
            this.listBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.listBoxCategories.Location = new System.Drawing.Point(12, 84);
            this.listBoxCategories.MouseState = MaterialSkin.MouseState.HOVER;
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.SelectedIndex = -1;
            this.listBoxCategories.SelectedItem = null;
            this.listBoxCategories.Size = new System.Drawing.Size(250, 352);
            this.listBoxCategories.TabIndex = 0;
            // 
            // contextMenuStripCategory
            // 
            this.contextMenuStripCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.contextMenuStripCategory.Depth = 0;
            this.contextMenuStripCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuStripCategory.Name = "contextMenuStrip1";
            this.contextMenuStripCategory.Size = new System.Drawing.Size(112, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // buttonAddEditCategory
            // 
            this.buttonAddEditCategory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddEditCategory.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddEditCategory.Depth = 0;
            this.buttonAddEditCategory.Enabled = false;
            this.buttonAddEditCategory.HighEmphasis = true;
            this.buttonAddEditCategory.Icon = null;
            this.buttonAddEditCategory.Location = new System.Drawing.Point(13, 522);
            this.buttonAddEditCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddEditCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddEditCategory.Name = "buttonAddEditCategory";
            this.buttonAddEditCategory.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddEditCategory.Size = new System.Drawing.Size(165, 36);
            this.buttonAddEditCategory.TabIndex = 1;
            this.buttonAddEditCategory.Text = "Add new category";
            this.buttonAddEditCategory.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddEditCategory.UseAccentColor = false;
            this.buttonAddEditCategory.UseVisualStyleBackColor = true;
            this.buttonAddEditCategory.Click += new System.EventHandler(this.buttonAddEditCategory_Click);
            // 
            // textBoxNewCategory
            // 
            this.textBoxNewCategory.AnimateReadOnly = false;
            this.textBoxNewCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewCategory.Depth = 0;
            this.textBoxNewCategory.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxNewCategory.Hint = "category";
            this.textBoxNewCategory.LeadingIcon = null;
            this.textBoxNewCategory.Location = new System.Drawing.Point(13, 463);
            this.textBoxNewCategory.MaxLength = 50;
            this.textBoxNewCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxNewCategory.Multiline = false;
            this.textBoxNewCategory.Name = "textBoxNewCategory";
            this.textBoxNewCategory.Size = new System.Drawing.Size(250, 50);
            this.textBoxNewCategory.TabIndex = 2;
            this.textBoxNewCategory.Text = "";
            this.textBoxNewCategory.TrailingIcon = null;
            this.textBoxNewCategory.TextChanged += new System.EventHandler(this.textBoxNewCategory_TextChanged);
            // 
            // ManageCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 583);
            this.Controls.Add(this.textBoxNewCategory);
            this.Controls.Add(this.buttonAddEditCategory);
            this.Controls.Add(this.listBoxCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageCategoriesForm";
            this.Text = "Manage categories";
            this.Load += new System.EventHandler(this.ManageCategoriesForm_Load);
            this.contextMenuStripCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialListBox listBoxCategories;
    private MaterialSkin.Controls.MaterialButton buttonAddEditCategory;
    private MaterialSkin.Controls.MaterialTextBox textBoxNewCategory;
    private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuStripCategory;
    private MaterialSkin.Controls.MaterialToolStripMenuItem editToolStripMenuItem;
    private MaterialSkin.Controls.MaterialToolStripMenuItem deleteToolStripMenuItem;
}