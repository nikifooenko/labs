using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Input;
using MtrxLib;

namespace Task7_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            int amount;
            bool isInputCorrect = Int32.TryParse(Elements.Text, out amount);
            if (!isInputCorrect)
            {
                MessageBox.Show("Ошибка ввода");
                return;
            }

            for (int i = 0; i < amount; i++)
            {
                dataGridView1.Columns.AddRange(new DataGridViewTextBoxColumn { HeaderText = string.Empty });
            }
        }

        private void MirrorCheck_Click(object sender, EventArgs e)
        {
            char[] array = InputHelper.ReadChars(dataGridView1);
            if (array == null)
            {
                MessageBox.Show("Необходимо ввести значения!");
                return;
            }
            if (array.IsMirrored())
            {
                MessageBox.Show("Массив зеркальный");
            }
            else
            {
                MessageBox.Show("Массив не зеркальный");
            }

        }
    }
}
