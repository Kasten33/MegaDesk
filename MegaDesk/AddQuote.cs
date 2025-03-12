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
    public partial class AddQuote: Form
    {
        private DeskQuote deskQuote = new DeskQuote();
        public AddQuote()
        {
            InitializeComponent();
        }

        private void ToForm1_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void MaterialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WidthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newWidth;
                bool isNum = Int32.TryParse(input.Text, out newWidth);
                if (isNum)
                {
                    deskQuote.desk.Width = newWidth;
                    WidthErrorProvider.SetError(this.WidthBox, "");
                }
                else
                {
                    WidthErrorProvider.SetError(this.WidthBox, "Enter a number.");
                }
            }
            catch (Exception)
            {
                WidthErrorProvider.SetError(this.WidthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void DepthBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox input = (TextBox)sender;
            try
            {
                int newDepth;
                bool isNum = Int32.TryParse(input.Text, out newDepth);
                if (isNum)
                {
                    deskQuote.desk.Depth = newDepth;
                    DepthErrorProvider.SetError(this.DepthBox, "");
                }
                else
                {
                    DepthErrorProvider.SetError(this.DepthBox, "Enter a number.");
                }
            }
            catch (Exception)
            {
                DepthErrorProvider.SetError(this.DepthBox, "Input must be between 24 and 96 inches.");
            }
        }

        private void DrawerInput_Validation(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                int DCount;
                bool isNum = Int32.TryParse(input.Text, out DCount);
                if (isNum)
                {
                    deskQuote.desk.Depth = DCount;
                    DCounterErrorProvider.SetError(this.DrawerInput, "");
                }
                else
                {
                    DCounterErrorProvider.SetError(this.DrawerInput, "Enter a number.");
                }
            }
            catch (Exception)
            {
                DCounterErrorProvider.SetError(this.DrawerInput, "Input must be  Number on the Drop down.");
            }
        }

        private void Shipping_Validation(object sender, CancelEventArgs e)
        {
            ComboBox input = (ComboBox)sender;
            try
            {
                int Ship;
                bool isNum = Int32.TryParse(input.Text, out Ship);
                if (isNum)
                {
                    deskQuote.desk.Depth = Ship;
                    ShippingErrorProvider.SetError(this.ShippingComboBox, "");
                }
                else
                {
                    ShippingErrorProvider.SetError(this.ShippingComboBox, "Enter a number.");
                }
            }
            catch (Exception)
            {
                ShippingErrorProvider.SetError(this.ShippingComboBox, "Input must be a Number on the Drop down.");
            }
        }

        private void SubmitOrder(object sender, EventArgs e)
        {
            if (WidthBox.Text.Length == 0 || DepthBox.Text.Length == 0 || DrawerInput.Text.Length == 0) return;
            int surfaceArea = deskQuote.desk.getSurfaceArea();
            string orderDate = DateTime.Now.ToString();
            int shipping = deskQuote.desk.ShippingDays;
            DisplayQuote frm = new DisplayQuote(deskQuote);
            frm.Show();
            Close();
        }
    }
}
