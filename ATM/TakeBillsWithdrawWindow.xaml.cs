using System.Windows;

namespace ATM;

public partial class TakeBillsWithdrawWindow : Window
{
    public TakeBillsWithdrawWindow()
    {
        InitializeComponent();
    }

    private void TakeBills_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }
}