using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shopping_Management_System.BL
{
    class Credit_Card : Payment
    {
        public override void pay()
        {
            MessageBox.Show("Your Payment Method Is by Credit Card", "Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
