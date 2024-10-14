using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginPage1
{
    public partial class Form1 : Form
    {
        Double count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
                this.AcceptButton = btnLogin;
                txtPass.PasswordChar = '*';


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = "Abdul_Rehman";
            pass = "22011556-065";
            if ((txtUser.Text == user) && (txtPass.Text == pass))
            {
                MessageBox.Show("Welcome User");
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + "" + "tries left");
                txtPass.Clear();
                txtUser.Clear();
                txtUser.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";

            //txtPass.Text = string.Empty;
            txtPass.Clear();
            txtUser.Clear();
            txtUser.Focus();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
