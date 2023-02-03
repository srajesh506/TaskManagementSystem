using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TMS.UI.Utilities;
using TMS.BusinessLogicLayer;
using TMS.UI.CustomMessageBox;
using System.Data;
using TMS.TaskReporting;
using CrystalDecisions.CrystalReports.Engine;

namespace TMS.UI
{
    public partial class TimeBasedReport : Form
    {
        
        
        TMS.BusinessLogicLayer.TaskReporting taskReporting = new TMS.BusinessLogicLayer.TaskReporting();
        public TimeBasedReport()
        {
            InitializeComponent();
            LoadTheme();
            //cmbassignee.SelectedText = "--Select Assignee--";
            //GetAllData("0");
            btnprint.Enabled = false;
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
          
            lblstartdate.ForeColor = ThemeColor.PrimaryColor;
            lblenddate.ForeColor = ThemeColor.PrimaryColor;
            dview.ForeColor = ThemeColor.PrimaryColor;
            //groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
            //btngetrecord.ForeColor = ThemeColor.PrimaryColor;
            //btnprint.ForeColor = ThemeColor.PrimaryColor;
        }

        private void AssigneeBasedReport_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        public void GetAllData(DateTime datefrom, DateTime dateTo)
        {
           if(this.datefrom.Value.ToString()!="" && this.dateTo.Value.ToString()!="")
            {
                dview.DataSource = null;
                dview.DataSource = taskReporting.GetTimeBasedReport(datefrom, dateTo);

                dview.Columns[0].Width = 400;
                dview.Columns[1].Width = 100;
                dview.Columns[2].Width = 100;
                dview.Columns[3].Width = 100;
                dview.Columns[4].Width = 120;
                dview.Columns[5].Width = 150;
                dview.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dview.ReadOnly = true;
                
            }
               
            

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
                            PopupMessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message,"TMS",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
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
                            PopupMessageBox.Show("Data Exported Successfully !!!", "TMS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    catch (Exception ex)
                    {
                            PopupMessageBox.Show("Error :" + ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
            }
            else
            {
                PopupMessageBox.Show("No Record To Export !!!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btngetrecord_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan span = new TimeSpan(0, 0, 2, 0);
                if (datefrom.Value > dateTo.Value.Add(span))
                {
                    PopupMessageBox.Show("From date should not be greater than to date", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateTo.Value = DateTime.Now;
                }
                else
                {
                    GetAllData(datefrom.Value, dateTo.Value);
                    btnprint.Enabled = false;
                    if (dview.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Record Found", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnprint.Enabled = true;
                }

            }
            catch(Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet Ds = new DataSet();
                DataTable dt = new DataTable();
                dt= taskReporting.GetTimeBasedReport(datefrom.Value, dateTo.Value);
                Ds.Tables.Add(dt);
                Ds.WriteXmlSchema("TimeBasedReportSchema.xml");
                ReportViewer fm = new ReportViewer();
                CRTimeBasedReport cr = new CRTimeBasedReport();
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                txtReportHeader.Text = "TIME BASED REPORT";
                cr.SetDataSource(Ds);
                fm.crystalReportViewer1.ReportSource = cr;
                fm.Show();
            }
            catch(Exception ex)
            {
                PopupMessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
