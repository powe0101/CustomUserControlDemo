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
    public partial class BControl : CoreControl
    {
        public BControl()
        {
            InitializeComponent();
        }

        public override void DynamicLoad(object type)
        {
            if (type == null)
                return;

            bool? isLoad = type as bool?;

            if(isLoad == true)
            {
                this.MainPanel.BackColor = Color.AliceBlue;
            }
            else
            {
                this.MainPanel.BackColor = Color.Green;
            }
        }
    }
}
