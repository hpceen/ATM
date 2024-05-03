using System.Windows;
using System.Windows.Controls;

namespace ATM;

public partial class ChooseServiceSecondWindow : Window
{
    public ChooseServiceSecondWindow()
    {
        InitializeComponent();
    }

    private void ServiceButton_Click(object sender, RoutedEventArgs e)
    {
        var servicePayWindow = new ServicePayWindow(((sender as Button)!.Content as string)!);
        servicePayWindow.Show();
        Close();
    }
    
    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseServiceFirstWindow = new ChooseServiceFirstWindow();
        chooseServiceFirstWindow.Show();
        Close();
    }
}