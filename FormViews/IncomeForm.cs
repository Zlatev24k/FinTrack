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
    public partial class IncomeForm: Form
    {
        FinanceServices financeServices;
        public IncomeForm()
        {
            financeServices = new FinanceServices();
            InitializeComponent();
            LoadIncome();
        }
        private void LoadIncome()
        {
            List<Income> incomeList = financeServices.LoadIncomesFromDB();
            foreach (var item in incomeList)
            {
                string income = $"{item.Amount} - {item.Description}";
                listBox2.Items.Add(income);
            }
        }
        
    }
}
