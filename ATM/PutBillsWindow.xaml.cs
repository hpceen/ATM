using System.Windows;

namespace ATM;

public partial class PutBillsWindow : Window
{
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
        var cashDepositedWindow = new CashDepositedWindow();
        cashDepositedWindow.Show();
        Close();
    }
}