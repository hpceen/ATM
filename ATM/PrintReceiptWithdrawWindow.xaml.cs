using System;
using System.IO;
using System.Windows;

namespace ATM;

public partial class PrintReceiptWithdrawWindow : Window
{
    private readonly double _withdrawSum;

    public PrintReceiptWithdrawWindow(double withdrawSum)
    {
        InitializeComponent();
        _withdrawSum = withdrawSum;
    }

    private void NoReceipt_Click(object sender, RoutedEventArgs e)
    {
        var takeBillsWithdrawWindow = new TakeBillsWithdrawWindow();
        takeBillsWithdrawWindow.Show();
        Close();
    }

    private void YesReceipt_Click(object sender, RoutedEventArgs e)
    {
        var receiptString = $"{DateTime.Now}\nПроцедура: Снятие\nСнято средств: {_withdrawSum}";
        File.WriteAllText("receipt.txt", receiptString);
        var takeBillsWithdrawWindow = new TakeBillsWithdrawWindow();
        takeBillsWithdrawWindow.Show();
        Close();
    }
}