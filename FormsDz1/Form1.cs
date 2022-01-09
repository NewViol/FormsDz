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

        public bool IsDownload = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadButt_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("DownloadText.txt", FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(file);

            int sr_lenght = (int)file.Length;


            string dopStr = string.Empty;
            while (!sr.EndOfStream)
            {
                dopStr += sr.ReadLine();
            }
            sr.Close();
            textBox.Text = dopStr;
            IsDownload = true;
        }

        private void ReductButt_Click(object sender, EventArgs e)
        {
            if(IsDownload == true)
            {
                Form2 DopForm = new Form2();
                if(DopForm.ShowDialog(textBox.Text) == DialogResult.OK)
                {
                    textBox.Clear();
                    textBox.Text = DopForm.TText;
                }
                DopForm.Close();
            }


        }

        public void TextVvod(string d)
        {
            textBox.Clear();
            textBox.Text = d;
        }
    }
}
