using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompareFiles1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string StartUpPath = Application.StartupPath;

        protected string filename1 = "";
        protected string filename2 = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Select a text file";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            openFileDialog1.InitialDirectory = StartUpPath;
            openFileDialog1.Title = "Open text file";

            openFileDialog2.FileName = "Select a text file";
            openFileDialog2.Filter = "Text files (*.txt)|*.txt";
            openFileDialog2.InitialDirectory = StartUpPath;
            openFileDialog2.Title = "Open text file";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f1 = openFileDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult f2 = openFileDialog1.ShowDialog();
        }
    }
}
