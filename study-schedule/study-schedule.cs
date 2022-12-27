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

namespace life_assistant.study_schedule
{
    public partial class study_schedule : Form
    {
        Add_problem A1= new Add_problem();
        public int number_of_problems = 0;


        public study_schedule()
        {
            InitializeComponent();
        }

        private void study_schedule_Load(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            A1.ShowDialog();
            if(A1.textBox2.Text!= ""&&A1.textBox3.Text!="") {

                ListViewItem lvi = new ListViewItem((number_of_problems++).ToString());
                lvi.SubItems.Add(A1.textBox3.Text);
                lvi.SubItems.Add(A1.textBox2.Text);       
            }
        }
    }
}
