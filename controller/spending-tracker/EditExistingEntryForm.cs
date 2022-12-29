using MaterialSkin.Controls;
using MaterialSkin;
using life_assistant.model;

namespace life_assistant.controller.spending_tracker;

public partial class EditExistingEntryForm : MaterialForm
{
    ExpenseManagerModel expenseManagerModel;
    Guid _entryId;
    EntrySchema _editEntry;
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public EditExistingEntryForm(ExpenseManagerModel _expenseManagerModel, Guid entryId)
    {
        expenseManagerModel = _expenseManagerModel;
        _entryId = entryId;
        expenseManagerModel.TryFindEntry(_entryId, out _editEntry);
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }

    private void buttonEditExistingEntry_Click(object sender, EventArgs e)
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
        expenseManagerModel.TryGetCategoryId(comboBoxCategories.SelectedItem.ToString(), out categoryId);
        EntrySchema entry = new(_editEntry.Id, _editEntry.CreatedAt, title, description, parsedValue, categoryId);
        expenseManagerModel.RemoveEntry(_editEntry.Id);
        expenseManagerModel.AddEntry(entry);
        Close();
    }

    private void EditExistingEntryForm_Load(object sender, EventArgs e)
    {
        // Initially populate the comboBoxCategories
        comboBoxCategories.Items.AddRange(expenseManagerModel.Categories.Values.ToArray());
        expenseManagerModel.TryGetCategoryName(_editEntry.CategoryId, out string categoryName);
        for (int i = 0; i < comboBoxCategories.Items.Count; i++)
        {
            if (comboBoxCategories.Items[i].ToString() == categoryName)
            {
                comboBoxCategories.SelectedIndex = i;
                break;
            }
        }

        // Populate other fields by info from Entry
        textBoxTitle.Text = _editEntry.Title;
        textBoxDescription.Text = _editEntry.Description;
        textBoxValue.Text = _editEntry.Value.ToString();
        radioButtonIncome.Checked = _editEntry.IsIncome;
        radioButtonExpenses.Checked = !_editEntry.IsIncome;
    }

}