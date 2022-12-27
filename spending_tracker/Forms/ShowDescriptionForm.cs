﻿using MaterialSkin.Controls;
using MaterialSkin;
using spending_tracker.Classes;

namespace spending_tracker.Forms;

public partial class ShowDescriptionForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    string _description;
    public ShowDescriptionForm(Classes.ExpenseManager manager, Guid id)
    {
        manager.TryFindEntry(id, out Classes.Entry entry);
        _description = entry.Description;
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }

    private void ShowDescriptionForm_Load(object sender, EventArgs e)
    {
        richTextBoxDescription.Text = String.IsNullOrEmpty(_description) ?
            "No description available." : _description;
        richTextBoxDescription.Text = _description;
    }
}