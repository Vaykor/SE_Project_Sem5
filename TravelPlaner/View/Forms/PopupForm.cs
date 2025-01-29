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
        public PopupForm(int message)
        {
            InitializeComponent();
            switch (message)
            {
                case 1:
                    label1.Text = "Success! Your trip should now appear in the database.";
                    break;
                case 2:
                    label1.Text = "The values which you have inserted are empty. Please correct them before submitting changes.";
                    break;
                case 3:
                    label1.Text = "Please insert a City into the text field, before searching for recommended landmarks.";
                    break;
                case 4:
                    label1.Text = "One of the required textfields is empty or invalid. Please correct it before attempting to add to, or update the database.";
                    break;
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
