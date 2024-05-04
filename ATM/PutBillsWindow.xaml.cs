using System.Windows;

namespace ATM;

public partial class PutBillsWindow : Window
{
    private const int DepositedSum = 12000;

    public PutBillsWindow()
    {
        InitializeComponent();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseProcedureWindow = new ChooseProcedureWindow();
        chooseProcedureWindow.Show();
        Close();
    }

    private void ContinueButton_Click(object sender, RoutedEventArgs e)
    {
        var cashDepositedWindow = new CashDepositedWindow(DepositedSum);
        cashDepositedWindow.Show();
        Close();
    }
}