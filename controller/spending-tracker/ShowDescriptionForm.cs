using MaterialSkin.Controls;
using MaterialSkin;
using life_assistant.model;

namespace life_assistant.controller.spending_tracker;

public partial class ShowDescriptionForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    string _description;
    public ShowDescriptionForm(ExpenseManagerModel _expenseManagerModel, Guid id)
    {
        _expenseManagerModel.TryFindEntry(id, out EntrySchema entry);
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
