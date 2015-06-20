using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MainForm
{
    class QLCBRules
    {
        public bool StringLength(string _string, int _length)
        {
            if(_string.Length <= 0 || _string.Length > _length)
                return false;
            return true;
        }

        public bool IsNNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool IsFNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        public string StrCut(string _string, int from, int to)
        {
            if (from > to || from > _string.Length - 1 || to > _string.Length - 1
                || from < 0 || to < 0)
            {
                MessageBox.Show("Khong Hop Le Dau Vao Cat Chuot");
                return "\0";
            }
            string b = "";
            for (int i = from; i <= to; i++)
                b += _string[i];
            return b;
        }
    }
}
