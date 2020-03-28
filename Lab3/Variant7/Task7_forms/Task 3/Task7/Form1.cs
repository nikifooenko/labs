using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string thirdWord = text.GetWord(3);
            if (thirdWord != null)
            {
                label1.Text = $"Количество символов 'а' в третьем слове: { thirdWord.CountSymbol('а') }";
            }
            else
            {
                label1.Text = $"Количество символов 'а' в третьем слове: 0";
            }
        }
    }
}
