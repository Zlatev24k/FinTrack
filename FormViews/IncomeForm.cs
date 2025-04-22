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
            foreach (var item in incomeList)
            {
                string income = $"{item.Amount} - {item.TypeOfIncome.Name}";
                listBox2.Items.Add(income);
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
    }
}
