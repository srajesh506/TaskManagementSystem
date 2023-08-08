using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TMS.BusinessLogicLayer;
using TMS.TaskReporting;
using TMS.UI;

namespace TMS.WorkitemHistory
{
    public partial class FrmWorkItemHistory : Form
    {
        private int workitemid;
        WorkItemManagement workItemManagement = new WorkItemManagement();
        private DataTable _WorkItemAssignmentHistory;
        public FrmWorkItemHistory(int workitem)
        {
            InitializeComponent();
            this.workitemid = workitem;
        }
        private void FrmWorkItemHistory_Load(object sender, EventArgs e)
        {
            _WorkItemAssignmentHistory = workItemManagement.GetWorkItemAssignmentsHistory(workitemid);
            Dviewhistory.DataSource = _WorkItemAssignmentHistory;
            lblWorkItemValue.Text = _WorkItemAssignmentHistory.Rows[0][2].ToString(); //WorkItem
            lblCurrentStatusValue.Text = _WorkItemAssignmentHistory.Rows[0][3].ToString();//Current Status
            lblOpenDateValue.Text = _WorkItemAssignmentHistory.Rows[Convert.ToInt32(_WorkItemAssignmentHistory.Rows.Count-1)][5].ToString();//First Open Date
            Dviewhistory.Columns[0].Visible = false;               //ID
            Dviewhistory.Columns[1].Visible = false;              //WorkItemId
            Dviewhistory.Columns[2].Visible = false;              //WorkItem
            Dviewhistory.Columns[4].Width = 150;                   //AssignedTo
            Dviewhistory.Columns[5].Width = 150;                   //StartDate
            Dviewhistory.Columns[6].Width = 150;                   //ClosedDate
            Dviewhistory.Columns[8].Width = 450;
        }

        private void btnPrint_Click(object sender, EventArgs e) //On button Click DataTable Get Data from the Following Function
        {
            DataSet Ds = new DataSet();
            DataTable dt = new DataTable();
            dt = workItemManagement.GetWorkItemAssignmentsHistory(workitemid);
            Ds.Tables.Add(dt);
            Ds.WriteXmlSchema("WorkItemHistory.xml");//Function will create the schema File 
            ReportViewer fm = new ReportViewer();
            WorkItemHistoryReport cr = new WorkItemHistoryReport();
            cr.SetDataSource(Ds);// Set Data Source using SetDataSource Method
            fm.crystalReportViewer.ReportSource = cr; 
            fm.Show(); //Show the Report
        }

    }
}
