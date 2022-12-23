using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace life_assistant
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 father)
        {
            InitializeComponent();
            form1 = father;
        }

        void Update()
        {
            listBox1.Items.Clear();
            foreach (var item in form1.shop)
            {
                listBox1.Items.Add(item);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string target = textbar.Text;
            textbar.Text = "";

            form1.shop.Add(target);
            Update();
            textbar.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string target=textbar.Text;
            textbar.Text = "";
            bool find = false;
            foreach (var i in form1.shop)
            {
                if(i==target) {
                    find=true;
                    break;
                }
            }
            if (find)
            {
                if (MessageBox.Show("Do you want do remove " + target, "Remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    form1.shop.Remove(target);
                    Update();
                }
            }
            else
            {
                if(listBox1.SelectedIndex > -1){
                    if(MessageBox.Show("Do you want do remove "+ listBox1.SelectedItem ,"Remove",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid name");
                }
                
            }
            textbar.Focus();
        }
    }
}
