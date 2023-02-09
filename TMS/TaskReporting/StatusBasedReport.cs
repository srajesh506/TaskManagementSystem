﻿using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TMS.BusinessLogicLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TMS.UI.Utilities;
using CrystalDecisions.CrystalReports.Engine;
using TMS.UI.CustomMessageBox;

namespace TMS.UI
{
    public partial class StatusBasedReport : Form
    {
        
        TMS.BusinessLogicLayer.TaskReporting taskReporting = new TMS.BusinessLogicLayer.TaskReporting();
        DBCommonOperations dBCommonOperations = new DBCommonOperations();
        public StatusBasedReport()
        {
            InitializeComponent();
            LoadTheme();
            cmbStatus.SelectedText = "--Select Status--";
            GetAllData("0");
            dateFrom.Enabled = false;
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
                }
            }

            lblStatus.ForeColor = ThemeColor.PrimaryColor;
            lblStartDate.ForeColor = ThemeColor.PrimaryColor;
            lblEndDate.ForeColor = ThemeColor.PrimaryColor;
            Dview.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
        }

        private void StatusBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dBCommonOperations.GetStatus();
                DataRow dr;
                dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "--Select Status--" };
                dt.Rows.InsertAt(dr, 0);
                cmbStatus.ValueMember = "StatusId";
                cmbStatus.DisplayMember = "StatusDescription";
                cmbStatus.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               GetAllData(cmbStatus.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData(string statusid)
        {
            if (cmbStatus.SelectedIndex > 0)
            {
                Dview.DataSource = null;
                Dview.DataSource = taskReporting.GetStatusBasedReport(dateFrom.Value,dateTo.Value,chkDateandAssignee.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
            }
            else
            {
                Dview.DataSource = null;
                Dview.DataSource = taskReporting.GetStatusBasedReport(dateFrom.Value, dateTo.Value, chkDateandAssignee.Checked);
            }
            Dview.Columns[0].Width = 400;
            Dview.Columns[1].Width = 100;
            Dview.Columns[2].Width = 100;
            Dview.Columns[3].Width = 100;
            Dview.Columns[4].Width = 120;
            Dview.Columns[5].Width = 150;
            Dview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dview.ReadOnly = true;

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
            for (int i = 1; i < Dview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = Dview.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < Dview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < Dview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = Dview.Rows[i].Cells[j].Value.ToString();
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
            if (Dview.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(Dview.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in Dview.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in Dview.Rows)
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
            tt.SetToolTip(this.picExcel, "Export into Excel");
            tt.ForeColor = Color.Yellow;
        }

        private void picpdf_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt_pdf = new ToolTip();
            tt_pdf.SetToolTip(this.picExcel, "Export into PDF");
            tt_pdf.ForeColor = Color.Yellow;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbStatus.SelectedIndex <= 0 || chkDateandAssignee.Checked == false) && (cmbStatus.SelectedIndex <= 0 || chkDateandAssignee.Checked == true))
                {
                    PopupMessageBox.Show("Please Select Status!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataSet Ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt = taskReporting.GetStatusBasedReport(dateFrom.Value, dateTo.Value, chkDateandAssignee.Checked, Convert.ToInt32(cmbStatus.SelectedValue));
                    Ds.Tables.Add(dt);
                    Ds.WriteXmlSchema("TimeBasedReportSchema.xml");
                    TMS.TaskReporting.ReportViewer fm = new TMS.TaskReporting.ReportViewer();
                    TMS.TaskReporting.CRTimeBasedReport cr = new TMS.TaskReporting.CRTimeBasedReport();
                    CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                    txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                    txtReportHeader.Text = "STATUS BASED REPORT";
                    cr.SetDataSource(Ds);
                    fm.crystalReportViewer1.ReportSource = cr;
                    fm.Show();
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngetrecord_Click(object sender, EventArgs e)
        {
            try
            {
                if ((cmbStatus.SelectedIndex <= 0 || chkDateandAssignee.Checked == false) && (cmbStatus.SelectedIndex <= 0 || chkDateandAssignee.Checked == true))
                {
                    PopupMessageBox.Show("Please Select Status!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnPrint.Enabled = false;
                }
                else
                {
                    GetAllData(cmbStatus.SelectedValue.ToString());
                    btnPrint.Enabled = false;
                    if (Dview.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Record Found", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnPrint.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkdateandassignee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateandAssignee.Checked == true)
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
            }
            else
            {
                dateFrom.Enabled = false;
                dateTo.Enabled = false;
            }
        }
    }
}
