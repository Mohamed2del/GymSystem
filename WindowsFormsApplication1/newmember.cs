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
    public partial class newmember : UserControl
    {

        public newmember()
        {
            InitializeComponent();

        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\salah\Documents\Visual Studio 2015\Projects\WindowsFormsApplication1\DATAREC.txt";

            StreamReader sr = new StreamReader(path);
            string line = sr.ReadLine();
            int count = 0;
            string userrec;
            while (line != null)
            {
                count++;
            }
            sr.Close();

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);

            if (textBox1.Text != null &&( radioButton1.Checked == true|| radioButton2.Checked == true))
            {
                if (radioButton1.Checked == true)
                {
                    userrec =count+++","+ textBox1.Text + "," + radioButton1.Text + "," + label3.Text + "," + dateTimePicker1.Text;
                    sw.WriteLine(userrec);
                    
                   


                }
                else if (radioButton2.Checked == true)
                {
                    userrec =count+++","+ textBox1.Text + "," + radioButton2.Text + "," + label3.Text + "," + dateTimePicker1.Text;
                    sw.WriteLine(userrec);
                   
                }
                sw.Flush();
                sw.Close();
                MessageBox.Show("Submit Successfull !");

            }
            else
            {
                MessageBox.Show("Check Your information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sw.Close();

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
