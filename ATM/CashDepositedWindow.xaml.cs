using System.Windows;

namespace ATM;

public partial class CashDepositedWindow : Window
{
    public CashDepositedWindow()
    {
        InitializeComponent();
    }

    private void cancelButton_Click(object sender, RoutedEventArgs e)
    {
        var takeBillsDepositWindow = new TakeBillsDepositWindow();
        takeBillsDepositWindow.Show();
        Close();
    }

    private void continueButton_Click(object sender, RoutedEventArgs e)
    {
        var printReceiptDepositWindow = new PrintReceiptDepositWindow();
        printReceiptDepositWindow.Show();
        Close();
    }
}