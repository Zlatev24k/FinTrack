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
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Напишете категория!");
                return;
            }
            if (textBox1.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Използвайте само букви в имената на категориите!");
                return;
            }
            else
            {
                string newExpenseType = textBox1.Text;
                listBox1.Items.Add(newExpenseType);
                financeServices.AddNewExpenseCategory(newExpenseType);
                textBox1.Clear();
                MessageBox.Show("The category was added!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Напишете сума!");
                return;
            }
            if (!decimal.TryParse(textBox2.Text, out decimal value))
            {
                MessageBox.Show("Въведете число!");
                return;
            }
            if (decimal.Parse(textBox2.Text) <= 0)
            {
                MessageBox.Show("Сумата трябва да е положителна!");
                return;
            }
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Изберете категория!");
                return;
            }
            else
            {
                string expenseType = listBox1.SelectedItem.ToString();
                decimal amount = decimal.Parse(textBox2.Text);
                balanceAmount = financeServices.GetBalanceAmount() - amount;
                financeServices.AddNewExpense(expenseType, amount, balanceAmount);
                MessageBox.Show("The expense was added!");
                this.DialogResult = DialogResult.OK;
                LoadExpense();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Напишете нова сума!");
                return;
            }
            if (!decimal.TryParse(textBox3.Text, out decimal value))
            {
                MessageBox.Show("Въведете число!");
                return;
            }
            if (decimal.Parse(textBox3.Text) <= 0)
            {
                MessageBox.Show("Сумата трябва да е положителна!");
                return;
            }
            else
            {
                decimal newAmount = decimal.Parse(textBox3.Text);
                financeServices.UpdateLastExpense(newAmount);
                MessageBox.Show("The expense was updated!");
                this.DialogResult = DialogResult.OK;
                balanceAmount = financeServices.GetBalanceAmount();
                LoadExpense();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                financeServices.DeleteLastExpense();
                MessageBox.Show("The expense was deleted!");
                this.DialogResult = DialogResult.OK;
                balanceAmount = financeServices.GetBalanceAmount();
                LoadExpense();
            }
            catch (Exception е)
            {
                MessageBox.Show(е.Message);
            }
        }
    }
}
