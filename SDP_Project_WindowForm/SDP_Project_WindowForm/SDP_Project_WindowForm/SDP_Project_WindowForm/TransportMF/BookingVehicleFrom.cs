using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Project_WindowForm
{
    public partial class BookingVehicleFrom : Form
    {
        Data data;

        DateTime departing1;
        DateTime returning2;
        private vehicle list;
        public vehicle convertdata
        {
            get { return list; }
            set { list = value; }
        }
        private string[] eqlist = new string[5];


        public BookingVehicleFrom()
        {
            InitializeComponent();

        }
        public BookingVehicleFrom(vehicle list, Data data)
        {
            this.data = data;

            InitializeComponent();
            convertdata = list;

        }

        private void BookingVehicleFrom_Load(object sender, EventArgs e)
        {
            calculateday();
            Capacity.Text = convertdata.Capacity.ToString();
            Vehicleshow.Text = convertdata.VehicleType;
            Vehiclename.Text = convertdata.VehicleName;
            Gear.Text = convertdata.Gear;
            Color.Text = convertdata.Color;
            label20.Text = convertdata.VehicleID;

            using (var entity = new sdp_datebaseEntities())
            {
                var order = (from list in entity.vehiclebooking
                             select list).FirstOrDefault();
                var order_lastRow = (from list in entity.vehiclebooking
                                     orderby list.VehicleOrderID descending
                                     select list).FirstOrDefault();

                if (order == null)
                {
                    label18.Text = "VH000";
                }
                else
                {
                    string s = order_lastRow.VehicleOrderID;
                    int i = Int32.Parse(s.Substring(2, 3));
                    i++;
                    label18.Text = "VH" + i.ToString("000");
                }
            }
            pictureBox1.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\Transportphoto\" + convertdata.Photo);
            pictureBox2.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\EquipmentPhoto\e01.png");
            pictureBox6.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\EquipmentPhoto\e02.png");
            pictureBox5.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\EquipmentPhoto\e03.png");
            pictureBox4.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\EquipmentPhoto\e04.png");
            pictureBox3.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"..\..\EquipmentPhoto\e05.png");
            if (convertdata.VehicleType == "car")
            {
                checkBox2.Enabled = false;
            }
            if (convertdata.VehicleType == "coach")
            {
                checkBox1.Enabled = false;
                checkBox5.Enabled = false;
                checkBox4.Enabled = false;
                checkBox3.Enabled = false;
            }
        }

        private void departing_ValueChanged(object sender, EventArgs e)
        {
            if (returning.Value.Date < departing.Value.Date)
            {
                returning.Value = departing.Value.Date;
                return;
            }
            calculateday();
        }

        public void calculateday()
        {
            departing1 = departing.Value.Date;
            returning2 = returning.Value.Date;
            double totalday = (double)(returning2 - departing1).TotalDays;
            dayselect.Text = totalday.ToString();
            transportcharge.Text = (convertdata.Price * Convert.ToDecimal(dayselect.Text)).ToString();

        }

        private void returning_ValueChanged(object sender, EventArgs e)
        {
            if (returning.Value.Date < departing.Value.Date)
            {
                returning.Value = departing.Value.Date;
                return;
            }
            calculateday();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) + 28.60).ToString();
                eqlist[0] = "e01";
            }
            if (checkBox1.Checked == false)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) - 28.60).ToString();
            }
        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) + 71.60).ToString();
                eqlist[1] = "e02";
            }
            if (checkBox5.Checked == false)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) - 71.60).ToString();
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) + 78.8).ToString();
                eqlist[2] = "e03";

            }
            if (checkBox4.Checked == false)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) - 78.8).ToString();
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) + 100.3).ToString();
                eqlist[3] = "e04";

            }
            if (checkBox3.Checked == false)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) - 100.3).ToString();
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) + 20).ToString();
                eqlist[4] = "e05";
            }
            if (checkBox2.Checked == false)
            {
                equipmentcharge.Text = (Convert.ToDouble(equipmentcharge.Text) - 20).ToString();
            }
        }

        private void transportcharge_TextChanged(object sender, EventArgs e)
        {
            total.Text = (Convert.ToDouble(transportcharge.Text) + (Convert.ToDouble(equipmentcharge.Text))).ToString();
        }

        private void equipmentcharge_TextChanged(object sender, EventArgs e)
        {
            total.Text = (Convert.ToDouble(transportcharge.Text) + (Convert.ToDouble(equipmentcharge.Text))).ToString();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to submit a new order?", "Confirm", MessageBoxButtons.YesNo);
            if (dayselect.Text == "0")
            {
                MessageBox.Show("Please select at least one day ticket!");
                return;
            }
            if (dr == DialogResult.Yes)
            {
                insertOrder();
                insertEquip();
                MessageBox.Show("Create new order successfully.");

            }
            else if (dr == DialogResult.No)
            {
                this.Close();
            }
            this.Close();
        }

        private void insertOrder()
        {

            using (var entity = new sdp_datebaseEntities())
            {
                var fb = entity.Set<vehiclebooking>();
                
                fb.Add(new vehiclebooking
                {
                    VehicleOrderID = label18.Text,
                    VehicleID = label20.Text,
                    PickupDate = departing1,
                    DropoffDate = returning2,
                    VehicleBookPrice = Convert.ToDecimal(total.Text)

                });
                    

                entity.SaveChanges();
            }

            data.transportID = label18.Text;
            orderInsert or = new orderInsert("transport", data);

        }

        private void insertEquip()
        {

            using (var entity2 = new sdp_datebaseEntities())
            {
                var fb1 = entity2.Set<equipmentlist>();
                for (int i = 0; i < 5; i++)
                {
                    if (eqlist[i] != null)
                    {
                        fb1.Add(new equipmentlist
                        {
                            VehicleBookingID = label18.Text,
                            //你得閒幫我睇下入邊個落去 佢一次淨係可以入一個Equipment 咁我應該點insert 我食飯
                            EquipID = eqlist[i],
                            EquipBookPrice = Convert.ToDecimal(equipmentcharge.Text)
                        });
                    }
                }
                entity2.SaveChanges();
            }

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
