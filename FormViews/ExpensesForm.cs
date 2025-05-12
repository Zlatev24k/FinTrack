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
                string expenseWithDate = $"{item.Amount} - {item.TypeOfExpense.Name} - {((DateTime)item.Date).ToString("dd-MMMM-yyyy")}";
                listBox2.Items.Add(expenseWithDate);
                
                string expense = $"{item.Amount} - {item.TypeOfExpense.Name}";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string newExpenseType = textBox1.Text;
            listBox1.Items.Add(newExpenseType);
            financeServices.AddNewExpenseCategory(newExpenseType);
            textBox1.Clear();
            MessageBox.Show("The category was added!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string expenseType = listBox1.SelectedItem.ToString();
            decimal amount = decimal.Parse(textBox2.Text);
            balanceAmount = financeServices.GetBalanceAmount() - amount;
            financeServices.AddNewExpense(expenseType, amount, balanceAmount);
            this.DialogResult = DialogResult.OK;
            LoadExpense();
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
