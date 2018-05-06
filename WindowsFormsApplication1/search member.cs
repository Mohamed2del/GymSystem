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
    public partial class search : UserControl
    {
        public string  path = @"C:\Users\salah\Documents\Visual Studio 2015\Projects\DATAREC.txt";
        public search()
        {
            InitializeComponent();
        }
        
        public void Search(TextBox keyword, int index)
        {
            if (keyword.Text != null)

            {
                 
                string line;
                string[] array;
                Boolean found = false;
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                StreamReader sr = new StreamReader(fs);
                while ((line = sr.ReadLine()) != null)
                {
                    array = line.Split(',');

                    if (array[index] == keyword.Text)
                    {
                        string n = array[0];

                        if (n[0]=='*')
                        {
                            sr.Close();
                            fs.Close();
                            goto msg;

                        }
                        else
                        {
                            groupBox1.Visible = true;
                            namelabel.Text = array[1];
                            sexlabel.Text = array[2];
                            packagelabel.Text = array[3];
                            datelabel.Text = array[4];
                            found = true;
                            sr.Close();
                            fs.Close();


                            return;
                        }
                       
                    }

                    
                }
             msg:   if (found == false)
                {
                    MessageBox.Show("Member Not Found ");
                    IDtextbox.Text = null;
                    nametextbox.Text = null;
                }
                sr.Close();
                fs.Close();
            }


        }
        private void namelabel_Click(object sender, EventArgs e)
        {

        }

        private void sexlabel_Click(object sender, EventArgs e)
        {

        }

        private void packagelabel_Click(object sender, EventArgs e)
        {

        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IDtextbox.Text.Length != 0 && nametextbox.Text.Length == 0)
            {

                Search(IDtextbox, 0);
               
            }
            else if (nametextbox.Text.Length != 0 && IDtextbox.Text.Length == 0)
            {

                Search(nametextbox, 1);
                
            }
            else
            {
                MessageBox.Show("Please Write a Keyword");
            }
        }


     

        private void IDtextbox_MouseClick(object sender, MouseEventArgs e)
        {
            nametextbox.Text = null;
        }

        private void nametextbox_MouseClick(object sender, MouseEventArgs e)
        {
            IDtextbox.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string line;
            string[] array;
            int count = 0;
            Boolean found = false;
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            StreamWriter sw = new StreamWriter(fs);

            while ((line = sr.ReadLine()) != null)
            {
                array = line.Split(',');

                if (array[1]==nametextbox.Text||array[0]==IDtextbox.Text)
                {
                    found = true;
                    fs.Seek(count, SeekOrigin.Begin);
                    fs.Flush();
                    sw.Write('*');
                    array[1] = "*";
                    sw.Flush();
                    sw.Close();
                    sr.Close();
                    fs.Close();

                    groupBox1.Visible = false;
                    MessageBox.Show("Deleted Succeed !","Notice",MessageBoxButtons.OK);
                   

                    nametextbox.Text = null;
                    IDtextbox.Text = null;
                    return;
                }

                count += line.Length + 2;
            }
           
           
           

            if (found == false)
            {
                MessageBox.Show("Member Not Found ");
            }
           
        }
    }
}
