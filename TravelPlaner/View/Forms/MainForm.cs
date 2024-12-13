using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlaner.Controller;
using TravelPlaner.Model.Classes.Database;

namespace TravelPlaner.View.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ProgramController controller = new ProgramController();
            Expense expense = controller.AddExpense("Hejka", 1.20);
            label1.Text = expense.Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
