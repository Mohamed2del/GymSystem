using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class loginform : Form
    {
        string path = @"C:\Users\salah\Documents\Visual Studio 2015\Projects\User.txt";

        public loginform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(path) != true)
            {
                if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    Form1 f1 = new Form1();
                    this.Hide();

                    f1.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Incorrect Information", "SignIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                string line;
                string[] arr;
                while ((line = sr.ReadLine()) != null)
                {
                    arr = line.Split(',');


                    if (textBox1.Text == arr[0] && textBox2.Text == arr[1])
                    {
                        Form1 f1 = new Form1();
                        this.Hide();

                        f1.ShowDialog();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Information", "SignIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
           
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
