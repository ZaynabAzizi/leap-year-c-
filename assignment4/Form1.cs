using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 2000; i <= 2020; i++)
            {
                lstYear.Items.Add(i);
            }
        }

        private void lstYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstLeap.Items.Clear();
            for(int i=0; i<lstYear.Items.Count;i++)
            {
                
                if ( int.Parse(lstYear.Items[i].ToString()) % 4 ==0)
                {
                    lstLeap.Items.Add(lstYear.Items[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstYear.SelectedIndex != -1)
                textBox1.Text = lstYear.SelectedItem.ToString();
            else
                MessageBox.Show("You can't an unchecked value");
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if(lstYear.SelectedIndex != -1)
                textBox2.Text = lstYear.SelectedIndex.ToString();
            else
                MessageBox.Show("You can't display an index for an unchecked value");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lstYear.Items.Add(textBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lstYear.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lstYear.SelectedIndex != -1)
                lstYear.Items.RemoveAt(lstYear.SelectedIndex);
            else
                MessageBox.Show("You must select an item to remove");
        }

        

        private void button7_Click(object sender, EventArgs e)
        {
            int sum = 0;
            if (lstYear.Items.Count == 0)
                sum = 0;


            for(int i=0; i< lstYear.Items.Count; i++)
            {
                sum += int.Parse(lstYear.Items[i].ToString());
            }

            MessageBox.Show($"The Sum = {sum}");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            float average;
            int sum = 0;
            if (lstYear.Items.Count == 0)
                sum = 0;


            for (int i = 0; i < lstYear.Items.Count; i++)
            {
                sum += int.Parse(lstYear.Items[i].ToString());
            }

            if (lstYear.Items.Count == 0)
                average = 0;
            else
             average = sum / lstYear.Items.Count;

            MessageBox.Show($"The average = {average}");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            for(int i=0; i<lstLeap.Items.Count; i++)
            {
                if(dateTimePicker1.Value.Year==int.Parse(lstLeap.Items[i].ToString()))
                {
                    MessageBox.Show("It exists");
                }
               
            }
        }
    }
}
