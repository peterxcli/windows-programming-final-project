using System;
using MaterialSkin.Controls;
using MaterialSkin;

namespace spending_tracker.Forms;


public partial class ManageCategoriesForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    private Classes.ExpenseManager _manager;
    private bool _isEditingCategory = false;
    private string _categoryEditing = "";
    public ManageCategoriesForm(Classes.ExpenseManager manager)
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        life_assistant.Classes.MaterialThemeManager materialThemeManager = new life_assistant.Classes.MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        _manager = manager;
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
        foreach (var item in _manager.Categories)
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

        if (_manager.CategoryNameExists(userInput))
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
            _manager.TryGetCategoryId(_categoryEditing, out Guid categoryId);
            _manager.RenameCategory(categoryId, textBoxNewCategory.Text);
        }
        else
        {
            _manager.AddCategory(userInput);
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
            _manager.TryGetCategoryId(listBoxCategories.SelectedItem.ToString(), out Guid categoryId);
            _manager.RemoveCategory(categoryId);
            PopulateListBoxCategories();
        }
    }
}