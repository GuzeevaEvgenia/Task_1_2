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
using BusinessLogic;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadFile1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WorkWithFiles file = new WorkWithFiles(OpenFileDialog1.FileName);
                TextBox1.Lines = file.Text;
                OpenFileDialog1.Dispose();
            }
        }

        private void DownloadFile2_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog2.ShowDialog() == DialogResult.OK)
            {
                WorkWithFiles file = new WorkWithFiles(OpenFileDialog2.FileName);
                TextBox2.Lines = file.Text;
                OpenFileDialog2.Dispose();
            }
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            WorkWithFiles file = new WorkWithFiles();
            TextBox1.Text = file.CompareText(TextBox1.Text, TextBox2.Text);
        }

        private void SaveFile1_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WorkWithFiles file = new WorkWithFiles();
                file.WriteTo(SaveFileDialog.FileName, TextBox1.Lines);
            }
        }
    }
}
