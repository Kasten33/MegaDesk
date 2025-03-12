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
    public partial class ViewQuotes: Form
    {
        public ViewQuotes()
        {
            InitializeComponent();
        }

        private void ViewQuotes_Load(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString();
        }

        private void BackToForm_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
