using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Controls
{
    public class txt_SDT : TextBox
    {
        private System.Windows.Forms.ErrorProvider errorPro = new ErrorProvider();
        public txt_SDT()
        {
            this.KeyPress += txt_SDT_KeyPress;

        }
        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //checkPass
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            //check length
            if (this.Text.Length < 6)
            {
                errorPro.SetError(this, "Password > 6");
            }
            else
            {
                errorPro.Clear();
            }
        }
    }
}
