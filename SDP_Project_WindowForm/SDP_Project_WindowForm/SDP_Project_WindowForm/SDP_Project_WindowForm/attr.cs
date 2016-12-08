using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_Project_WindowForm
{
    public class attr
    {
        private string[] attrBook = new string[20];
        private string[] attrID = new string[20];

        public string[] attrID_value
        {
            get { return attrID; }
            set { attrID = value; }
        }

        public string[] sttrBook_value
        {
            get
            {
                return attrBook;
            }
            set
            {
                attrBook = value;
            }
        }
        public void clear()
        {
            for (int i = 0; i < attrBook.Length; i++)
            {
                attrBook[i] = null;
                attrID[i] = null;
            }
        }

        private ucABooking[] ucabooking = new ucABooking[20];

        public ucABooking[] getUCA
        {
            get { return ucabooking; }
            set { ucabooking = value; }
        }
    }
}
