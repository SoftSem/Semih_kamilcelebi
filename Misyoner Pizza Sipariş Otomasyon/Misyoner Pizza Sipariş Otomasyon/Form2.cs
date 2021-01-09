using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misyoner_Pizza_Sipariş_Otomasyon
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox3.Text);
            listBox3.Items.Add(maskedTextBox1.Text);
            listBox4.Items.Add(textBox2.Text);
            listBox5.Items.Add(comboBox1.Text);
            listBox6.Items.Add(comboBox2.Text);
            listBox7.Items.Add(comboBox3.Text);
            listBox8.Items.Add(label17.Text + " " + label18.Text + " " + label19.Text + " " + label20.Text + " " + label21.Text + " " + label22.Text + "" + label23.Text + " " + label24.Text + " " + label25.Text);
        }
    
     
    
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            label17.Text = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            label18.Text = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            label19.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            label20.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            label21.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            label22.Text = checkBox6.Text;
        }

        private void checkBox7_CheckedChanged_1(object sender, EventArgs e)
        {
            label23.Text = checkBox7.Text;
        }

        private void checkBox8_CheckedChanged_1(object sender, EventArgs e)
        {
            label24.Text = checkBox8.Text;
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {
            label25.Text = checkBox9.Text;
        }

       

        }
    }

