using System.Windows.Forms;

namespace CustomUserControlDemo.UI.Core
{
    public interface IUserControl
    {
        void DynamicLoad(object obj);
    }
}