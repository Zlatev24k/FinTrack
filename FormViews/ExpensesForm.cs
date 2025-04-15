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
    }
}
