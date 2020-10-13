using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomUserControlDemo.UI.Core;

namespace CustomUserControlDemo.UI.Control
{
    public partial class AControl : CoreControl
    {
        public AControl()
        {
            InitializeComponent();
        }

        public override void DynamicLoad(object text)
        {
            if (text == null)
                return;

            string str = text as string;
            this.MainTextBox.Text = str;
        }
    }
}
