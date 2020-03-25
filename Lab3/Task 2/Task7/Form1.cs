using System;
using System.Windows.Forms;
using TextHelper;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            label1.Text = $"Количество строчных букв: {text.CountInLine()}";
        }
    }
}
