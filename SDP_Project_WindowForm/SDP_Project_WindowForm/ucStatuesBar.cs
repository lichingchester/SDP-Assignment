using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project_WindowForm
{
    public partial class ucStatuesBar : UserControl
    {
        public ucStatuesBar()
        {
            InitializeComponent();
        }

        public string sg_lblCurrentStatus{ 
            get { return lbl_currentStatus_uc.Text; }
            set { lbl_currentStatus_uc.Text = value; }
        }

        public string sg_lblCustomerSelection {
            get { return lbl_currentStatus_customerSelection.Text; }
            set { lbl_currentStatus_customerSelection.Text = value; }
        }

        private void ucStatuesBar_Load(object sender, EventArgs e)
        {
            lbl_currentStatus_uc.Text = "";
            lbl_currentTime_uc.Text = "";
            lbl_currentStatus_customerSelection.Text = "";

            timer1.Interval = 1000;
            timer1.Start();

            //DateTime today = DateTime.Now;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_currentTime_uc.Text = "Time now is " + DateTime.Now.ToLongTimeString();
        }
    }
}
