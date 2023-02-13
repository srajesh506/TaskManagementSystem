using System.Drawing;
using Tulpep.NotificationWindow;


namespace TMS.UI.Utilities
{
    public static class RightBottomMessageBox
    {
        public static void Success(string message)
        {
            SetupPopUp("Success", message);
        }
        public static void Error(string message)
        {
            SetupPopUp("Error", message);
        }
        public static void Info(string message)
        {
            SetupPopUp("Info", message);
        }
        public static void warning(string message)
        {
            SetupPopUp("Warning", message);
        }

        public static void SetupPopUp(string popUpType, string popUpMessage)
        {
            PopupNotifier popup = new PopupNotifier();
            switch (popUpType)
            {
                case "Success":
                    popup.Image = Properties.Resources.success;
                    popup.BodyColor = Color.FromArgb(40, 167, 69);
                    popup.TitleText = "Success ";
                    popup.ContentText = popUpMessage;
                    break;
                case "Error":
                    popup.Image = Properties.Resources.error;
                    popup.BodyColor = Color.FromArgb(220, 53, 69);
                    popup.TitleText = "Error ";
                    popup.ContentText = popUpMessage;
                    break;
                case "Info":
                    popup.Image = Properties.Resources.info;
                    popup.BodyColor = Color.FromArgb(23, 162, 184);
                    popup.TitleText = "Info ";
                    popup.ContentText = popUpMessage;
                    break;
                case "Warning":
                    popup.Image = Properties.Resources.Warning;
                    popup.BodyColor = Color.FromArgb(23, 162, 184);
                    popup.TitleText = "Info ";
                    popup.ContentText = popUpMessage;
                    break;
                default:
                    break;
            }
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Century Gothic", 15, FontStyle.Bold);

            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Century Gothic", 12);
            popup.Popup();
        }
    }
}
