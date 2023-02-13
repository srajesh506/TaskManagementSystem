using System;
using System.Data;
using System.Windows.Forms;

using CrystalDecisions.CrystalReports.Engine;


namespace TMS.UI.Utilities
{
    public static class FormControlHandling
    {
        public static string ClearUpperQmark(string str)
        {
            string temp = "";
            if (str != null)
            {
                for (int m = 0; m <= str.Length - 1; m++)
                {
                    if (str.Substring(m, 1) != Convert.ToString(39))
                    {
                        temp = temp + str.Substring(m, 1);
                    }
                    else
                    {
                        temp = temp + ((char)39).ToString() + ((char)39).ToString();

                    }
                }
            }
            return temp;
        }
       
        public static void ClearControls(GroupBox groupBox)
        {
            ComboBox cmb = new ComboBox();
            PictureBox pic = new PictureBox();
            CheckedListBox chkbox = new CheckedListBox();
            RichTextBox rtxt = new RichTextBox();
            CheckBox chk = new CheckBox();
            foreach (Control frm in groupBox.Controls)
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

        public static DataTable GetPageRecords(DataTable dataTable, int currentPage, int pageSize)
        {
            DataTable records = new DataTable();
            records = dataTable.Clone();
            records.Rows.Clear();
            int offset, temp;
            offset = currentPage * pageSize;
            temp = offset - pageSize + 1;
            while ((temp <= offset) && (records.Rows.Count <= dataTable.Rows.Count))
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (temp == Convert.ToInt32(dataRow[0]))
                    {
                        records.ImportRow(dataRow);
                    }
                }
                temp += 1;
            }
            return records;
        }
    
        //public static void ReportPrint(string reportHeader, DataSet reportDataSet, object reportType)
        //{
        //    ReportViewer reportViewer = new ReportViewer();
        //    CRTimeBasedReport cr = new CRTimeBasedReport();

        //    TextObject txtReportHeader;
        //    txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
        //    txtReportHeader.Text = "Assignee Based Report";
        //    cr.SetDataSource(reportDataSet);
        //    reportViewer.crystalReportViewer1.ReportSource = cr;
        //    reportViewer.Show();
        //}
    
    }
}
