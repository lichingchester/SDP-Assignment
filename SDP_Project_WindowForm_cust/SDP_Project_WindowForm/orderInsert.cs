using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project_WindowForm
{
    public class orderInsert
    {
        Data data;
        string orderIDD;

        public orderInsert(string mode, Data data) {
            this.data = data;

            using (var entity = new sdp_datebaseEntities())
            {
                var row = (from list in entity.order
                           select list).FirstOrDefault();
                var rowLast = (from list in entity.order
                               orderby list.OrderID descending
                               select list).FirstOrDefault();

                string id;
                int i = 0;
                if (row == null)
                {
                    id = "OR000";
                }
                else
                {
                    id = rowLast.OrderID;
                    i = Int32.Parse(id.Substring(2, 3));
                    i++;
                    id = "OR" + i.ToString("000");
                }
                orderIDD = id;
            }

            switch (mode) { 
                case "hotel":
                    insertHotel();
                    break;
                case "cruise":
                    insertCruise();
                    break;
                case "attraction":
                    insertAttraction();
                    break;
                case "transport":
                    insertTransport();
                    break;
            }
        }

        public orderInsert(int mode, Data data) {
            this.data = data;



            using (var entity = new sdp_datebaseEntities()) {
                var row = (from list in entity.order
                          select list).FirstOrDefault();
                var rowLast = (from list in entity.order
                              orderby list.OrderID descending
                              select list).FirstOrDefault();

                string id;
                string id_return = "";
                int i = 0;
                if(row == null){
                    id = "OR000";
                }else{
                    id = rowLast.OrderID;
                    i = Int32.Parse(id.Substring(2,3));
                    i++;
                    id = "OR" + i.ToString("000");
                }
                if (mode == 1) {
                    i++;
                    id_return = "OR" + i.ToString("000");
                }

                var or = entity.Set<order>();
                or.Add(new order
                {
                    OrderID = id,
                    CustID = data.custID,
                    StaffID = data.stfID,
                    OrderDate = DateTime.Today,
                    FlightOrderID = data.flightOrderID,
                    HotelOrderID = null,
                    AttractionOrderID = null,
                    CruiseOrderID = null,
                    TransportOrderID = null,
                    isTemp = data.savedID
                });

                if (mode == 1) {
                    or.Add(new order
                    {
                        OrderID = id_return,
                        CustID = data.custID,
                        StaffID = data.stfID,
                        OrderDate = DateTime.Today,
                        FlightOrderID = data.flightOrderID_return,
                        HotelOrderID = null,
                        AttractionOrderID = null,
                        CruiseOrderID = null,
                        TransportOrderID = null,
                        isTemp = data.savedID
                    });
                }

                entity.SaveChanges();
            }
        }

        private void insertHotel() {
            using (var entity = new sdp_datebaseEntities())
            {
                var or = entity.Set<order>();
                or.Add(new order
                {
                    OrderID = orderIDD,
                    CustID = data.custID,
                    StaffID = data.stfID,
                    OrderDate = DateTime.Today,
                    FlightOrderID = null,
                    HotelOrderID = data.hotelID,
                    AttractionOrderID = null,
                    CruiseOrderID = null,
                    TransportOrderID = null,
                    isTemp = data.savedID
                });

                entity.SaveChanges();
            }
        }

        private void insertCruise() {
            using (var entity = new sdp_datebaseEntities())
            {
                var or = entity.Set<order>();
                or.Add(new order
                {
                    OrderID = orderIDD,
                    CustID = data.custID,
                    StaffID = data.stfID,
                    OrderDate = DateTime.Today,
                    FlightOrderID = null,
                    HotelOrderID = null,
                    AttractionOrderID = null,
                    CruiseOrderID = data.cruiseID,
                    TransportOrderID = null,
                    isTemp = data.savedID
                });

                entity.SaveChanges();
            }
        }

        private void insertAttraction() {
            
            int num = Int32.Parse(orderIDD.Substring(2, 3));
            
            using (var entity = new sdp_datebaseEntities())
            {
                for(int i = 0; i < 20; i++){
                   if(data.attrID[i] != null){
                        var or = entity.Set<order>();
                        or.Add(new order
                        {
                            OrderID = "OR" + (num + i).ToString("000"),
                            CustID = data.custID,
                            StaffID = data.stfID,
                            OrderDate = DateTime.Today,
                            FlightOrderID = null,
                            HotelOrderID = null,
                            AttractionOrderID = data.attrID[i],
                            CruiseOrderID = null,
                            TransportOrderID = null,
                            isTemp = data.savedID
                        });
                    }
                }
                entity.SaveChanges();
            }
        }

        private void insertTransport() {
            using (var entity = new sdp_datebaseEntities())
            {
                var or = entity.Set<order>();
                or.Add(new order
                {
                    OrderID = orderIDD,
                    CustID = data.custID,
                    StaffID = data.stfID,
                    OrderDate = DateTime.Today,
                    FlightOrderID = null,
                    HotelOrderID = null,
                    AttractionOrderID = null,
                    CruiseOrderID = null,
                    TransportOrderID = data.transportID,
                    isTemp = data.savedID
                });

                entity.SaveChanges();
            }
        }

    }
}
