namespace life_assistant.controller;

partial class SpendingTrackerMainForm
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
            this.menuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCategoriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exportMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsCsvMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMoreMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFromDateTime = new System.Windows.Forms.DateTimePicker();
            this.filterToDateTime = new System.Windows.Forms.DateTimePicker();
            this.labelFilter = new MaterialSkin.Controls.MaterialLabel();
            this.checkBoxFilterDateTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.radioButtonAll = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonIncome = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioButtonExpenses = new MaterialSkin.Controls.MaterialRadioButton();
            this.comboBoxCategories = new MaterialSkin.Controls.MaterialComboBox();
            this.contextMenuStripEntry = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.showDescriptionMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.editToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteToolStripMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.labelSummary = new MaterialSkin.Controls.MaterialLabel();
            this.labelVisibleSummary = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddRecord = new MaterialSkin.Controls.MaterialButton();
            this.labelFilterFrom = new MaterialSkin.Controls.MaterialLabel();
            this.labelFilterTo = new MaterialSkin.Controls.MaterialLabel();
            this.labelFilterByType = new MaterialSkin.Controls.MaterialLabel();
            this.listViewEntries = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValue = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCategory = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderType = new System.Windows.Forms.ColumnHeader();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuStrip.Depth = 0;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.categoriesMenu,
            this.moreMenu,
            this.aboutMenu});
            this.menuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(154, 100);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsFileMenuItem,
            this.openMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(153, 24);
            this.fileMenu.Text = "File";
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(144, 26);
            this.saveAsFileMenuItem.Text = "Save as";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.saveAsFileMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(144, 26);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // categoriesMenu
            // 
            this.categoriesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoriesMenuItem});
            this.categoriesMenu.Name = "categoriesMenu";
            this.categoriesMenu.Size = new System.Drawing.Size(153, 24);
            this.categoriesMenu.Text = "Categories";
            // 
            // manageCategoriesMenuItem
            // 
            this.manageCategoriesMenuItem.Name = "manageCategoriesMenuItem";
            this.manageCategoriesMenuItem.Size = new System.Drawing.Size(149, 26);
            this.manageCategoriesMenuItem.Text = "Manage";
            this.manageCategoriesMenuItem.Click += new System.EventHandler(this.manageCategoriesMenuItem_Click);
            // 
            // moreMenu
            // 
            this.moreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMoreMenuItem,
            this.optionsMoreMenuItem});
            this.moreMenu.Name = "moreMenu";
            this.moreMenu.Size = new System.Drawing.Size(153, 24);
            this.moreMenu.Text = "More";
            // 
            // exportMoreMenuItem
            // 
            this.exportMoreMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsCsvMoreMenuItem});
            this.exportMoreMenuItem.Name = "exportMoreMenuItem";
            this.exportMoreMenuItem.Size = new System.Drawing.Size(147, 26);
            this.exportMoreMenuItem.Text = "Export";
            // 
            // exportAsCsvMoreMenuItem
            // 
            this.exportAsCsvMoreMenuItem.Name = "exportAsCsvMoreMenuItem";
            this.exportAsCsvMoreMenuItem.Size = new System.Drawing.Size(138, 26);
            this.exportAsCsvMoreMenuItem.Text = "As .csv";
            this.exportAsCsvMoreMenuItem.Click += new System.EventHandler(this.exportAsCsvMoreMenuItem_Click);
            // 
            // optionsMoreMenuItem
            // 
            this.optionsMoreMenuItem.Name = "optionsMoreMenuItem";
            this.optionsMoreMenuItem.Size = new System.Drawing.Size(147, 26);
            this.optionsMoreMenuItem.Text = "Options";
            this.optionsMoreMenuItem.Click += new System.EventHandler(this.optionsMoreMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(153, 24);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // filterFromDateTime
            // 
            this.filterFromDateTime.Enabled = false;
            this.filterFromDateTime.Location = new System.Drawing.Point(829, 243);
            this.filterFromDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterFromDateTime.Name = "filterFromDateTime";
            this.filterFromDateTime.Size = new System.Drawing.Size(284, 27);
            this.filterFromDateTime.TabIndex = 0;
            this.filterFromDateTime.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.filterFromDateTime.ValueChanged += new System.EventHandler(this.filterFromDateTime_ValueChanged);
            // 
            // filterToDateTime
            // 
            this.filterToDateTime.Enabled = false;
            this.filterToDateTime.Location = new System.Drawing.Point(829, 315);
            this.filterToDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterToDateTime.Name = "filterToDateTime";
            this.filterToDateTime.Size = new System.Drawing.Size(284, 27);
            this.filterToDateTime.TabIndex = 2;
            this.filterToDateTime.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.filterToDateTime.ValueChanged += new System.EventHandler(this.filterToDateTime_ValueChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Depth = 0;
            this.labelFilter.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilter.Location = new System.Drawing.Point(810, 136);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(44, 19);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Filters";
            // 
            // checkBoxFilterDateTime
            // 
            this.checkBoxFilterDateTime.AutoSize = true;
            this.checkBoxFilterDateTime.Depth = 0;
            this.checkBoxFilterDateTime.Location = new System.Drawing.Point(814, 163);
            this.checkBoxFilterDateTime.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxFilterDateTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxFilterDateTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxFilterDateTime.Name = "checkBoxFilterDateTime";
            this.checkBoxFilterDateTime.ReadOnly = false;
            this.checkBoxFilterDateTime.Ripple = true;
            this.checkBoxFilterDateTime.Size = new System.Drawing.Size(153, 37);
            this.checkBoxFilterDateTime.TabIndex = 6;
            this.checkBoxFilterDateTime.Text = "Filter date range.";
            this.checkBoxFilterDateTime.UseVisualStyleBackColor = true;
            this.checkBoxFilterDateTime.CheckedChanged += new System.EventHandler(this.checkBoxFilterDateTime_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Depth = 0;
            this.radioButtonAll.Location = new System.Drawing.Point(815, 395);
            this.radioButtonAll.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonAll.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Ripple = true;
            this.radioButtonAll.Size = new System.Drawing.Size(53, 37);
            this.radioButtonAll.TabIndex = 7;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Depth = 0;
            this.radioButtonIncome.Location = new System.Drawing.Point(888, 395);
            this.radioButtonIncome.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonIncome.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonIncome.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Ripple = true;
            this.radioButtonIncome.Size = new System.Drawing.Size(87, 37);
            this.radioButtonIncome.TabIndex = 8;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonExpenses
            // 
            this.radioButtonExpenses.AutoSize = true;
            this.radioButtonExpenses.Depth = 0;
            this.radioButtonExpenses.Location = new System.Drawing.Point(1003, 395);
            this.radioButtonExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonExpenses.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioButtonExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioButtonExpenses.Name = "radioButtonExpenses";
            this.radioButtonExpenses.Ripple = true;
            this.radioButtonExpenses.Size = new System.Drawing.Size(102, 37);
            this.radioButtonExpenses.TabIndex = 9;
            this.radioButtonExpenses.Text = "Expenses";
            this.radioButtonExpenses.UseVisualStyleBackColor = true;
            this.radioButtonExpenses.CheckedChanged += new System.EventHandler(this.radioButtonExpenses_CheckedChanged);
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
            this.comboBoxCategories.Hint = "Filiter by category";
            this.comboBoxCategories.IntegralHeight = false;
            this.comboBoxCategories.ItemHeight = 43;
            this.comboBoxCategories.Location = new System.Drawing.Point(813, 466);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCategories.MaxDropDownItems = 4;
            this.comboBoxCategories.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(278, 49);
            this.comboBoxCategories.StartIndex = 0;
            this.comboBoxCategories.TabIndex = 12;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // contextMenuStripEntry
            // 
            this.contextMenuStripEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.contextMenuStripEntry.Depth = 0;
            this.contextMenuStripEntry.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDescriptionMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripEntry.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenuStripEntry.Name = "contextMenuStripEntry";
            this.contextMenuStripEntry.Size = new System.Drawing.Size(200, 70);
            this.contextMenuStripEntry.Text = "Entry Context Menu";
            this.contextMenuStripEntry.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEntry_Opening);
            // 
            // showDescriptionMenuItem
            // 
            this.showDescriptionMenuItem.AutoSize = false;
            this.showDescriptionMenuItem.Name = "showDescriptionMenuItem";
            this.showDescriptionMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showDescriptionMenuItem.Text = "Show description";
            this.showDescriptionMenuItem.Click += new System.EventHandler(this.showDescriptionMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.AutoSize = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.AutoSize = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Depth = 0;
            this.labelSummary.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelSummary.Location = new System.Drawing.Point(22, 657);
            this.labelSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(74, 19);
            this.labelSummary.TabIndex = 16;
            this.labelSummary.Text = "Summary:";
            // 
            // labelVisibleSummary
            // 
            this.labelVisibleSummary.AutoSize = true;
            this.labelVisibleSummary.Depth = 0;
            this.labelVisibleSummary.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelVisibleSummary.Location = new System.Drawing.Point(22, 690);
            this.labelVisibleSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVisibleSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelVisibleSummary.Name = "labelVisibleSummary";
            this.labelVisibleSummary.Size = new System.Drawing.Size(128, 19);
            this.labelVisibleSummary.TabIndex = 17;
            this.labelVisibleSummary.Text = "Filtered summary:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.AutoEllipsis = true;
            this.btnAddRecord.AutoSize = false;
            this.btnAddRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddRecord.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddRecord.Depth = 0;
            this.btnAddRecord.DrawShadows = false;
            this.btnAddRecord.HighEmphasis = true;
            this.btnAddRecord.Icon = null;
            this.btnAddRecord.Location = new System.Drawing.Point(814, 535);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnAddRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRecord.Size = new System.Drawing.Size(282, 81);
            this.btnAddRecord.TabIndex = 18;
            this.btnAddRecord.Text = "add record";
            this.btnAddRecord.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddRecord.UseAccentColor = false;
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // labelFilterFrom
            // 
            this.labelFilterFrom.AutoSize = true;
            this.labelFilterFrom.Depth = 0;
            this.labelFilterFrom.Enabled = false;
            this.labelFilterFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterFrom.Location = new System.Drawing.Point(829, 215);
            this.labelFilterFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterFrom.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilterFrom.Name = "labelFilterFrom";
            this.labelFilterFrom.Size = new System.Drawing.Size(82, 19);
            this.labelFilterFrom.TabIndex = 19;
            this.labelFilterFrom.Text = "Filiter from:";
            // 
            // labelFilterTo
            // 
            this.labelFilterTo.AutoSize = true;
            this.labelFilterTo.Depth = 0;
            this.labelFilterTo.Enabled = false;
            this.labelFilterTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterTo.Location = new System.Drawing.Point(829, 288);
            this.labelFilterTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilterTo.Name = "labelFilterTo";
            this.labelFilterTo.Size = new System.Drawing.Size(62, 19);
            this.labelFilterTo.TabIndex = 20;
            this.labelFilterTo.Text = "Filiter to:";
            // 
            // labelFilterByType
            // 
            this.labelFilterByType.AutoSize = true;
            this.labelFilterByType.Depth = 0;
            this.labelFilterByType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterByType.Location = new System.Drawing.Point(814, 367);
            this.labelFilterByType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterByType.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelFilterByType.Name = "labelFilterByType";
            this.labelFilterByType.Size = new System.Drawing.Size(99, 19);
            this.labelFilterByType.TabIndex = 21;
            this.labelFilterByType.Text = "Filiter by type:";
            // 
            // listViewEntries
            // 
            this.listViewEntries.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewEntries.AutoArrange = false;
            this.listViewEntries.AutoSizeTable = false;
            this.listViewEntries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listViewEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderValue,
            this.columnHeaderDate,
            this.columnHeaderCategory,
            this.columnHeaderType});
            this.listViewEntries.ContextMenuStrip = this.contextMenuStripEntry;
            this.listViewEntries.Depth = 0;
            this.listViewEntries.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.Location = new System.Drawing.Point(18, 149);
            this.listViewEntries.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewEntries.MinimumSize = new System.Drawing.Size(257, 127);
            this.listViewEntries.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewEntries.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.OwnerDraw = true;
            this.listViewEntries.ShowItemToolTips = true;
            this.listViewEntries.Size = new System.Drawing.Size(771, 486);
            this.listViewEntries.TabIndex = 15;
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 175;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 150;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 150;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 150;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 832);
            this.ContextMenuStrip = this.menuStrip;
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.labelFilterByType);
            this.Controls.Add(this.labelFilterTo);
            this.Controls.Add(this.labelFilterFrom);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.labelVisibleSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.radioButtonExpenses);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.checkBoxFilterDateTime);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.filterToDateTime);
            this.Controls.Add(this.filterFromDateTime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4, 81, 4, 4);
            this.Text = "Spending Manager";
            // this.FormClosed += (s, e) => MainForm_FormClosed(s, e);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.contextMenuStripEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MaterialSkin.Controls.MaterialContextMenuStrip menuStrip;
    private ToolStripMenuItem fileMenu;
    private ToolStripMenuItem saveAsFileMenuItem;
    private ToolStripMenuItem categoriesMenu;
    private ToolStripMenuItem manageCategoriesMenuItem;
    private ToolStripMenuItem moreMenu;
    private ToolStripMenuItem exportMoreMenuItem;
    private ToolStripMenuItem optionsMoreMenuItem;
    private DateTimePicker filterFromDateTime;
    private DateTimePicker filterToDateTime;
    private MaterialSkin.Controls.MaterialCheckbox checkBoxFilterDateTime;
    private MaterialSkin.Controls.MaterialRadioButton radioButtonAll;
    private MaterialSkin.Controls.MaterialRadioButton radioButtonIncome;
    private MaterialSkin.Controls.MaterialRadioButton radioButtonExpenses;
    private MaterialSkin.Controls.MaterialComboBox comboBoxCategories;
    private MaterialSkin.Controls.MaterialToolStripMenuItem editToolStripMenuItem;
    private MaterialSkin.Controls.MaterialToolStripMenuItem deleteToolStripMenuItem;
    private MaterialSkin.Controls.MaterialToolStripMenuItem showDescriptionMenuItem;
    private ToolStripMenuItem openMenuItem;
    private MaterialSkin.Controls.MaterialLabel labelSummary;
    private MaterialSkin.Controls.MaterialLabel labelVisibleSummary;

    private ToolStripMenuItem exportAsCsvMoreMenuItem;
    private ToolStripMenuItem aboutMenu;
    private MaterialSkin.Controls.MaterialButton btnAddRecord;
    private MaterialSkin.Controls.MaterialLabel labelFilterFrom;
    private MaterialSkin.Controls.MaterialLabel labelFilterTo;
    private MaterialSkin.Controls.MaterialLabel labelFilterByType;
    private MaterialSkin.Controls.MaterialListView listViewEntries;
    private ColumnHeader columnHeaderTitle;
    private ColumnHeader columnHeaderValue;
    private ColumnHeader columnHeaderDate;
    private ColumnHeader columnHeaderCategory;
    private MaterialSkin.Controls.MaterialLabel labelFilter;
    private MaterialSkin.Controls.MaterialContextMenuStrip contextMenuStripEntry;
    private ColumnHeader columnHeaderType;
}