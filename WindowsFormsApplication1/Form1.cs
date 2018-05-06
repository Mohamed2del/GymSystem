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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            

            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            home1.BringToFront();
            panel3.BringToFront();

            





        }


        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = homebtn.Height;
            sidepanel.Top = homebtn.Top;
            home1.BringToFront();
            panel3.BringToFront();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = findbtn.Height;
            sidepanel.Top = findbtn.Top;

            search1.BringToFront();
            panel3.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanel.Height = joinbtn.Height;
            sidepanel.Top = joinbtn.Top;
            packages1.BringToFront();
            panel3.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            loginform form = new loginform();
            this.Hide();

            form.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
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