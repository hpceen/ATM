using System;
using System.IO;
using System.Windows;

namespace ATM;

public partial class PrintReceiptDepositWindow : Window
{
    private readonly int _depositedSum;

    public PrintReceiptDepositWindow(int depositedSum)
    {
        InitializeComponent();
        _depositedSum = depositedSum;
    }

    private void NoReceipt_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void YesReceipt_Click(object sender, RoutedEventArgs e)
    {
        var receiptString = $"{DateTime.Now}\nПроцедура: Депозит\nВнесено средств: {_depositedSum}";
        File.WriteAllText("receipt.txt", receiptString);
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }
}