using System;
using System.Drawing;
using System.Windows.Forms;

namespace TMS.UI.CustomMessageBox
{
    public partial class FormMessageBox : Form
    {
        //Fields
        private Color _primaryColor = Color.CornflowerBlue;
        private int _borderSize = 2;

        //Properties
        public Color PrimaryColor
        {
            get { return _primaryColor; }
            set
            {
                _primaryColor = value;
                this.BackColor = _primaryColor;//Form Border Color
                this.pnlTitleBar.BackColor = PrimaryColor;//Title Bar Back Color
            }
        }

        //Constructors
        public FormMessageBox(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitializeItems();
            this.PrimaryColor = _primaryColor;
            this.lblMessage.Text = text;
            this.lblCaption.Text = caption;
            SetFormSize();
            SetButtons(buttons, MessageBoxDefaultButton.Button1);//Set [Default Button 1]
            SetIcon(icon);
        }
       

        private void InitializeItems()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(_borderSize);//Set border size
            this.lblMessage.MaximumSize = new Size(550, 0);
            this.btnClose.DialogResult = DialogResult.Cancel;
            this.btnOne.DialogResult = DialogResult.OK;
            this.btnOne.Visible = false;
            this.btnTwo.Visible = false;
            this.btnThree.Visible = false;
        }
        private void SetFormSize()
        {
            int widht = this.lblMessage.Width + this.pbIcon.Width + this.pnlBody.Padding.Left;
            int height = this.pnlTitleBar.Height + this.lblMessage.Height + this.pnlButtons.Height + this.pnlBody.Padding.Top;
            this.Size = new Size(widht, height);
        }
        private void SetButtons(MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton)
        {
            int xCenter = (this.pnlButtons.Width - btnOne.Width) / 2;
            int yCenter = (this.pnlButtons.Height - btnOne.Height) / 2;

            switch (buttons)
            {
                case MessageBoxButtons.OK:
                    //OK Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter, yCenter);
                    btnOne.Text = "Ok";
                    btnOne.DialogResult = DialogResult.OK;//Set DialogResult

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
                case MessageBoxButtons.OKCancel:
                    //OK Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter - (btnOne.Width / 2) - 5, yCenter);
                    btnOne.Text = "Ok";
                    btnOne.DialogResult = DialogResult.OK;//Set DialogResult

                    //Cancel Button
                    btnTwo.Visible = true;
                    btnTwo.Location = new Point(xCenter + (btnTwo.Width / 2) + 5, yCenter);
                    btnTwo.Text = "Cancel";
                    btnTwo.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btnTwo.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.RetryCancel:
                    //Retry Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter - (btnOne.Width / 2) - 5, yCenter);
                    btnOne.Text = "Retry";
                    btnOne.DialogResult = DialogResult.Retry;//Set DialogResult

                    //Cancel Button
                    btnTwo.Visible = true;
                    btnTwo.Location = new Point(xCenter + (btnTwo.Width / 2) + 5, yCenter);
                    btnTwo.Text = "Cancel";
                    btnTwo.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btnTwo.BackColor = Color.DimGray;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;

                case MessageBoxButtons.YesNo:
                    //Yes Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter - (btnOne.Width / 2) - 5, yCenter);
                    btnOne.Text = "Yes";
                    btnOne.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btnTwo.Visible = true;
                    btnTwo.Location = new Point(xCenter + (btnTwo.Width / 2) + 5, yCenter);
                    btnTwo.Text = "No";
                    btnTwo.DialogResult = DialogResult.No;//Set DialogResult
                    btnTwo.BackColor = Color.IndianRed;

                    //Set Default Button
                    if (defaultButton != MessageBoxDefaultButton.Button3)//There are only 2 buttons, so the Default Button cannot be Button3
                        SetDefaultButton(defaultButton);
                    else SetDefaultButton(MessageBoxDefaultButton.Button1);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    //Yes Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter - btnOne.Width - 5, yCenter);
                    btnOne.Text = "Yes";
                    btnOne.DialogResult = DialogResult.Yes;//Set DialogResult

                    //No Button
                    btnTwo.Visible = true;
                    btnTwo.Location = new Point(xCenter, yCenter);
                    btnTwo.Text = "No";
                    btnTwo.DialogResult = DialogResult.No;//Set DialogResult
                    btnTwo.BackColor = Color.IndianRed;

                    //Cancel Button
                    btnThree.Visible = true;
                    btnThree.Location = new Point(xCenter + btnTwo.Width + 5, yCenter);
                    btnThree.Text = "Cancel";
                    btnThree.DialogResult = DialogResult.Cancel;//Set DialogResult
                    btnThree.BackColor = Color.DimGray;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;

                case MessageBoxButtons.AbortRetryIgnore:
                    //Abort Button
                    btnOne.Visible = true;
                    btnOne.Location = new Point(xCenter - btnOne.Width - 5, yCenter);
                    btnOne.Text = "Abort";
                    btnOne.DialogResult = DialogResult.Abort;//Set DialogResult
                    btnOne.BackColor = Color.Goldenrod;

                    //Retry Button
                    btnTwo.Visible = true;
                    btnTwo.Location = new Point(xCenter, yCenter);
                    btnTwo.Text = "Retry";
                    btnTwo.DialogResult = DialogResult.Retry;//Set DialogResult                    

                    //Ignore Button
                    btnThree.Visible = true;
                    btnThree.Location = new Point(xCenter + btnTwo.Width + 5, yCenter);
                    btnThree.Text = "Ignore";
                    btnThree.DialogResult = DialogResult.Ignore;//Set DialogResult
                    btnThree.BackColor = Color.IndianRed;

                    //Set Default Button
                    SetDefaultButton(defaultButton);
                    break;
            }
        }
        private void SetDefaultButton(MessageBoxDefaultButton defaultButton)
        {
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1://Focus button 1
                    btnOne.Select();
                    btnOne.ForeColor = Color.White;
                    btnOne.Font = new Font(btnOne.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button2://Focus button 2
                    btnTwo.Select();
                    btnTwo.ForeColor = Color.White;
                    btnTwo.Font = new Font(btnTwo.Font, FontStyle.Underline);
                    break;
                case MessageBoxDefaultButton.Button3://Focus button 3
                    btnThree.Select();
                    btnThree.ForeColor = Color.White;
                    btnThree.Font = new Font(btnThree.Font, FontStyle.Underline);
                    break;
            }
        }
        private void SetIcon(MessageBoxIcon icon)
        {
            switch (icon)
            {
                case MessageBoxIcon.Error: //Error
                    this.pbIcon.Image = TMS.Properties.Resources.error;
                    PrimaryColor = Color.FromArgb(224, 79, 95);
                    this.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    break;
                case MessageBoxIcon.Information: //Information
                    this.pbIcon.Image = TMS.Properties.Resources.information;
                    PrimaryColor = Color.FromArgb(38, 191, 166);
                    break;
                case MessageBoxIcon.Question://Question
                    this.pbIcon.Image = TMS.Properties.Resources.question;
                    PrimaryColor = Color.FromArgb(10, 119, 232);
                    break;
                case MessageBoxIcon.Exclamation://Exclamation
                    this.pbIcon.Image = TMS.Properties.Resources.exclamation;
                    PrimaryColor = Color.FromArgb(255, 140, 0);
                    break;
                case MessageBoxIcon.None: //None
                    this.pbIcon.Image = TMS.Properties.Resources.chat;
                    PrimaryColor = Color.CornflowerBlue;
                    break;
            }
        }

        //-> Events Methods
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
