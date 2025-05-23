﻿using System;
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
                string newIncomeType = textBox1.Text;
                listBox1.Items.Add(newIncomeType);
                financeServices.AddNewIncomeCategory(newIncomeType);
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
                string incomeType = listBox1.SelectedItem.ToString();
                decimal amount = decimal.Parse(textBox2.Text);
                balanceAmount = financeServices.GetBalanceAmount() + amount;
                financeServices.AddNewIncome(incomeType, amount, balanceAmount);
                MessageBox.Show("The income was added!");
                this.DialogResult = DialogResult.OK;
                LoadIncome();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                financeServices.UpdateLastIncome(newAmount);
                MessageBox.Show("The income was updated!");
                this.DialogResult = DialogResult.OK;
                balanceAmount = financeServices.GetBalanceAmount();
                LoadIncome();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                financeServices.DeleteLastIncome();
                MessageBox.Show("The income was deleted!");
                this.DialogResult = DialogResult.OK;
                balanceAmount = financeServices.GetBalanceAmount();
                LoadIncome();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
