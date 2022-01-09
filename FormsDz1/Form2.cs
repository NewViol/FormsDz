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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TText
        {
            set
            {
                textBox1.Text = value; 
            }
            get
            {
                return textBox1.Text;
            }
        }


        private void SaweButt_Click(object sender, EventArgs e)
        {


            StreamWriter sw = new StreamWriter("DownloadText.txt", false);


            foreach (var i in textBox1.Text)
            {
                sw.WriteLine(i);
            }
            sw.Close();
            this.DialogResult = DialogResult.OK;
            this.Close();

            
        }
   


        public DialogResult ShowDialog(string d)
        {
            textBox1.Text = d;
            return ShowDialog();
        }

        private void CencelButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
