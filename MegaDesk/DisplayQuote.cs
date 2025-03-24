using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote: Form
    {
        private DeskQuote DeskQuote;

        public DisplayQuote(DeskQuote deskQuote, MainMenu mainMenu)
        {
            InitializeComponent();
            DeskQuote = deskQuote;
            Tag = mainMenu;
        }
        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            CustomerName.Text = DeskQuote.customerName;
            QuoteDate.Text = DeskQuote.orderDate;
            string width = Convert.ToString(DeskQuote.desk.Width);
            string depth = Convert.ToString(DeskQuote.desk.Depth);
            string drawers = Convert.ToString(DeskQuote.desk.DrawerNumber);
            string shippingDays = Convert.ToString(DeskQuote.desk.ShippingDays);
            string material = DeskQuote.desk.Material;
            int SurfaceTotal = DeskQuote.desk.Width * DeskQuote.desk.Depth;

            string total = Convert.ToString(SurfaceTotal);

            WidthLabel.Text = width;
            DepthLabel.Text = depth;
            DrawerLabel.Text = drawers + " Drawers";
            MaterialLabel.Text = material;
            DeliveryLabel.Text = shippingDays + " Days";
            TotalSizeLabel.Text = total + " in^2";

        }

        private void BackToForm1_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
