using System.Windows;

namespace ATM;

public partial class PrintReceiptServiceWindow : Window
{
    public PrintReceiptServiceWindow(string serviceName)
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