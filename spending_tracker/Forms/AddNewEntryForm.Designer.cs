namespace spending_tracker.Forms;

partial class AddNewEntryForm
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
            this.textBoxTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.labelDescription = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.textBoxValue = new MaterialSkin.Controls.MaterialTextBox();
            this.comboBoxCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.buttonAddNewEntry = new MaterialSkin.Controls.MaterialButton();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.radioButtonExpenses = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonIncome = new MaterialSkin.Controls.MaterialRadioButton();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.AnimateReadOnly = false;
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTitle.Depth = 0;
            this.textBoxTitle.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxTitle.Hint = "Title";
            this.textBoxTitle.LeadingIcon = null;
            this.textBoxTitle.Location = new System.Drawing.Point(12, 92);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxTitle.Multiline = false;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(299, 50);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.Tag = "";
            this.textBoxTitle.Text = "";
            this.textBoxTitle.TrailingIcon = null;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Depth = 0;
            this.labelDescription.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelDescription.Location = new System.Drawing.Point(12, 150);
            this.labelDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(85, 19);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Depth = 0;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDescription.Hint = "Description";
            this.textBoxDescription.Location = new System.Drawing.Point(12, 168);
            this.textBoxDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(299, 83);
            this.textBoxDescription.TabIndex = 2;
            this.textBoxDescription.Text = "";
            // 
            // textBoxValue
            // 
            this.textBoxValue.AnimateReadOnly = false;
            this.textBoxValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxValue.Depth = 0;
            this.textBoxValue.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxValue.Hint = "* Value";
            this.textBoxValue.LeadingIcon = null;
            this.textBoxValue.Location = new System.Drawing.Point(12, 272);
            this.textBoxValue.MaxLength = 50;
            this.textBoxValue.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxValue.Multiline = false;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(299, 50);
            this.textBoxValue.TabIndex = 4;
            this.textBoxValue.Text = "";
            this.textBoxValue.TrailingIcon = null;
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.AutoResize = false;
            this.comboBoxCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxCategories.Depth = 0;
            this.comboBoxCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxCategories.DropDownHeight = 174;
            this.comboBoxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategories.DropDownWidth = 121;
            this.comboBoxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Hint = "* Select category";
            this.comboBoxCategories.IntegralHeight = false;
            this.comboBoxCategories.ItemHeight = 43;
            this.comboBoxCategories.Location = new System.Drawing.Point(12, 351);
            this.comboBoxCategories.MaxDropDownItems = 4;
            this.comboBoxCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(299, 49);
            this.comboBoxCategories.StartIndex = 0;
            this.comboBoxCategories.TabIndex = 14;
            // 
            // buttonAddNewEntry
            // 
            this.buttonAddNewEntry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNewEntry.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonAddNewEntry.Depth = 0;
            this.buttonAddNewEntry.HighEmphasis = true;
            this.buttonAddNewEntry.Icon = null;
            this.buttonAddNewEntry.Location = new System.Drawing.Point(12, 476);
            this.buttonAddNewEntry.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonAddNewEntry.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonAddNewEntry.Name = "buttonAddNewEntry";
            this.buttonAddNewEntry.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonAddNewEntry.Size = new System.Drawing.Size(64, 36);
            this.buttonAddNewEntry.TabIndex = 15;
            this.buttonAddNewEntry.Text = "Done";
            this.buttonAddNewEntry.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonAddNewEntry.UseAccentColor = false;
            this.buttonAddNewEntry.UseVisualStyleBackColor = true;
            this.buttonAddNewEntry.Click += new System.EventHandler(this.buttonAddNewEntry_Click);
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-250, 476);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(250, 120);
            this.materialDrawer1.TabIndex = 16;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // radioButtonExpenses
            // 
            this.radioButtonExpenses.AutoSize = true;
            this.radioButtonExpenses.Depth = 0;
            this.radioButtonExpenses.Location = new System.Drawing.Point(107, 416);
            this.radioButtonExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonExpenses.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonExpenses.Name = "radioButtonExpenses";
            this.radioButtonExpenses.Ripple = true;
            this.radioButtonExpenses.Size = new System.Drawing.Size(102, 37);
            this.radioButtonExpenses.TabIndex = 18;
            this.radioButtonExpenses.Text = "Expenses";
            this.radioButtonExpenses.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Checked = true;
            this.radioButtonIncome.Depth = 0;
            this.radioButtonIncome.Location = new System.Drawing.Point(14, 416);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonIncome.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonIncome.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Ripple = true;
            this.radioButtonIncome.Size = new System.Drawing.Size(87, 37);
            this.radioButtonIncome.TabIndex = 17;
            this.radioButtonIncome.TabStop = true;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            // 
            // AddNewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 538);
            this.Controls.Add(this.radioButtonExpenses);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.materialDrawer1);
            this.Controls.Add(this.buttonAddNewEntry);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewEntryForm";
            this.Text = "Add new record";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox textBoxTitle;
    private MaterialSkin.Controls.MaterialLabel labelDescription;
    private MaterialSkin.Controls.MaterialMultiLineTextBox textBoxDescription;
    private MaterialSkin.Controls.MaterialTextBox textBoxValue;
    private MaterialSkin.Controls.MaterialComboBox comboBoxCategories;
    private MaterialSkin.Controls.MaterialButton buttonAddNewEntry;
    private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
    private MaterialSkin.Controls.MaterialRadioButton radioButtonExpenses;
    private MaterialSkin.Controls.MaterialRadioButton radioButtonIncome;
}