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

        public List<Income> LoadIncomesFromDB()
        {
            using (var context = new BudgetContext())
            {
                List<Income> incomes = context.Incomes.ToList();

                return incomes;
            }

        }

    }
}
