using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace life_assistant.controller.exercise_recorder;

public partial class Add_form : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public Add_form()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text.Length != 4)
        {
            MessageBox.Show("格式不符!");
        }
        else
        {
            this.Close();
        }


    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox1.Text = "";
        textBox2.Text = string.Empty;
        textBox3.Text = string.Empty;
        textBox4.Text = string.Empty;
        this.Close();
    }

    private void Add_form_Load(object sender, EventArgs e)
    {
        textBox1.Text = "";
        textBox2.Text = string.Empty;
        textBox3.Text = string.Empty;
        textBox4.Text = string.Empty;
    }
}
