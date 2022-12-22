namespace life_assistant.spending_tracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
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
            this.labelFilter = new System.Windows.Forms.Label();
            this.checkBoxFilterDateTime = new System.Windows.Forms.CheckBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonIncome = new System.Windows.Forms.RadioButton();
            this.radioButtonExpenses = new System.Windows.Forms.RadioButton();
            this.labelFilterByCategory = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.contextMenuStripEntry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDescriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelVisibleSummary = new System.Windows.Forms.Label();
            this.btnAddRecord = new MaterialSkin.Controls.MaterialButton();
            this.labelFilterFrom = new MaterialSkin.Controls.MaterialLabel();
            this.labelFilterTo = new MaterialSkin.Controls.MaterialLabel();
            this.labelFilterByType = new MaterialSkin.Controls.MaterialLabel();
            this.listViewEntries = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderValue = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDate = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderCategory = new System.Windows.Forms.ColumnHeader();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.categoriesMenu,
            this.moreMenu,
            this.aboutMenu});
            this.menuStrip.Location = new System.Drawing.Point(3, 64);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsFileMenuItem,
            this.openMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(38, 20);
            this.fileMenu.Text = "File";
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveAsFileMenuItem.Text = "Save as";
            this.saveAsFileMenuItem.Click += new System.EventHandler(this.saveAsFileMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // categoriesMenu
            // 
            this.categoriesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCategoriesMenuItem});
            this.categoriesMenu.Name = "categoriesMenu";
            this.categoriesMenu.Size = new System.Drawing.Size(80, 20);
            this.categoriesMenu.Text = "Categories";
            // 
            // manageCategoriesMenuItem
            // 
            this.manageCategoriesMenuItem.Name = "manageCategoriesMenuItem";
            this.manageCategoriesMenuItem.Size = new System.Drawing.Size(122, 22);
            this.manageCategoriesMenuItem.Text = "Manage";
            this.manageCategoriesMenuItem.Click += new System.EventHandler(this.manageCategoriesMenuItem_Click);
            // 
            // moreMenu
            // 
            this.moreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportMoreMenuItem,
            this.optionsMoreMenuItem});
            this.moreMenu.Name = "moreMenu";
            this.moreMenu.Size = new System.Drawing.Size(50, 20);
            this.moreMenu.Text = "More";
            // 
            // exportMoreMenuItem
            // 
            this.exportMoreMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportAsCsvMoreMenuItem});
            this.exportMoreMenuItem.Name = "exportMoreMenuItem";
            this.exportMoreMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exportMoreMenuItem.Text = "Export";
            // 
            // exportAsCsvMoreMenuItem
            // 
            this.exportAsCsvMoreMenuItem.Name = "exportAsCsvMoreMenuItem";
            this.exportAsCsvMoreMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportAsCsvMoreMenuItem.Text = "As .csv";
            this.exportAsCsvMoreMenuItem.Click += new System.EventHandler(this.exportAsCsvMoreMenuItem_Click);
            // 
            // optionsMoreMenuItem
            // 
            this.optionsMoreMenuItem.Name = "optionsMoreMenuItem";
            this.optionsMoreMenuItem.Size = new System.Drawing.Size(119, 22);
            this.optionsMoreMenuItem.Text = "Options";
            this.optionsMoreMenuItem.Click += new System.EventHandler(this.optionsMoreMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(54, 20);
            this.aboutMenu.Text = "About";
            this.aboutMenu.Click += new System.EventHandler(this.aboutMenu_Click);
            // 
            // filterFromDateTime
            // 
            this.filterFromDateTime.Enabled = false;
            this.filterFromDateTime.Location = new System.Drawing.Point(523, 183);
            this.filterFromDateTime.Name = "filterFromDateTime";
            this.filterFromDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterFromDateTime.TabIndex = 0;
            this.filterFromDateTime.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.filterFromDateTime.ValueChanged += new System.EventHandler(this.filterFromDateTime_ValueChanged);
            // 
            // filterToDateTime
            // 
            this.filterToDateTime.Enabled = false;
            this.filterToDateTime.Location = new System.Drawing.Point(523, 240);
            this.filterToDateTime.Name = "filterToDateTime";
            this.filterToDateTime.Size = new System.Drawing.Size(222, 23);
            this.filterToDateTime.TabIndex = 2;
            this.filterToDateTime.Value = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.filterToDateTime.ValueChanged += new System.EventHandler(this.filterToDateTime_ValueChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilter.Location = new System.Drawing.Point(526, 96);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(52, 21);
            this.labelFilter.TabIndex = 5;
            this.labelFilter.Text = "Filters";
            // 
            // checkBoxFilterDateTime
            // 
            this.checkBoxFilterDateTime.AutoSize = true;
            this.checkBoxFilterDateTime.Location = new System.Drawing.Point(526, 129);
            this.checkBoxFilterDateTime.Name = "checkBoxFilterDateTime";
            this.checkBoxFilterDateTime.Size = new System.Drawing.Size(121, 19);
            this.checkBoxFilterDateTime.TabIndex = 6;
            this.checkBoxFilterDateTime.Text = "Filter date range.";
            this.checkBoxFilterDateTime.UseVisualStyleBackColor = true;
            this.checkBoxFilterDateTime.CheckedChanged += new System.EventHandler(this.checkBoxFilterDateTime_CheckedChanged);
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(527, 312);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(39, 19);
            this.radioButtonAll.TabIndex = 7;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonIncome
            // 
            this.radioButtonIncome.AutoSize = true;
            this.radioButtonIncome.Location = new System.Drawing.Point(572, 312);
            this.radioButtonIncome.Name = "radioButtonIncome";
            this.radioButtonIncome.Size = new System.Drawing.Size(67, 19);
            this.radioButtonIncome.TabIndex = 8;
            this.radioButtonIncome.Text = "Income";
            this.radioButtonIncome.UseVisualStyleBackColor = true;
            this.radioButtonIncome.CheckedChanged += new System.EventHandler(this.radioButtonIncome_CheckedChanged);
            // 
            // radioButtonExpenses
            // 
            this.radioButtonExpenses.AutoSize = true;
            this.radioButtonExpenses.Location = new System.Drawing.Point(643, 312);
            this.radioButtonExpenses.Name = "radioButtonExpenses";
            this.radioButtonExpenses.Size = new System.Drawing.Size(77, 19);
            this.radioButtonExpenses.TabIndex = 9;
            this.radioButtonExpenses.Text = "Expenses";
            this.radioButtonExpenses.UseVisualStyleBackColor = true;
            this.radioButtonExpenses.CheckedChanged += new System.EventHandler(this.radioButtonExpenses_CheckedChanged);
            // 
            // labelFilterByCategory
            // 
            this.labelFilterByCategory.AutoSize = true;
            this.labelFilterByCategory.Location = new System.Drawing.Point(525, 344);
            this.labelFilterByCategory.Name = "labelFilterByCategory";
            this.labelFilterByCategory.Size = new System.Drawing.Size(107, 15);
            this.labelFilterByCategory.TabIndex = 11;
            this.labelFilterByCategory.Text = "Filter by category:";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(525, 362);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(217, 23);
            this.comboBoxCategories.TabIndex = 12;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // contextMenuStripEntry
            // 
            this.contextMenuStripEntry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDescriptionMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripEntry.Name = "contextMenuStripEntry";
            this.contextMenuStripEntry.Size = new System.Drawing.Size(172, 70);
            this.contextMenuStripEntry.Text = "Entry Context Menu";
            this.contextMenuStripEntry.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEntry_Opening);
            // 
            // showDescriptionMenuItem
            // 
            this.showDescriptionMenuItem.Name = "showDescriptionMenuItem";
            this.showDescriptionMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showDescriptionMenuItem.Text = "Show description";
            this.showDescriptionMenuItem.Click += new System.EventHandler(this.showDescriptionMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Location = new System.Drawing.Point(9, 488);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(63, 15);
            this.labelSummary.TabIndex = 16;
            this.labelSummary.Text = "Summary:";
            // 
            // labelVisibleSummary
            // 
            this.labelVisibleSummary.AutoSize = true;
            this.labelVisibleSummary.Location = new System.Drawing.Point(9, 505);
            this.labelVisibleSummary.Name = "labelVisibleSummary";
            this.labelVisibleSummary.Size = new System.Drawing.Size(106, 15);
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
            this.btnAddRecord.Location = new System.Drawing.Point(526, 416);
            this.btnAddRecord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddRecord.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddRecord.Size = new System.Drawing.Size(219, 64);
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
            this.labelFilterFrom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterFrom.Location = new System.Drawing.Point(523, 161);
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
            this.labelFilterTo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelFilterTo.Location = new System.Drawing.Point(523, 218);
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
            this.labelFilterByType.Location = new System.Drawing.Point(526, 290);
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
            this.columnHeaderCategory});
            this.listViewEntries.Depth = 0;
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.GridLines = true;
            this.listViewEntries.Location = new System.Drawing.Point(28, 106);
            this.listViewEntries.MinimumSize = new System.Drawing.Size(200, 100);
            this.listViewEntries.MouseLocation = new System.Drawing.Point(-1, -1);
            this.listViewEntries.MouseState = MaterialSkin.MouseState.OUT;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.OwnerDraw = true;
            this.listViewEntries.Size = new System.Drawing.Size(475, 374);
            this.listViewEntries.TabIndex = 15;
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 100;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 100;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 620);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.labelFilterByType);
            this.Controls.Add(this.labelFilterTo);
            this.Controls.Add(this.labelFilterFrom);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.labelVisibleSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.labelFilterByCategory);
            this.Controls.Add(this.radioButtonExpenses);
            this.Controls.Add(this.radioButtonIncome);
            this.Controls.Add(this.radioButtonAll);
            this.Controls.Add(this.checkBoxFilterDateTime);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.filterToDateTime);
            this.Controls.Add(this.filterFromDateTime);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Spending Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripEntry.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem saveAsFileMenuItem;
        private ToolStripMenuItem categoriesMenu;
        private ToolStripMenuItem manageCategoriesMenuItem;
        private ToolStripMenuItem moreMenu;
        private ToolStripMenuItem exportMoreMenuItem;
        private ToolStripMenuItem optionsMoreMenuItem;
        private DateTimePicker filterFromDateTime;
        private DateTimePicker filterToDateTime;
        private Label labelFilter;
        private CheckBox checkBoxFilterDateTime;
        private RadioButton radioButtonAll;
        private RadioButton radioButtonIncome;
        private RadioButton radioButtonExpenses;
        private Label labelFilterByCategory;
        private ComboBox comboBoxCategories;
        private ContextMenuStrip contextMenuStripEntry;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem openMenuItem;
        private Label labelSummary;
        private Label labelVisibleSummary;
        private ToolStripMenuItem showDescriptionMenuItem;
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
    }
}