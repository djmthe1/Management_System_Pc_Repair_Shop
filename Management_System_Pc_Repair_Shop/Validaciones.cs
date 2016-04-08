using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;

namespace Management_System_Pc_Repair_Shop
{
    public class Validaciones
    {
        public void Numeros_KeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void LetrasNumeros_KeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar == 32) || (e.KeyChar == 35) || (e.KeyChar == 130) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void Letras_KeyPress(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122 || (e.KeyChar == 32)) || (e.KeyChar == 130) || (e.KeyChar == 8) || (e.KeyChar >= 160 && e.KeyChar <= 163))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
