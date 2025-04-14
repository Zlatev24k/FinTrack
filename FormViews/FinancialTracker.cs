namespace FinTrack.Views;

public partial class FinancialTracker : Form
{
    public FinancialTracker()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var incomeForm = new Income();
        incomeForm.ShowDialog();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var expensesForm = new Expenses();
        expensesForm.ShowDialog();
    }
}
