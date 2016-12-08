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
    public partial class ucCForm : UserControl
    {
        Data data;

        string info;
        public ucCForm()
        {
            InitializeComponent();
        }

        private string TourID;
        public ucCForm(cruise list, Data data)
        {
            this.data = data;

            InitializeComponent();
            lbl_day_ucCForm.Text = "Tour Day " + list.TourDay.ToString();
            lbl_cruise_ucCForm.Text = "Cruise Name : " + list.CruiseName.ToString();
            lbl_price_ucCForm.Text = "Price : " + list.RefPrice.ToString();
            info = list.Info;
            TourID = list.CruiseID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            new CruiseBooking(TourID, data).ShowDialog(); 

        }

        private void btn_showPDF_Click(object sender, EventArgs e)
        {
            new ViewerWindow(info).ShowDialog();

        }
    }
}
