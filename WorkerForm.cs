using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS0609anJian
{
    public partial class WorkerForm : Form
    {


        public WorkerForm()
        {
            InitializeComponent();
        }

        private void WorkerForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“cMSGanJianDataSet.tblWorker”中。您可以根据需要移动或移除它。
            this.tblWorkerTableAdapter.Fill(this.cMSGanJianDataSet.tblWorker);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.cMSGanJianDataSet.tblWorker.Clear();
            tblWorkerTableAdapter.Fill(this.cMSGanJianDataSet.tblWorker);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tblWorkerTableAdapter.Update(this.cMSGanJianDataSet.tblWorker);
            MessageBox.Show("The Worker table is updated.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.cMSGanJianDataSet.tblWorker.Clear();
            tblWorkerTableAdapter.Fill(this.cMSGanJianDataSet.tblWorker);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
          //  MainForm newForm = new MainForm();
         //   newForm.Show();
         //   this.Hide();
        }
    }
}
