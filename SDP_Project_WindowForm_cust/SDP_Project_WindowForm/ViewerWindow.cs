using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAcroPDFLib;
using AcroPDFLib;


namespace SDP_Project_WindowForm
{
    public partial class ViewerWindow : Form
    {
        public ViewerWindow()
        {
            InitializeComponent();
            AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
            pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            pdf.Enabled = true;
            pdf.Location = new System.Drawing.Point(0, 0);
            pdf.Name = "pdfReader";
            pdf.OcxState = ((System.Windows.Forms.AxHost.State)
                (new System.ComponentModel.ComponentResourceManager(typeof(ViewerWindow)).GetObject("pdfReader.OcxState")));
            pdf.TabIndex = 1;

            // Add pdf viewer to current form        
            this.Controls.Add(pdf);

            //try
            //{
            //    pdf.LoadFile(@"C:\EMM10A.pdf");
            //    pdf.setView("Fit");
            //    pdf.Visible = true;
            //}
            //catch (Exception) { }
        }

        public ViewerWindow(string Cinfo)
        {
            InitializeComponent();

            AxAcroPDFLib.AxAcroPDF pdf = new AxAcroPDFLib.AxAcroPDF();
            pdf.Dock = System.Windows.Forms.DockStyle.Fill;
            pdf.Enabled = true;
            pdf.Location = new System.Drawing.Point(0, 0);
            pdf.Name = "pdfReader";
            pdf.OcxState = ((System.Windows.Forms.AxHost.State)
                (new System.ComponentModel.ComponentResourceManager(typeof(ViewerWindow)).GetObject("pdfReader.OcxState")));
            pdf.TabIndex = 1;

            // Add pdf viewer to current form        
            this.Controls.Add(pdf);

           
            //pdf.LoadFile(@"C:\EMM10A.pdf");
            //pdf.setView("Fit");
            //pdf.Visible = true;
        }

        
    }
}
