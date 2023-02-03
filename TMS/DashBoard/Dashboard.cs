using System;
using System.Windows.Forms;
using TMS.UI.Utilities;

namespace TMS.MDI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                Datacount();
                chartTaskCompleted.Series["Open"].Points.AddY(5);
                chartTaskCompleted.Series["InProgress"].Points.AddY(2);
                chartTaskCompleted.Series["Pending"].Points.AddY(8);
                chartTaskCompleted.Series["Monitoring"].Points.AddY(18);
                chartTaskCompleted.Series["Completed"].Points.AddY(90);
                chartTaskCompleted.Series["Handover"].Points.AddY(2);

                //chartTaskCompleted.Series["Open"].Points.AddY(5);
                //chartTaskCompleted.Series["InProgress"].Points.AddY(2);
                //chartTaskCompleted.Series["Pending"].Points.AddY(8);
                //chartTaskCompleted.Series["Monitoring"].Points.AddY(18);
                //chartTaskCompleted.Series["Completed"].Points.AddY(90);
                //chartTaskCompleted.Series["Handover"].Points.AddY(2);

                //chartTaskCompleted.Series["Open"].Points.AddY(5);
                //chartTaskCompleted.Series["InProgress"].Points.AddY(2);
                //chartTaskCompleted.Series["Pending"].Points.AddY(8);
                //chartTaskCompleted.Series["Monitoring"].Points.AddY(18);
                //chartTaskCompleted.Series["Completed"].Points.AddY(90);
                //chartTaskCompleted.Series["Handover"].Points.AddY(2);

                //chartTaskCompleted.Series["Open"].Points.AddY(5);
                //chartTaskCompleted.Series["InProgress"].Points.AddY(2);
                //chartTaskCompleted.Series["Pending"].Points.AddY(8);
                //chartTaskCompleted.Series["Monitoring"].Points.AddY(18);
                //chartTaskCompleted.Series["Completed"].Points.AddY(90);
                //chartTaskCompleted.Series["Handover"].Points.AddY(2);

                //chartTaskCompleted.Series["Open"].Points.AddY(5);
                //chartTaskCompleted.Series["InProgress"].Points.AddY(2);
                //chartTaskCompleted.Series["Pending"].Points.AddY(8);
                //chartTaskCompleted.Series["Monitoring"].Points.AddY(18);
                //chartTaskCompleted.Series["Completed"].Points.AddY(90);
                //chartTaskCompleted.Series["Handover"].Points.AddY(2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Datacount()
        {
            /*
            int emp_all = obj.GetDataCountFromTable("Select Count(*) as data from UserMaster");
            lblnumbers.Text = emp_all.ToString();
            int emp_Activeemp = obj.GetDataCountFromTable("Select Count(*) as data from UserMaster where Isactive=1");
            lblactiveonly.Text = emp_Activeemp.ToString();
            int totaltask = obj.GetDataCountFromTable("SELECT Count(*) as data FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid_assigned = dbo.UserMaster.empid");
            lbltotaltask.Text = totaltask.ToString();
            int taskcompleted = obj.GetDataCountFromTable("SELECT Count(*) as data FROM dbo.tbl_workitemsassignment INNER JOIN dbo.tbl_workitems ON dbo.tbl_workitemsassignment.assigmentitemId = dbo.tbl_workitems.Id INNER JOIN dbo.tbl_status ON dbo.tbl_workitemsassignment.Status = dbo.tbl_status.StatusId LEFT OUTER JOIN dbo.UserMaster ON dbo.tbl_workitemsassignment.empid_assigned = dbo.UserMaster.empid where dbo.tbl_workitemsassignment.Status=5");
            lbltaskcompleted.Text = taskcompleted.ToString();

            int totalactivity = obj.GetDataCountFromTable("Select Count(*) as data from Activity");
            lbltotalactivity.Text = totalactivity.ToString();

            int totalactivity_Active = obj.GetDataCountFromTable("Select Count(*) as data from Activity where Isactive=1");
            lblactiveactivity.Text = totalactivity_Active.ToString();
            */
        }
    }
}
