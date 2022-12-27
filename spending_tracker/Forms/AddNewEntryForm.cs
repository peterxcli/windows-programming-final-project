﻿using MaterialSkin.Controls;
using MaterialSkin;
using spending_tracker.Classes;

namespace spending_tracker.Forms;

public partial class AddNewEntryForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    Classes.ExpenseManager _manager;
    public AddNewEntryForm(Classes.ExpenseManager manager)
    {
        _manager = manager;
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        // materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        // materialSkinManager.ColorScheme = new ColorScheme(
        //            Primary.Cyan700,
        //            Primary.Cyan900,
        //            Primary.Cyan500,
        //            Accent.DeepOrange200,
        //            TextShade.WHITE);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }

    private void AddNewEntryForm_Load(object sender, EventArgs e)
    {
        // Initially populate the comboBoxCategories
        comboBoxCategories.Items.AddRange(_manager.Categories.Values.ToArray());
        comboBoxCategories.SelectedIndex = 0;
    }

    private void buttonAddNewEntry_Click(object sender, EventArgs e)
    {
        string title = textBoxTitle.Text;
        string description = textBoxDescription.Text;
        string value = textBoxValue.Text;
        decimal parsedValue;

        if (string.IsNullOrEmpty(value))
        {
            MessageBox.Show("Value is a required field!\nPlease fill out the field first.",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            return;
        }

        if (!decimal.TryParse(value, out parsedValue))
        {
            MessageBox.Show("Value must be a number!\nPlease try again.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            return;
        }

        if (comboBoxCategories.SelectedIndex == 0)
        {
            DialogResult result = MessageBox.Show("You are about to save the entry with no category.\nAre you sure?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
        }

        Guid categoryId;
        _manager.TryGetCategoryId(comboBoxCategories.SelectedItem.ToString(), out categoryId);
        Classes.Entry entry = new(title, description, parsedValue);
        entry.CategoryId = categoryId;
        entry.IsIncome = radioButtonIncome.Checked;
        _manager.AddEntry(entry);
        Close();
    }
}