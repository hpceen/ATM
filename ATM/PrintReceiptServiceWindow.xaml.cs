using System;
using System.IO;
using System.Windows;

namespace ATM;

public partial class PrintReceiptServiceWindow : Window
{
    private readonly string _serviceName;
    private readonly double _servicePaySum;

    public PrintReceiptServiceWindow(string serviceName, double servicePaySum)
    {
        InitializeComponent();
        _serviceName = serviceName;
        _servicePaySum = servicePaySum;
    }

    private void NoReceipt_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void YesReceipt_Click(object sender, RoutedEventArgs e)
    {
        var receiptString = $"{DateTime.Now}\nПроцедура: Оплата Услуги\nНазвание услуги:{_serviceName}\nОплачено: {_servicePaySum}";
        File.WriteAllText("receipt.txt", receiptString);
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }
}