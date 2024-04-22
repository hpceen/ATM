using System.Windows;

namespace ATM;

public partial class ChooseServiceFirstWindow : Window
{
    public ChooseServiceFirstWindow()
    {
        InitializeComponent();
    }

    private void ServiceButton_Click(object sender, RoutedEventArgs e)
    {
    }

    private void OtherButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseServiceSecondWindow = new ChooseServiceSecondWindow();
        chooseServiceSecondWindow.Show();
        Close();
    }
}