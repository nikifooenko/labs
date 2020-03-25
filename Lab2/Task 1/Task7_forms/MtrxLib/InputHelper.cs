using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Input
{
    public class InputHelper
    {
        public static char[] ReadChars(DataGridView dataGridView)
        {

            int length = dataGridView.Columns.Count;
            char[] array = new char[length];
            for (int i = 0; i < length; i++)
            {
                var value = dataGridView.Rows[0].Cells[i].Value;
                if (value != null)
                {
                    array[i] = value.ToString()[0];
                }
                else 
                {
                    return null;
                }
            }
            return array;

        }
    }
}
