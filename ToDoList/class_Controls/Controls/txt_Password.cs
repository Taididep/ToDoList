using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Controls
{
    public class txt_Password : TextBox
    {
        public txt_Password() 
        {
            this.KeyPress += Class1_KeyPress;
            this.UseSystemPasswordChar = true;
        }

        private void Class1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }

}
