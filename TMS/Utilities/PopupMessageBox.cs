using System.Windows.Forms;

namespace TMS.UI.CustomMessageBox
{
public abstract class PopupMessageBox
{
    public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
    {
        DialogResult result;
        using (var msgForm = new FormMessageBox(text, caption, buttons, icon))
            result = msgForm.ShowDialog();
        return result;
    }
    
}
}
