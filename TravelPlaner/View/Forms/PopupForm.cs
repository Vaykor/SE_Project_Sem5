using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlaner.View.Forms
{
    public partial class PopupForm : Form
    {
        public PopupForm()
        {
            InitializeComponent();
        }
        public PopupForm(bool success)
        {
            InitializeComponent();
            if (success)
            {
                label1.Text = "Success! Your trip should now appear in the database.";
            }
            else
            {
                label1.Text = "The values which you have inserted are empty. Please correct them before submitting changes.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
