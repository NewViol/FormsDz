using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDz
{
    public partial class Form1 : Form
    {

       
        public Form1()
        {
            InitializeComponent();
            ReductButt.Enabled = false;

            
        }

        private void DownloadButt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = openFileDialog1.FileName;
            
           FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(file);

            int sr_lenght = (int)file.Length;


            string dopStr = string.Empty;
            while (!sr.EndOfStream)
            {
                dopStr += sr.ReadLine();
            }
            sr.Close();
            textBox.Text = dopStr;
            ReductButt.Enabled = true;
        }

        private void ReductButt_Click(object sender, EventArgs e)
        {
          
                Form2 DopForm = new Form2();
                if(DopForm.ShowDialog(textBox.Text) == DialogResult.OK)
                {
                    textBox.Clear();
                    textBox.Text = DopForm.TText;
                }
                DopForm.Close();
            


        }

        public void TextVvod(string d)
        {
            textBox.Clear();
            textBox.Text = d;
        }
    }
}
