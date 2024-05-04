using System;
using System.Windows;

namespace ATM;

public partial class ServicePayWindow : Window
{
    private readonly string _serviceName;

    public ServicePayWindow(string serviceName)
    {
        _serviceName = serviceName;
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
        var withdrawSum = Convert.ToInt32(ServicePaySumTextBox.Text);
        if (withdrawSum >= app.CardInfo.Balance)
        {
            NotEnoughTextBlock.Visibility = Visibility.Visible;
            return;
        }

        var printReceiptServiceWindow = new PrintReceiptServiceWindow(_serviceName);
        printReceiptServiceWindow.Show();
        Close();
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        ServicePaySumTextBox.Text = "";
    }
}