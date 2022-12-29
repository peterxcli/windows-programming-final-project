using System;
using MaterialSkin.Controls;
using MaterialSkin;
using life_assistant.model;

namespace life_assistant.controller.spending_tracker;


public partial class ManageCategoriesForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    private ExpenseManagerModel expenseManagerModel;
    private bool _isEditingCategory = false;
    private string _categoryEditing = "";
    public ManageCategoriesForm(ExpenseManagerModel _expenseManagerModel)
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        this.expenseManagerModel = _expenseManagerModel;
    }
    private void ResetAllControls()
    {
        _categoryEditing = "";
        _isEditingCategory = false;
        buttonAddEditCategory.Enabled = false;
        listBoxCategories.Enabled = true;
        textBoxNewCategory.Clear();
        buttonAddEditCategory.Text = "Add new category";
    }
    private void SetButtonEdit()
    {
        buttonAddEditCategory.Text = "Edit category name";
        _isEditingCategory = true;
    }
    private void PopulateListBoxCategories()
    {
        listBoxCategories.Items.Clear();
        foreach (var item in expenseManagerModel.Categories)
        {
            if (item.Value == "No category")
                continue;
            MaterialListBoxItem materialListBoxItem = new MaterialListBoxItem(item.Value);
            listBoxCategories.Items.Add(materialListBoxItem);
        }
    }
    private void ManageCategoriesForm_Load(object sender, EventArgs e)
    {
        PopulateListBoxCategories();
    }
    private void buttonAddEditCategory_Click(object sender, EventArgs e)
    {
        string userInput = textBoxNewCategory.Text;

        if (string.IsNullOrWhiteSpace(userInput))
        {
            MessageBox.Show("Category name is invalid.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return;
        }

        if (expenseManagerModel.CategoryNameExists(userInput))
        {
            MessageBox.Show("Category name is already in use.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return;
        }

        if (_isEditingCategory)
        {
            expenseManagerModel.TryGetCategoryId(_categoryEditing, out Guid categoryId);
            expenseManagerModel.RenameCategory(categoryId, textBoxNewCategory.Text);
        }
        else
        {
            expenseManagerModel.AddCategory(userInput);
        }
        ResetAllControls();
        PopulateListBoxCategories();
    }
    private void textBoxNewCategory_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxNewCategory.Text))
        {
            buttonAddEditCategory.Enabled = false;
        }
        else buttonAddEditCategory.Enabled = true;
    }
    private void editToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listBoxCategories.SelectedItem == null) return;
        _categoryEditing = listBoxCategories.SelectedItem.Text.ToString();
        listBoxCategories.Enabled = false;
        SetButtonEdit();
        textBoxNewCategory.Text = listBoxCategories.SelectedItem.Text.ToString();
    }
    private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (DialogResult.Yes == MessageBox.Show($"Are you sure that you want to delete {listBoxCategories.SelectedItem}?",
            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
        {
            expenseManagerModel.TryGetCategoryId(listBoxCategories.SelectedItem.ToString(), out Guid categoryId);
            expenseManagerModel.RemoveCategory(categoryId);
            PopulateListBoxCategories();
        }
    }
}