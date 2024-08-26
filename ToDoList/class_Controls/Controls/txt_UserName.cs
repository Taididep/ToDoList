using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Controls
{
    public class txt_UserName : TextBox
    {
        public txt_UserName() 
        {
            this.KeyPress += Txt_UserName_KeyPress;

        }

        private void Txt_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
