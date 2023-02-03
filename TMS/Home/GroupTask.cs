using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Home
{
    public partial class GroupTask : Form
    {
        App_Code.CodeTMS obj = new App_Code.CodeTMS();
        static int taskid;
        public GroupTask()
        {
            InitializeComponent();
            LoadTheme();
            enabledisablebuttons(2);
            GetAllData();
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
            btnadd.ForeColor = ThemeColor.PrimaryColor;
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            btnmodify.ForeColor = ThemeColor.PrimaryColor;
            btncancel.ForeColor = ThemeColor.PrimaryColor;
            lblremark.ForeColor = ThemeColor.SecondaryColor;
            gbxtaskmanagement.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            txttaskName.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
        }
        public void enabledisablebuttons(int flag)
        {
            if (flag == 0) //
            {
                btnsave.Enabled = false;
                btnmodify.Enabled = false;
                btncancel.Enabled = false;
              
            }
            if (flag == 1) //Add Data
            {
                txttaskName.Enabled = true;
                txttaskName.Enabled = true;
                txttaskName.Select();
                btnsave.Enabled = true;
                btncancel.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
            }
            if (flag == 2)//modify and Cancel
            {
                txttaskName.Enabled = false;
                rtxtremark.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = false;
                btnmodify.Enabled = false;
                btnadd.Enabled = true;
            }
            if (flag == 3)
            {
                txttaskName.Enabled = true;
                rtxtremark.Enabled = true;
                btnadd.Enabled = false;
                btnsave.Enabled = false;
                btncancel.Enabled = true;
                btnmodify.Enabled = true;
                txttaskName.Enabled = false;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enabledisablebuttons(1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            obj.clearControls(gbxtaskmanagement);
            enabledisablebuttons(2);
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttaskName.Text == "")
                {
                    MessageBox.Show("Please enter Task!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Remark or Task Description!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                obj.FireQuery("Update tbl_taskgroup Set task_Name='" + txttaskName.Text + "',task_Des='" + rtxtremark.Text + "',Modifydate='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',Isactive='" + chkactive.Checked + "' where task_id='" + taskid + "'");
                obj.clearControls(gbxtaskmanagement);
                GetAllData();
                enabledisablebuttons(2);
                MessageBox.Show("Data modify Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttaskName.Text == "")
                {
                    MessageBox.Show("Please enter Task!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaskName.Select();
                    return;
                }
                if (rtxtremark.Text == "")
                {
                    MessageBox.Show("Please enter Remark! or Task Description", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rtxtremark.Select();
                    return;
                }
                if (chkactive.Checked == false)
                {
                    MessageBox.Show("Please Confirm Active Task!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                 obj.FireQuery("insert into tbl_taskgroup(task_Name,task_Des,isactive,Createddate)Values('" + txttaskName.Text + "','" + rtxtremark.Text + "','" + chkactive.Checked + "','" + DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss") + "')");
                 GetAllData();
                 obj.clearControls(gbxtaskmanagement);
                enabledisablebuttons(2);
                MessageBox.Show("Data Saved Successfully!", "TMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAllData()
        {
            dview.DataSource = null;
            dview.DataSource = obj.GetDataFromTable("select ROW_NUMBER()OVER (ORDER BY task_id)SLNO,task_Name as Task,task_Des as [Description],task_id as taskid,IsActive from tbl_taskgroup where IsActive=1").Tables[0];
            dview.Columns[0].Width = 150;
            dview.Columns[1].Width = 400;
            dview.Columns[2].Width = 500;
            dview.Columns[3].Visible = false;
            dview.Columns[4].Visible = false;
            dview.ReadOnly = true;

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                taskid = 0;
                int index = dview.CurrentRow.Index;
                if (index <= dview.RowCount - 1)
                {
                   
                    txttaskName.Text = Convert.ToString(dview.Rows[index].Cells[1].Value);
                    rtxtremark.Text = Convert.ToString(dview.Rows[index].Cells[2].Value);
                    taskid = Convert.ToInt32(dview.Rows[index].Cells[3].Value);
                    chkactive.Checked = Convert.ToBoolean(dview.Rows[index].Cells[4].Value);
                    enabledisablebuttons(3);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "TMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
