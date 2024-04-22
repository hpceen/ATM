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
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void YesReceipt_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }
}