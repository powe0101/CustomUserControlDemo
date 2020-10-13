using CustomUserControlDemo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUserControlDemo.Controller
{
    public class ClickController
    {
        static public event EventHandler ChangePanel;

        internal static void Click(object sender)
        {
            ChangePanel.Invoke(sender, null);
        }

    }
}
