using System.Xml.Xsl;
using MaterialSkin.Controls;
using MaterialSkin;

namespace spending_tracker.Forms;

public partial class OptionsForm : MaterialForm
{
    private Classes.ExpenseManager _manager;
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public OptionsForm(Classes.ExpenseManager manager)
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        life_assistant.Classes.MaterialThemeManager materialThemeManager = new life_assistant.Classes.MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        _manager = manager;
    }

    private void OptionsForm_Load(object sender, EventArgs e)
    {
        textBoxCurrency.Text = _manager.CurrencySign;
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

        _manager.CurrencySign = textBoxCurrency.Text;
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