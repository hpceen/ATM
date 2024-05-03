using System;
using System.Windows;

namespace ATM;

public partial class ServicePayWindow : Window
{
    public ServicePayWindow(string serviceName)
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
        //TODO проверка на количество денег на счету
        var printReceiptServiceWindow = new PrintReceiptServiceWindow();
        printReceiptServiceWindow.Show();
        Close();
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        TextBlock.Text = "";
    }
}