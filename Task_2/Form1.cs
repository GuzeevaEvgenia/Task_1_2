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
using BusinessLogic;

namespace Task_2
{
    public partial class Form1 : Form
    { 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowItems file = new ShowItems(OpenFileDialog.FileName);
                TextBox1.Lines = file.St.Select(x => x.ToString()).ToArray();
                OpenFileDialog.Dispose();
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowItems file = new ShowItems();
                file.WriteTo(SaveFileDialog.FileName, TextBox2.Lines);
            }
        }

        private void ShowItems_Click(object sender, EventArgs e)
        {
            List<int> res = new List<int>();
            ShowItems file = new ShowItems(OpenFileDialog.FileName);
            file.Show(res);
            TextBox2.Text = string.Join(Environment.NewLine, res.Select(x => x.ToString()).ToArray());
        }
    }
}
