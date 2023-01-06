using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using life_assistant.controller;
using MaterialSkin.Controls;

namespace life_assistant.controller.random_lunch_helper;

public partial class EditLunchListForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    RandomLunchHelperMainForm randomLunchHelperMainForm;
    string DataFilePath = "./Data/Random-Lunch-Helper.json";

    public EditLunchListForm(RandomLunchHelperMainForm father)
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        randomLunchHelperMainForm = father;
    }

    void Update()
    {
        listBox1.Items.Clear();
        foreach (var item in randomLunchHelperMainForm.shop)
        {
            listBox1.Items.Add(new MaterialSkin.MaterialListBoxItem(item));
        }
        MessageBox.Show("Update");
        StreamWriter sw = new StreamWriter(DataFilePath);
        sw.WriteLine(JsonSerializer.Serialize(randomLunchHelperMainForm.shop));
        sw.Close();
        
    }
    private void Form2_Load(object sender, EventArgs e)
    {
        Update();
    }

    private void textbar_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            button1.Focus();
            button1_Click(sender, e);
            textbar.Focus();
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string target = textbar.Text;
        textbar.Text = "";
        if (target != "")
        {

            randomLunchHelperMainForm.shop.Add(target);
            Update();
        }
        else
        {
            MessageBox.Show("Can't be empty!");
        }
        // listBox1.TopIndex = listBox1.Items.Count - 1;
        textbar.Focus();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string target = textbar.Text;
        textbar.Text = "";

        bool find = false;
        foreach (var i in randomLunchHelperMainForm.shop)
        {
            if (i == target)
            {
                find = true;
                break;
            }
        }
        if (find)
        {
            if (MessageBox.Show("Do you want do remove " + target + "?", "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                randomLunchHelperMainForm.shop.Remove(target);
            }
        }
        else
        {
            if (listBox1.SelectedIndex > -1)
            {
                if (MessageBox.Show("Do you want do remove " + listBox1.SelectedItem.Text, "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    randomLunchHelperMainForm.shop.Remove(listBox1.SelectedItem.Text);
                }
            }
            else
            {
                if (target == "")
                {
                    MessageBox.Show("Can't be empty!");
                }
                else
                {
                    MessageBox.Show("Please enter valid name");
                }

            }

        }
        Update();
        textbar.Focus();
    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you want to delete all?", "Empty", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            randomLunchHelperMainForm.shop.Clear();
            Update();
        }
    }
}
