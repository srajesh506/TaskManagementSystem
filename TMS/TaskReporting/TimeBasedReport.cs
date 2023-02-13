using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using TMS.UI.Utilities;
using TMS.UI.CustomMessageBox;

using CrystalDecisions.CrystalReports.Engine;


namespace TMS.UI
{
    public partial class TimeBasedReport : Form
    {


        TMS.BusinessLogicLayer.TaskReporting taskReporting = new TMS.BusinessLogicLayer.TaskReporting();
        public TimeBasedReport()
        {
            try
            {
                InitializeComponent();
                LoadTheme();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Time Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        //Form Load event - Loads the default griddata.
        private void AssigneeBasedReport_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value);
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to Load the Time Based Report Form!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get Record button click event to retrive the records in gridview
        private void btnGetRecord_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan span = new TimeSpan(0, 0, 2, 0);
                if (dtpDateFrom.Value > dtpDateTo.Value.Add(span))
                {
                    PopupMessageBox.Show("From date should not be greater than to date", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpDateTo.Value = DateTime.Now;
                }
                else
                {
                    LoadTimeBasedReportGrid(dtpDateFrom.Value, dtpDateTo.Value);
                    btnPrint.Enabled = false;
                    if (dView.Rows.Count <= 1)
                    {
                        PopupMessageBox.Show("No Record Found", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    btnPrint.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to retrieve the records in GridView based on Assignee selection!! \n" + ex.Message + "\n", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //Print button click event - to print the report using crystal report
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet Ds = new DataSet();
                DataTable dt = new DataTable();
                dt = taskReporting.GetTimeBasedReport(dtpDateFrom.Value, dtpDateTo.Value);
                Ds.Tables.Add(dt);
                Ds.WriteXmlSchema("TimeBasedReportSchema.xml");
                ReportViewer fm = new ReportViewer();
                CrystalReport cr = new CrystalReport();
                CrystalDecisions.CrystalReports.Engine.TextObject txtReportHeader;
                txtReportHeader = cr.ReportDefinition.ReportObjects["Text7"] as TextObject;
                txtReportHeader.Text = "TIME BASED REPORT";
                cr.SetDataSource(Ds);
                fm.crystalReportViewer.ReportSource = cr;
                fm.Show();
            }
            catch (Exception ex)
            {
                PopupMessageBox.Show("TMSError - Failed to print the report!! \n" + ex.Message + "\n", "TMS",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //User Defined

        // Function to Load the Form Theme
        private void LoadTheme()
        {
            try
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

                lblStartDate.ForeColor = ThemeColor.PrimaryColor;
                lblEndDate.ForeColor = ThemeColor.PrimaryColor;
                dView.ForeColor = ThemeColor.PrimaryColor;
                //groupBoxforeTaskBasedReport.ForeColor = ThemeColor.PrimaryColor;
                //btngetrecord.ForeColor = ThemeColor.PrimaryColor;
                //btnprint.ForeColor = ThemeColor.PrimaryColor;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the Theme!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }
        //Function to load the datagridview with the records and setup other options for datagridview
        public void LoadTimeBasedReportGrid(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                dView.DataSource = null;
                dView.DataSource = taskReporting.GetTimeBasedReport(dateFrom, dateTo);

                dView.Columns[0].Width = 400;
                dView.Columns[1].Width = 100;
                dView.Columns[2].Width = 100;
                dView.Columns[3].Width = 100;
                dView.Columns[4].Width = 120;
                dView.Columns[5].Width = 150;
                dView.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dView.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception("TMSError - Failed to load the data in GridView!! \n" + ex.Message + "\n", ex.InnerException);
            }
        }


    }
}
