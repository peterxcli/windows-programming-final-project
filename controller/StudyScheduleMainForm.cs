using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using life_assistant.controller.study_schedule;
using MaterialSkin.Controls;

namespace life_assistant.controller;

public partial class StudyScheduleMainForm : MaterialForm
{
    readonly MaterialSkin.MaterialSkinManager materialSkinManager;
    Add_problem A1 = new Add_problem();
    Add_plan form2 = new Add_plan();
    public int number_of_problems = 0;
    public int number_of_plans = 0;
    public int maxnumber_of_problems = 0;

    string[] DataFilePath = { "./Data/Study-Schedule1.json", "./Data/Study-Schedule2.json", "./Data/Study-Schedule3.json" };


    public StudyScheduleMainForm()
    {
        InitializeComponent();
        materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
        materialSkinManager.EnforceBackcolorOnAllComponents = true;
        materialSkinManager.AddFormToManage(this);
        MaterialThemeManager materialThemeManager = new MaterialThemeManager();
        materialThemeManager.setDefaultTheme(materialSkinManager);
        
        for (int i = 0; i < 3; i++)
        {
            if (!Directory.Exists(Path.GetDirectoryName(DataFilePath[i])))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(DataFilePath[i]));
            }
        }


        if (File.Exists(DataFilePath[0]))
        {
            StreamReader sr = new StreamReader(DataFilePath[0]);

            string line = sr.ReadLine();
            while (line != null)
            {
                //  Console.WriteLine(line);
                int subitem = 0;
                int lastspace = 0;
                string[] s = new string[2];
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


                ListViewItem lvi = new((number_of_problems++).ToString());

                lvi.SubItems.Add(s[0]);
                lvi.SubItems.Add(s[1]);
                listView1.Items.Add(lvi);
                line = sr.ReadLine();
            }
            sr.Close();
            maxnumber_of_problems = number_of_problems;

        }

        if (File.Exists(DataFilePath[1]))
        {
            StreamReader sr = new StreamReader(DataFilePath[1]);

            string line = sr.ReadLine();
            while (line != null)
            {
                //  Console.WriteLine(line);
                int subitem = 0;
                int lastspace = 0;
                string[] s = new string[3];
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


                ListViewItem lvi = new ListViewItem(s[0]);
                lvi.SubItems.Add(s[1]);
                lvi.SubItems.Add(s[2]);
                listView2.Items.Add(lvi);
                line = sr.ReadLine();
            }
            sr.Close();

        }

        if (File.Exists(DataFilePath[2]))
        {
            StreamReader sr = new StreamReader(DataFilePath[2]);

            string line = sr.ReadLine();
            int st = 0;
            while (line != null)
            {
                if (st == 0)
                {
                    hScrollBar0.Value = int.Parse(line);
                }
                else if (st == 1)
                {
                    hScrollBar1.Value = int.Parse(line);
                }
                else if (st == 2)
                {
                    hScrollBar2.Value = int.Parse(line);
                }
                else if (st == 3)
                {
                    hScrollBar3.Value = int.Parse(line);
                }
                else if (st == 4)
                {
                    hScrollBar4.Value = int.Parse(line);
                }
                else if (st == 5)
                {
                    hScrollBar5.Value = int.Parse(line);
                }
                else if (st == 6)
                {
                    hScrollBar6.Value = int.Parse(line);
                }



                line = sr.ReadLine();
                st++;
            }
            sr.Close();
            l3.Text = hScrollBar2.Value.ToString();
            l1.Text = hScrollBar0.Value.ToString();
            l2.Text = hScrollBar1.Value.ToString();
            l4.Text = hScrollBar3.Value.ToString();
            l6.Text = hScrollBar5.Value.ToString();
            l5.Text = hScrollBar4.Value.ToString();
            l7.Text = hScrollBar6.Value.ToString();
        }
    }

    private void study_schedule_Load(object sender, EventArgs e)
    {

    }



    private void materialButton1_Click(object sender, EventArgs e)
    {
        A1.ShowDialog();
        if (A1.textBox2.Text != "" && A1.textBox3.Text != "")
        {
            maxnumber_of_problems++;
            number_of_problems++;
            ListViewItem lvi = new ListViewItem((maxnumber_of_problems).ToString());
            lvi.SubItems.Add(A1.textBox3.Text);
            lvi.SubItems.Add(A1.textBox2.Text);
            listView1.Items.Add(lvi);
        }
    }







    private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
        l1.Text = hScrollBar0.Value.ToString();
    }

    private void hScrollBar6_Scroll(object sender, ScrollEventArgs e)
    {
        l3.Text = hScrollBar2.Value.ToString();
    }

    private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
    {
        l2.Text = hScrollBar1.Value.ToString();
    }

    private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
    {
        l4.Text = hScrollBar3.Value.ToString();
    }

    private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
    {
        l5.Text = hScrollBar4.Value.ToString();
    }

    private void hScrollBar5_Scroll(object sender, ScrollEventArgs e)
    {
        l6.Text = hScrollBar5.Value.ToString();
    }

    private void hScrollBar7_Scroll(object sender, ScrollEventArgs e)
    {
        l7.Text = hScrollBar6.Value.ToString();
    }

    private void study_schedule_Load_1(object sender, EventArgs e)
    {

    }

    private void l7_Click(object sender, EventArgs e)
    {

    }

    private void materialButton3_Click(object sender, EventArgs e)
    {
        form2.ShowDialog();
        if (form2.textBox2.Text != "" && form2.textBox3.Text != "" && form2.textBox1.Text != "")
        {

            ListViewItem lvi = new ListViewItem(form2.textBox1.Text);
            lvi.SubItems.Add(form2.textBox2.Text);
            lvi.SubItems.Add(form2.textBox3.Text);
            listView2.Items.Add(lvi);
            number_of_plans++;
        }
    }

    private void materialButton2_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < number_of_problems; i++)
        {

            if (listView1.Items[i].Text == textBox1.Text)
            {

                listView1.Items.RemoveAt(i);
                number_of_problems--;
                break;
            }

        }
        textBox1.Text = string.Empty;
    }

    private void materialButton4_Click(object sender, EventArgs e)
    {
        StreamWriter sw = new StreamWriter(DataFilePath[0]);
        for (int i = 0; i < number_of_problems; i++)
        {
            for (int j = 1; j <= 1; j++)
            {
                sw.Write(listView1.Items[i].SubItems[j].Text);
                sw.Write(" ");
            }
            sw.WriteLine(listView1.Items[i].SubItems[2].Text);
        }
        sw.Close();

        StreamWriter sw1 = new StreamWriter(DataFilePath[1]);
        for (int i = 0; i < number_of_plans; i++)
        {
            for (int j = 0; j <= 1; j++)
            {
                sw1.Write(listView2.Items[i].SubItems[j].Text);
                sw1.Write(" ");
            }
            sw1.WriteLine(listView2.Items[i].SubItems[2].Text);
        }
        sw1.Close();

        StreamWriter sw2 = new StreamWriter(DataFilePath[2]);
        sw2.WriteLine(hScrollBar0.Value.ToString());
        sw2.WriteLine(hScrollBar1.Value.ToString());
        sw2.WriteLine(hScrollBar2.Value.ToString());
        sw2.WriteLine(hScrollBar3.Value.ToString());
        sw2.WriteLine(hScrollBar4.Value.ToString());
        sw2.WriteLine(hScrollBar5.Value.ToString());
        sw2.WriteLine(hScrollBar6.Value.ToString());
        sw2.Close();

    }
}