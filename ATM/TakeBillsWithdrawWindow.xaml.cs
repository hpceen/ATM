using System.Windows;

namespace ATM;

public partial class TakeBillsWithdrawWindow : Window
{
    public TakeBillsWithdrawWindow()
    {
        InitializeComponent();
    }

    private void TakeBills_Click(object sender, RoutedEventArgs e)
    {
        var printReceipt = new PrintReceiptDepositWindow();
        printReceipt.Show();
        Close();
    }
}