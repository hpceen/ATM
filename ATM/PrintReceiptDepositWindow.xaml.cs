using System.Windows;

namespace ATM;

public partial class PrintReceiptDepositWindow : Window
{
    public PrintReceiptDepositWindow()
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
        //TODO печать чека DepositWindow
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }
}