﻿using System;
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

                form1.shop.Add(target);
                Update();
            }
            else
            {
                MessageBox.Show("Can't be empty!");
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
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

            listBox1.TopIndex = listBox1.Items.Count - 1;
            textbar.Focus();
        }
    }
}