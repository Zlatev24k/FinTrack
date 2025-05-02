using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinTrack.Models;
using FinTrack.Services;

namespace FinTrack.Views
{
    public partial class IncomeForm : Form
    {
        FinanceServices financeServices;
        public decimal balanceAmount;
        public IncomeForm()
        {
            financeServices = new FinanceServices();
            InitializeComponent();
            LoadIncome();
            LoadTypeOfIncomes();
        }
        private void LoadIncome()
        {
            List<Income> incomeList = financeServices.LoadIncomesFromDB();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox5.Items.Clear();
            foreach (var item in incomeList)
            {
                string incomeWithDate= $"{item.Amount} - {item.TypeOfIncome.Name}  - {((DateTime)item.Date).ToString("dd-MMMM-yyyy")}";
                listBox2.Items.Add(incomeWithDate);

                string income = $"{item.Amount} - {item.TypeOfIncome.Name}";
                listBox3.Items.Add(income);
                listBox5.Items.Add(income);
            }
        }

        private void LoadTypeOfIncomes()
        {
            List<TypeOfIncome> typeOfIncomesList = financeServices.LoadTypeOfIncomesFromDB();
            foreach (var item in typeOfIncomesList)
            {
                string typeOfIncome = $"{item.Name}";
                listBox1.Items.Add(typeOfIncome);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newIncomeType = textBox1.Text;
            listBox1.Items.Add(newIncomeType);
            using (var context = new BudgetContext())
            {
                TypeOfIncome newTypeOfIncome = new TypeOfIncome() { Name = newIncomeType };
                context.TypeOfIncomes.Add(newTypeOfIncome);
                context.SaveChanges();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string incomeType = listBox1.SelectedItem.ToString();
            decimal amount = decimal.Parse(textBox2.Text);
            balanceAmount = financeServices.GetBalanceAmount() + amount;
            financeServices.AddNewIncome(incomeType, amount, balanceAmount);
            this.DialogResult = DialogResult.OK;
            LoadIncome();

            /*
            using (var context = new BudgetContext())
            {
                
                TypeOfIncome selectedTypeOfIncome = context.TypeOfIncomes.FirstOrDefault(ti => ti.Name == listBox1.SelectedItem.ToString());
                decimal amount = decimal.Parse(textBox2.Text);
                Income newIncome = new Income() { Amount = amount, TypeOfIncomeId = selectedTypeOfIncome.Id };
                context.Incomes.Add(newIncome);
                context.SaveChanges();


                balanceAmount = financeServices.GetBalanceAmount() + newIncome.Amount;
                Balance balance = new Balance() { Amount = balanceAmount, IncomeId = newIncome.Id };
                context.Balances.Add(balance);
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                LoadIncome();
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal newAmount = decimal.Parse(textBox3.Text);
            financeServices.UpdateLastIncome(newAmount);
            this.DialogResult = DialogResult.OK;
            balanceAmount = financeServices.GetBalanceAmount();
            LoadIncome();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            financeServices.DeleteLastIncome();
            this.DialogResult = DialogResult.OK;
            balanceAmount = financeServices.GetBalanceAmount();
            LoadIncome();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
