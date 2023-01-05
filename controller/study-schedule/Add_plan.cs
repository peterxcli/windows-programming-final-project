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

namespace life_assistant.controller.study_schedule;

public partial class Add_plan : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public Add_plan()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {

        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = string.Empty;
        textBox3.Text = string.Empty;
        textBox2.Text = string.Empty;
        this.Close();

    }

    private void Add_plan_Load(object sender, EventArgs e)
    {
        textBox1.Text = string.Empty;
        textBox3.Text = string.Empty;
        textBox2.Text = string.Empty;
    }
}
