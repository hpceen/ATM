using System.Windows;
using System.Windows.Controls;

namespace ATM;

public partial class ChooseServiceFirstWindow : Window
{
    public ChooseServiceFirstWindow()
    {
        InitializeComponent();
    }

    private void ServiceButton_Click(object sender, RoutedEventArgs e)
    {
        var servicePayWindow = new ServicePayWindow(((sender as Button)!.Content as string)!);
        servicePayWindow.Show();
        Close();
    }

    private void OtherButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseServiceSecondWindow = new ChooseServiceSecondWindow();
        chooseServiceSecondWindow.Show();
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseProcedureWindow = new ChooseProcedureWindow();
        chooseProcedureWindow.Show();
        Close();
    }
}