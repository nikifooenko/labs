using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtrxLib
{
    public static class ArrayHelper
    {
        public static bool IsMirrored(this char[] array)
        {
            for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
            {
                if (array[i] != array[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
