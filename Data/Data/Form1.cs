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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data
{
    public partial class Form1 : Form

    {
       // CanteenBAL obj = new CanteenBAL();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            this.Text = "Abdul_Rehman";
           

        }
      
        public void createnewrow()
        {
            if (dt.Rows.Count <= 0)
            {
                //DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn("Course Code", typeof(string));
            DataColumn dc2 = new DataColumn("Course Title", typeof(string));
            DataColumn dc3 = new DataColumn("Obtained Marks", typeof(string));
            DataColumn dc4 = new DataColumn("Grade", typeof(string));
            DataColumn dc5 = new DataColumn("Status", typeof(string));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            dt.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, comboBox3.Text);
            dataGridView1.DataSource = dt;
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox1.Focus();
            }
            else
            {

                dt.Rows.Add(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, comboBox3.Text);


                dataGridView1.DataSource = dt;
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();
                textBox1.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createnewrow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
       }
         

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            createnewrow();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
