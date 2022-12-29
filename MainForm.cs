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
using MaterialSkin;
using life_assistant.controller;

namespace life_assistant;

public partial class MainForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    public MainForm()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
    }
    private void MainForm_FormClosed(object s, EventArgs e) {
        Application.Exit();
    }

    private void buttonSpendingTracker_Click(object sender, EventArgs e)
    {
        SpendingTrackerMainForm main = new SpendingTrackerMainForm();
        main.ShowDialog();
    }


}
