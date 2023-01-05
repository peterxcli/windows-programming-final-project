using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using life_assistant.controller.exercise_recorder;
using MaterialSkin.Controls;

namespace life_assistant.controller;

public partial class exerciseRecorderMainForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    Add_form form1 = new Add_form();
    string DataFilePath = "./data/exercise-recorder-listview.json";
    int last_day = 0;
    int number_of_items = 0;
    int have_done = 0;
    int maxnum = 0;

    public exerciseRecorderMainForm()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        if (!Directory.Exists(Path.GetDirectoryName(DataFilePath)))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath));
        }
        if (File.Exists(DataFilePath))
        {
            StreamReader sr = new StreamReader(DataFilePath);

            string line = sr.ReadLine();
            while (line != null)
            {
                //  Console.WriteLine(line);
                int subitem = 0;
                int lastspace = 0;
                string[] s = new string[4];
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        s[subitem] = line.Substring(lastspace, i - lastspace);
                        lastspace = i + 1;
                        subitem++;


                    }
                }
                s[subitem] = line.Substring(lastspace, line.Length - lastspace);


                ListViewItem lvi = new ListViewItem((number_of_items++).ToString());
                lvi.SubItems.Add(s[0]);
                lvi.SubItems.Add(s[1]);
                lvi.SubItems.Add(s[2]);
                lvi.SubItems.Add(s[3]);
                if (s[2] != null)
                    have_done += int.Parse(s[2]);

                label2.Text = have_done.ToString();
                listView1.Items.Add(lvi);
                string month = s[0].Substring(0, 2);
                string date = s[0].Substring(2, 2);

                DateTime dt = new DateTime(2023, int.Parse(month), int.Parse(date));

                if (dt.DayOfYear > last_day)
                {
                    last_day = dt.DayOfYear;
                }

                line = sr.ReadLine();
            }
            sr.Close();
            maxnum = number_of_items;

            MessageBox.Show("You haven't exercise for " + (DateTime.Now.DayOfYear - last_day).ToString() + " Days!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            if (DateTime.Now.DayOfYear - last_day >= 3)
            {
                MessageBox.Show("GO TO EXERCISE!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void materialButton1_Click(object sender, EventArgs e)
    {
        form1.ShowDialog();
        if (form1.textBox1.Text != "" && form1.textBox2.Text != "" && form1.textBox3.Text != "" && form1.textBox4.Text != "")
        {

            maxnum++;
            number_of_items++;


            ListViewItem lvi = new ListViewItem((maxnum).ToString());
            lvi.SubItems.Add(form1.textBox1.Text);
            lvi.SubItems.Add(form1.textBox2.Text);
            lvi.SubItems.Add(form1.textBox3.Text);
            lvi.SubItems.Add(form1.textBox4.Text);
            have_done += int.Parse(form1.textBox3.Text);
            label2.Text = have_done.ToString();
            listView1.Items.Add(lvi);



            string month = form1.textBox1.Text.Substring(0, 2);
            string date = form1.textBox1.Text.Substring(2, 2);

            DateTime dt = new DateTime(2023, int.Parse(month), int.Parse(date));

            if (dt.DayOfYear > last_day)
            {
                last_day = dt.DayOfYear;

            }



        }
    }

    private void exercise_recorder_Load(object sender, EventArgs e)
    {
        listView1.GridLines = true;

    }

    private void materialButton2_Click(object sender, EventArgs e)
    {

        label1.Text = textBox1.Text;
        textBox1.Text = string.Empty;
    }

    private void materialButton3_Click(object sender, EventArgs e)
    {



        for (int i = 0; i < number_of_items; i++)
        {

            if (listView1.Items[i].Text == textBox2.Text)
            {

                have_done -= int.Parse(listView1.Items[i].SubItems[3].Text);
                label2.Text = have_done.ToString();
                listView1.Items.RemoveAt(i);
                number_of_items--;
                break;
            }

        }
        textBox2.Text = string.Empty;
    }

    private void materialButton4_Click(object sender, EventArgs e)
    {


        StreamWriter sw = new StreamWriter(DataFilePath);
        for (int i = 0; i < number_of_items; i++)
        {
            for (int j = 1; j <= 3; j++)
            {
                sw.Write(listView1.Items[i].SubItems[j].Text);
                sw.Write(" ");
            }
            sw.WriteLine(listView1.Items[i].SubItems[4].Text);
        }
        sw.Close();


    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
