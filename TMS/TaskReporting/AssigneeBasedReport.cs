using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.TaskReporting;
using CrystalDecisions.CrystalReports.Engine;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class AssigneeBasedReport : Form
    {

        TMS.BusinessLogicLayer.TaskReporting taskReporting = new TMS.BusinessLogicLayer.TaskReporting();
        WorkItemManagement workItemManagement = new WorkItemManagement();
        TeamManagement teamManagement = new TeamManagement();
        public AssigneeBasedReport()
        {
            InitializeComponent();
            LoadTheme();
            cmbassignee.SelectedText = "--Select Assignee--";
            GetAllData("0");
            datefrom.Enabled = false;
            dateTo.Enabled = false;
        }
        private void LoadTheme()
        {

            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    btnprint.ForeColor = ThemeColor.PrimaryColor;
                }
            }

            lblassignee.ForeColor = ThemeColor.PrimaryColor;
            lblstartdate.ForeColor = ThemeColor.PrimaryColor;
            lblenddate.ForeColor = ThemeColor.PrimaryColor;
            dview.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
            chkdateandassignee.ForeColor = ThemeColor.PrimaryColor;
            btnprint.Enabled = false;
        }

        private void AssigneeBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = teamManagement.GetEmployees(null, true); //dt = workItemManagement.GetUserIdandNames();
                //ds = obj.GetDataFromTable("Select empid,EmpName from UserMaster where isactive=1");
                DataRow dr_Assignee;
                dr_Assignee = dt.NewRow();
                dr_Assignee.ItemArray = new object[] { 0, "--Select Assignee--" };
                dt.Rows.InsertAt(dr_Assignee, 0);
                cmbassignee.ValueMember = "UserId";
                cmbassignee.DisplayMember = "EmpName";
                cmbassignee.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetAllData(string statusid) //Statusid 
        {
            if (cmbassignee.SelectedIndex > 0)
            {
                dview.DataSource = null;
                dview.DataSource = taskReporting.GetAssigneeBasedReport(datefrom.Value, dateTo.Value, chkdateandassignee.Checked, cmbassignee.SelectedValue.ToString());
            }
            else
            {
                dview.DataSource = null;
                dview.DataSource = taskReporting.GetAssigneeBasedReport(datefrom.Value, dateTo.Value, chkdateandassignee.Checked, null);
            }
            dview.Columns[0].Width = 400;
            dview.Columns[1].Width = 100;
            dview.Columns[2].Width = 100;
            dview.Columns[3].Width = 100;
            dview.Columns[4].Width = 120;
            dview.Columns[5].Width = 150;
            dview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dview.ReadOnly = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Status Based Report";
            // storing header part in Excel  
            for (int i = 1; i < dview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dview.Columns[i - 1].HeaderText;

            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dview.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            //excel.DisplayAlerts = false;
            //workbook.SaveAs(Application.StartupPath + "\\Report\\" + "StatusBasedReport_" + DateTime.Now.ToString(), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            //workbook.SaveAs(Microsoft.Office.Interop.Excel.Application.StartupPath + "\\Report\\" + "StatusBasedReport_" + DateTime.Now.ToString(), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }

        private void picpdf_Click(object sender, EventArgs e)
        {
            if (dview.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dview.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dview.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dview.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void picexcel_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.picexcel, "Export into Excel");
            tt.ForeColor = Color.Yellow;
        }

        private void picpdf_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt_pdf = new ToolTip();
            tt_pdf.SetToolTip(this.picexcel, "Export into PDF");
            tt_pdf.ForeColor = Color.Yellow;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if ((cmbassignee.SelectedIndex <= 0 || chkdateandassignee.Checked == false) && (cmbassignee.SelectedIndex <= 0 || chkdateandassignee.Checked == true))
            {
                PopupMessageBox.Show("Please Select Assignee!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataSet Ds = new DataSet();
                DataTable dt = new DataTable();
                dt = taskReporting.GetAssigneeBasedReport(datefrom.Value, dateTo.Value, chkdateandassignee.Checked, cmbassignee.SelectedValue.ToString());
                Ds.Tables.Add(dt);
                Ds.WriteXmlSchema("TimeBasedReportSchema.xml");
                ReportViewer fm = new ReportViewer();
                CRTimeBasedReport cr = new CRTimeBasedReport();

                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                txtReportHeader.Text = "Assignee Based Report";
                cr.SetDataSource(Ds);
                fm.crystalReportViewer1.ReportSource = cr;
                fm.Show();
            }

        }

        private void chkdateandassignee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkdateandassignee.Checked == true)
            {
                datefrom.Enabled = true;
                dateTo.Enabled = true;
            }
            else
            {
                datefrom.Enabled = false;
                dateTo.Enabled = false;
            }
        }

        private void btngetrecord_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbassignee.SelectedIndex <= 0 || chkdateandassignee.Checked == false) && (cmbassignee.SelectedIndex <= 0 || chkdateandassignee.Checked == true))
                {
                    PopupMessageBox.Show("Please Select Assignee!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnprint.Enabled = false;
                }
                else
                {
                    GetAllData(cmbassignee.SelectedValue.ToString());
                    btnprint.Enabled = false;
                    if (dview.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Record Found", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnprint.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbassignee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetAllData(cmbassignee.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
