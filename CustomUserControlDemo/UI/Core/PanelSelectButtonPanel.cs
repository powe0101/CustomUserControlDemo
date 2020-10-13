using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomUserControlDemo.Controller;

namespace CustomUserControlDemo.UI.Core
{
    public partial class PanelSelectButtonPanel : UserControl
    {
        public PanelSelectButtonPanel()
        {
            InitializeComponent();
            this.ButtonAPanel.Click += Button_Click;
            this.ButtonBPanel.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ClickController.Click(sender);
        }
    }
}
