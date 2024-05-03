using System.Windows;

namespace ATM;

public partial class PrintReceiptWithdrawWindow : Window
{
    public PrintReceiptWithdrawWindow()
    {
        InitializeComponent();
    }

    private void NoReceipt_Click(object sender, RoutedEventArgs e)
    {
        var takeBillsWithdrawWindow = new TakeBillsWithdrawWindow();
        takeBillsWithdrawWindow.Show();
        Close();
    }

    private void YesReceipt_Click(object sender, RoutedEventArgs e)
    {
        //TODO печать чека WithdrawWindow
        var takeBillsWithdrawWindow = new TakeBillsWithdrawWindow();
        takeBillsWithdrawWindow.Show();
        Close();
    }
}