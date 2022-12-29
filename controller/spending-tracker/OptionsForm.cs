using System.Xml.Xsl;
using MaterialSkin.Controls;
using MaterialSkin;
using life_assistant.model;

namespace life_assistant.controller.spending_tracker;

public partial class OptionsForm : MaterialForm
{
    private ExpenseManagerModel expenseManagerModel;
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public OptionsForm(ExpenseManagerModel _expenseManagerModel)
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        expenseManagerModel = _expenseManagerModel;
    }

    private void OptionsForm_Load(object sender, EventArgs e)
    {
        textBoxCurrency.Text = expenseManagerModel.CurrencySign;
    }
    private void buttonApply_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBoxCurrency.Text))
        {
            MessageBox.Show("Currency cannot be empty.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return;
        }

        if (textBoxCurrency.Text.Length != 3 && textBoxCurrency.Text.Length != 1)
        {
            MessageBox.Show("Currency has to be in one of the following formats:" +
                " $, USD, €, EUR...",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            return;
        }

        expenseManagerModel.CurrencySign = textBoxCurrency.Text;
        this.Close();
    }

    private void textBoxCurrency_TextChanged(object sender, EventArgs e)
    {
        string text = textBoxCurrency.Text;
        textBoxCurrency.Text = text.ToUpper();
        textBoxCurrency.SelectionStart = textBoxCurrency.Text.Length;
        textBoxCurrency.SelectionLength = 0;
    }
}