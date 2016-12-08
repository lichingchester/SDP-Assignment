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
    public partial class TransportBooking : UserControl
    {
        Data data;

        private vehicle list;
        public vehicle convertdata
        {
            get { return list; }
            set { list = value; }
        }



        public TransportBooking(vehicle list, Data data)
        {
            this.data = data;

            InitializeComponent();
            convertdata = list;

            capacity.Text = list.Capacity.ToString();
            Vehicletype1.Text = list.VehicleType;
            showname.Text = list.VehicleName;
            price.Text = list.Price.ToString();
            gear.Text = list.Gear;
            color.Text = list.Color;
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Transportphoto\" + list.Photo);


        }
        public TransportBooking()
        {
            InitializeComponent();
        }

        private void choosecar_Click(object sender, EventArgs e)
        {
        }

        private void TransportBooking_Load(object sender, EventArgs e)
        {

        }

        private void choosecar_Click_1(object sender, EventArgs e)
        {
            //if (data.custID == null)
            //{
            //    MessageBox.Show("You have to select a customer!");
            //    return;
            //}
            new BookingVehicleFrom(convertdata, data).ShowDialog();

        }
    }
}
