using System;
using System.Windows.Forms;
using TMS.Properties;

namespace TMS.UI.Utilities
{
    public static class FormControlHandling
    {
        public static string ClearUpperQmark(string Str)
        {
            string temp = "";
            if (Str != null)
            {
                for (int m = 0; m <= Str.Length - 1; m++)
                {
                    if (Str.Substring(m, 1) != Convert.ToString(39))
                    {
                        temp = temp + Str.Substring(m, 1);
                    }
                    else
                    {
                        temp = temp + ((char)39).ToString() + ((char)39).ToString();

                    }
                }
            }
            return temp;

        }
        public static void ClearControls(GroupBox gp)
        {
            Control form_control = new Control();
            ComboBox cmb = new ComboBox();
            PictureBox pic = new PictureBox();
            CheckedListBox chkbox = new CheckedListBox();
            RichTextBox rtxt = new RichTextBox();
            CheckBox chk = new CheckBox();
            foreach (Control frm in gp.Controls)
            {
                if (frm is TextBox)
                    frm.Text = "";
                if (frm is ComboBox)
                {
                    cmb = frm as ComboBox;
                    cmb.SelectedIndex = 0;
                }
                if (frm is PictureBox)
                {   
                    pic = frm as PictureBox;
                    if (frm.Name == "pbPic")
                    {
                        pic.Image = TMS.Properties.Resources.dp;
                    }
                    else if (frm.Name == "pbPwdIcon")
                    {
                        pic.Image = TMS.Properties.Resources.hoverIcon;
                    }
                }
                if (frm is RichTextBox)
                {
                    rtxt = frm as RichTextBox;
                    rtxt.Text = "";
                }
                if (frm is CheckBox)
                {
                    chk = frm as CheckBox;
                    chk.Checked = false;
                }

            }
        }

    }
}
