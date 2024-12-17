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
    public partial class SegmentDetails : UserControl
    {

        public SegmentDetails(int tsId)
        {
            ProgramController controller = new ProgramController();
            InitializeComponent();
            List<TripMemory> memoriesFromSegment = controller.GetAllTripMemoriesByTripSegmentId(tsId);
            List<Expense> expensesOfSegment = controller.GetAllExpensesByTripSegmentId(tsId);
            foreach (var expense in expensesOfSegment)
            {
                // Create a row with trip data
                ListViewItem item = new ListViewItem(expense.Id.ToString()); // First column (Id)
                item.SubItems.Add(expense.Name);                            // Second column (Name)
                item.SubItems.Add(expense.Value.ToString());  // Third column (StartDate)
                // Add row to ListView
                listView1.Items.Add(item);
                
            }
            label1.Text = tsId.ToString();


        }

 
    }
}
