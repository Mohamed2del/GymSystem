using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class packages : UserControl
    {
        public packages()
        {
            InitializeComponent();
        }
        public int count(string path)
        {
            if (File.Exists(path)==true)
            {
                StreamReader sr = new StreamReader(path);
                int count = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                }
                sr.Close();

                return count;
            }
            else
            {
                return 1;
            }

        }
        public void add(string path,FileStream stream ,int count)
        {
            StreamWriter sw = new StreamWriter(stream);
            string record;
            




            if (malerb.Checked == true)
            {
                record = (count++)+","+namebox.Text + "," + malerb.Text + "," + label9.Text + "," + dateTimePicker1.Text;

            }
            else
            {
                record = (count++) + "," + namebox.Text + "," + femalrb.Text + "," + label9.Text + "," + dateTimePicker1.Text;

            }
            sw.WriteLine(record);
            sw.Flush();

            sw.Close();

            MessageBox.Show("Submitted Successfuly");
            namebox.Text = null;
            malerb.Checked = false;
            femalrb.Checked = false;
            panel5.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.BringToFront();
            label9.Text = label5.Text;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.BringToFront();
            label9.Text = label6.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.BringToFront();
            label9.Text = label7.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel5.BringToFront();
            label9.Text = label8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            namebox.Text = null;
            malerb.Checked = false;
            femalrb.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(namebox.Text.Length>=3&&(malerb.Checked==true||femalrb.Checked==true))
            { int c;
                string path = @"C:\Users\salah\Documents\Visual Studio 2015\Projects\DATAREC.txt";
                if (File.Exists(path)!=true)
                {
                    c= count(path);

                    FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                    

                    add(path,stream,c);

                    
                   
                }
                else
                {
                   c= count(path);
                    FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write);

                    add(path,stream,c);
                    stream.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Fill Your Info !!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

      
    }
}
