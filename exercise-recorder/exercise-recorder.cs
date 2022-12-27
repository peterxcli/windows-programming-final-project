using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_assistant.exercise_recorder
{
    public partial class exercise_recorder : Form
    {
        Add_form  form1=new Add_form();
        int last_day=0;
        int number_of_items = 0;
        int have_done = 0;

        public exercise_recorder()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            form1.ShowDialog();
            if(form1.textBox1.Text!=""&& form1.textBox2.Text != "" && form1.textBox3.Text != "" && form1.textBox4.Text != "")
            {
                ListViewItem lvi = new ListViewItem((number_of_items++).ToString());
                lvi.SubItems.Add(form1.textBox1.Text);
                lvi.SubItems.Add(form1.textBox2.Text);
                lvi.SubItems.Add(form1.textBox3.Text);
                lvi.SubItems.Add(form1.textBox4.Text);
                have_done += int.Parse(form1.textBox3.Text);
                label2.Text=have_done.ToString();
            }
        }

        private void exercise_recorder_Load(object sender, EventArgs e)
        {
            listView1.GridLines= true;
            if (DateTime.Now.DayOfYear - last_day <= 3)
            {
                MessageBox.Show("GO TO EXERCISE!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(int.Parse(textBox2.Text));
        }
    }
}
