using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlaner.Model.Classes.Context;
using TravelPlaner.Model.Classes.Database;

namespace TravelPlaner.Controller
{
    public class ProgramController
    {
        public Expense AddExpense(string Name, double Value)
        {
            var expense = new Expense { Name = Name, Value = Value };
            using (var context = new TravelPlannerContext())
            {
                //TO DO by Sara 
                //context.Add(expense);
                //context.SaveChanges();
                
            }
            Console.WriteLine("hejka");
            return expense;
        }
        //public AddEverythingElse
        //TODO by SARA
    }
}
