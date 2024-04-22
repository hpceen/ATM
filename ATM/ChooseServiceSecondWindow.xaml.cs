using System.Windows;

namespace ATM;

public partial class ChooseServiceSecondWindow : Window
{
    public ChooseServiceSecondWindow()
    {
        InitializeComponent();
    }

    private void BackButton_Click(object sender, RoutedEventArgs e)
    {
        var chooseServiceFirstWindow = new ChooseServiceFirstWindow();
        chooseServiceFirstWindow.Show();
        Close();
    }
}