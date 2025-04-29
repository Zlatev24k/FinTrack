using FinTrack.Models;
using FinTrack.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinTrack.Views
{
    public partial class ExpensesForm : Form
    {
        FinanceServices financeServices;
        public decimal balanceAmount;
        public ExpensesForm()
        {
            financeServices = new FinanceServices();
            InitializeComponent();
            LoadExpense();
            LoadTypeOfExpenses();
        }
        private void LoadExpense()
        {
            List<Expense> expenseList = financeServices.LoadExpensesFromDB();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            foreach (var item in expenseList)
            {
                string expense = $"{item.Amount} - {item.TypeOfExpense.Name}";
                listBox2.Items.Add(expense);
                listBox3.Items.Add(expense);
                listBox4.Items.Add(expense);
            }
        }

        private void LoadTypeOfExpenses()
        {
            List<TypeOfExpense> typeOfExpensesList = financeServices.LoadTypeOfExpensesFromDB();
            foreach (var item in typeOfExpensesList)
            {
                string typeOfExpense = $"{item.Name}";
                listBox1.Items.Add(typeOfExpense);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newExpenseType = textBox1.Text;
            listBox1.Items.Add(newExpenseType);
            using (var context = new BudgetContext())
            {
                TypeOfExpense newTypeOfExpense = new TypeOfExpense() { Name = newExpenseType };
                context.TypeOfExpenses.Add(newTypeOfExpense);
                context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new BudgetContext())
            {
                TypeOfExpense selectedTypeOfExpense = context.TypeOfExpenses.FirstOrDefault(te => te.Name == listBox1.SelectedItem.ToString());
                decimal amount = decimal.Parse(textBox2.Text);
                Expense newExpense = new Expense() { Amount = amount, TypeOfExpenseId = selectedTypeOfExpense.Id };
                context.Expenses.Add(newExpense);
                context.SaveChanges();


                balanceAmount = financeServices.GetBalanceAmount() - newExpense.Amount;
                Balance balance = new Balance() { Amount = balanceAmount, ExpenseId = newExpense.Id };
                context.Balances.Add(balance);
                context.SaveChanges();
                //balanceAmount = financeServices.GetBalanceAmount();
                this.DialogResult = DialogResult.OK;
                LoadExpense();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal newAmount = decimal.Parse(textBox3.Text);
            financeServices.UpdateLastExpense(newAmount);
            this.DialogResult = DialogResult.OK;
            balanceAmount = financeServices.GetBalanceAmount();
            LoadExpense();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            financeServices.DeleteLastExpense();
            this.DialogResult = DialogResult.OK;
            balanceAmount = financeServices.GetBalanceAmount();
            LoadExpense();
        }
    }
}
