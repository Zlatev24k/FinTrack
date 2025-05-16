using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void AddNewIncomeCategory(string newIncomeCategory)
        {
            using (var context = new BudgetContext())
            {
                TypeOfIncome newTypeOfIncome = new TypeOfIncome() { Name = newIncomeCategory };
                context.TypeOfIncomes.Add(newTypeOfIncome);
                context.SaveChanges();
            }
        }

        public void AddNewExpenseCategory(string newExpenseCategory)
        {
            using (var context = new BudgetContext())
            {
                TypeOfExpense newTypeOfExpense = new TypeOfExpense() { Name = newExpenseCategory };
                context.TypeOfExpenses.Add(newTypeOfExpense);
                context.SaveChanges();
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

        public decimal GetBalanceAmount()
        {
            using (var context = new BudgetContext())
            {
                Balance lastBalance = context.Balances.OrderBy(b => b.Id).Last();
                return lastBalance.Amount;
            }
        }
        public void AddNewIncome(string incomeType, decimal incomeAmount, decimal balanceAmountForIncome)
        {
            using (var context = new BudgetContext())
            {
                TypeOfIncome selectedTypeOfIncome = context.TypeOfIncomes.FirstOrDefault(ti => ti.Name == incomeType);
                Income newIncome = new Income() { Amount = incomeAmount, TypeOfIncomeId = selectedTypeOfIncome.Id };
                context.Incomes.Add(newIncome);
                context.SaveChanges();


                Balance balance = new Balance() { Amount = balanceAmountForIncome, IncomeId = newIncome.Id };
                context.Balances.Add(balance);
                context.SaveChanges();
            }
        }
        public void AddNewExpense(string expenseType, decimal expenseAmount, decimal balanceAmountForExpense)
        {
            using (var context = new BudgetContext())
            {
                TypeOfExpense selectedTypeOfExpense = context.TypeOfExpenses.FirstOrDefault(te => te.Name == expenseType);
                Expense newExpense = new Expense() { Amount = expenseAmount, TypeOfExpenseId = selectedTypeOfExpense.Id };
                context.Expenses.Add(newExpense);
                context.SaveChanges();


                Balance balance = new Balance() { Amount = balanceAmountForExpense, ExpenseId = newExpense.Id };
                context.Balances.Add(balance);
                context.SaveChanges();
            }
        }
        public void UpdateLastIncome(decimal newIncomeAmount)
        {
            using (var context = new BudgetContext())
            {
                Income lastIncome = context.Incomes.OrderBy(i => i.Id).Last();
                Balance lastBalance = context.Balances.OrderBy(b => b.Id).Last();
                lastBalance.Amount = lastBalance.Amount - lastIncome.Amount + newIncomeAmount;
                lastIncome.Amount = newIncomeAmount;
                context.SaveChanges();
            }
        }
        public void UpdateLastExpense(decimal newExpenseAmount)
        {
            using (var context = new BudgetContext())
            {
                Expense lastExpense = context.Expenses.OrderBy(e => e.Id).Last();
                Balance lastBalance = context.Balances.OrderBy(b => b.Id).Last();
                lastBalance.Amount = lastBalance.Amount + lastExpense.Amount - newExpenseAmount;
                lastExpense.Amount = newExpenseAmount;
                context.SaveChanges();
            }
        }

        public void DeleteLastIncome()
        {
            try
            {
                using (var context = new BudgetContext())
                {
                    Income lastIncome = context.Incomes.OrderBy(i => i.Id).Last();
                    context.Incomes.Remove(lastIncome);
                    Balance lastBalance = context.Balances.OrderBy(b => b.Id).Last();
                    lastBalance.Amount = lastBalance.Amount - lastIncome.Amount;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Последният приход е вече изтрит!");
            }
        }
        public void DeleteLastExpense()
        {
            try
            {
                using (var context = new BudgetContext())
                {
                    Expense lastExpense = context.Expenses.OrderBy(e => e.Id).Last();
                    context.Expenses.Remove(lastExpense);
                    Balance lastBalance = context.Balances.OrderBy(b => b.Id).Last();
                    lastBalance.Amount = lastBalance.Amount + lastExpense.Amount;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new Exception("Последният разход е вече изтрит!");
            }
            
        }
    }
}
