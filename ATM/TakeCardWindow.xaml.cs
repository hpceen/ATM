using System.Windows;

namespace ATM;

public partial class TakeCardWindow : Window
{
    public TakeCardWindow()
    {
        InitializeComponent();
    }


    private void DebugButton_Click(object sender, RoutedEventArgs e)
    {
        var goodbyeWindow = new GoodbyeWindow();
        goodbyeWindow.Show();
        Close();
    }
}