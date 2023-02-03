using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace TMS.UI.Utilities
{
    public static class RightBottomMessageBox
    {
        public static void Success(string success_message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.success;
            popup.BodyColor = Color.FromArgb(40, 167, 69);
            popup.TitleText = "Success";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = success_message;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
        public static void Error(string Error_message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.error;
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = "Error ";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = Error_message;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
        public static void Info(string Info_message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = "Info ";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = Info_message;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
        public static void warning(string warning_message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Warning;
            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = "Info ";
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentText = warning_message;
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
    }
}
