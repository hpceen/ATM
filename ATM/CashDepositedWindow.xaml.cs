using System.Windows;

namespace ATM;

public partial class CashDepositedWindow : Window
{
    private readonly int _depositedSum;

    public CashDepositedWindow(int depositedSum)
    {
        InitializeComponent();
        _depositedSum = depositedSum;
        DepositedSum.Text = _depositedSum.ToString();
    }

    private void cancelButton_Click(object sender, RoutedEventArgs e)
    {
        var takeBillsDepositWindow = new TakeBillsDepositWindow();
        takeBillsDepositWindow.Show();
        Close();
    }

    private void continueButton_Click(object sender, RoutedEventArgs e)
    {
        var app = (Application.Current as App)!;
        app.CardInfo.Balance += _depositedSum;
        var printReceiptDepositWindow = new PrintReceiptDepositWindow();
        printReceiptDepositWindow.Show();
        Close();
    }
}