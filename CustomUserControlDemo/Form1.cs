using CustomUserControlDemo.Controller;
using CustomUserControlDemo.Data;
using CustomUserControlDemo.UI.Control;
using CustomUserControlDemo.UI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomUserControlDemo
{
    public partial class Form1 : Form
    {
        AControl aControl = new AControl();
        BControl bControl = new BControl();

        public Form1()
        {
            InitializeComponent();
            InitControls();
            ClickController.ChangePanel += ClickController_ChangePanel;
        }

        private void InitControls()
        {
            aControl.DynamicLoad("AControl");
            bControl.DynamicLoad(false);
        }

        private Control GetPage(object sender)
        {
            var button = (sender as Button);
            switch (button.Text)
            {
                case "AControl":
                    return aControl;
                case "BControl":
                    return bControl;
                    //default:
            }
            return new UserControl();
        }

        private void ClickController_ChangePanel(object sender, EventArgs e)
        {
            var temp = GetPage(sender);

            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(temp);
        }
    }
}
