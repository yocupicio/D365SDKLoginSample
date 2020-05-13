using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D365SDKLoginSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new ExampleLoginForm();
            frm.ShowDialog();
            // If the login process completed, assign the connected service to the CRMServiceClient var 
            if (frm.CrmConnectionMgr != null && frm.CrmConnectionMgr.CrmSvc != null && frm.CrmConnectionMgr.CrmSvc.IsReady)
            {
                //service = frm.CrmConnectionMgr.CrmSvc;
            }
            // If you are not connected to CRM; display the last error and last CRM excption
            else
            {
                MessageBox.Show("The connection to CRM failed or was cancelled by the user.");
            }
        }
    }
}
