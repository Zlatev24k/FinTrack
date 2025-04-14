using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrack.Models;

namespace FinTrack.Services
{
    public class FinanceServices
    {

        public List<string> LoadIncomes()
        {
            List<string> incomesStr = new List<string>();
            using (var context = new BudgetContext())
            {
                List<Income> incomes = context.Incomes.ToList();
               
                foreach (var item in incomes)
                {
                    string income = $"";
                }
            }
            return incomesStr;
        }
        
    }
}
