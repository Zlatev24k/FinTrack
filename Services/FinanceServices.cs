using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Services
{
    public class FinanceServices
    {

        public List<Income> LoadIncomesFromDB()
        {
            using (var context = new BudgetContext())
            {
                List<Income> incomes = context.Incomes
                    .Include(i => i.TypeOfIncome)
                    .ToList();

                return incomes;
            }
        }

        public List<Expense> LoadExpensesFromDB()
        {
            using (var context = new BudgetContext())
            {
                List<Expense> expenses = context.Expenses
                    .Include(i => i.TypeOfExpense)
                    .ToList();

                return expenses;
            }
        }

        public List<TypeOfExpense> LoadTypeOfExpensesFromDB()
        {
            using (var context = new BudgetContext())
            {
                List<TypeOfExpense> typeOfExpenses = context.TypeOfExpenses.ToList();

                return typeOfExpenses;
            }
        }

        public List<TypeOfIncome> LoadTypeOfIncomesFromDB()
        {
            using (var context = new BudgetContext())
            {
                List<TypeOfIncome> typeOfIncomes = context.TypeOfIncomes.ToList();

                return typeOfIncomes;
            }
        }
    }
}
