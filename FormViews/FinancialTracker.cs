using FinTrack.Services;
namespace FinTrack.Views;

public partial class FinancialTracker : Form
{
    FinanceServices financeServices;
    public FinancialTracker()
    {
        financeServices = new FinanceServices();
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var incomeForm = new IncomeForm();
        if (incomeForm.ShowDialog() == DialogResult.OK)
        {
            textBox1.Text = incomeForm.balanceAmount.ToString();

        }
        //!//
        
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var expenseForm = new ExpensesForm();
        if (expenseForm.ShowDialog() == DialogResult.OK)
        {
            textBox1.Text = expenseForm.balanceAmount.ToString();
        }
        //var expensesForm = new ExpensesForm();
        //expensesForm.ShowDialog();
    }

    private void FinancialTracker_Load(object sender, EventArgs e)
    {
        textBox1.Text = financeServices.GetBalanceAmount().ToString();
    }
}
