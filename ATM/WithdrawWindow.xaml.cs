using System;
using System.Windows;
using System.Windows.Controls;

namespace ATM;

public partial class WithdrawWindow : Window
{
    public WithdrawWindow()
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
        var app = (Application.Current as App)!;
        var withdrawSum = Convert.ToInt32(WithdrawSumTextBox.Text);
        if (withdrawSum >= app.CardInfo.Balance)
        {
            NotEnoughTextBlock.Visibility = Visibility.Visible;
            return;
        }

        var printReceiptWithdrawWindow = new PrintReceiptWithdrawWindow();
        printReceiptWithdrawWindow.Show();
        Close();
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        WithdrawSumTextBox.Text = "";
    }
}