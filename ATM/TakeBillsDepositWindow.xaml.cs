using System.Windows;

namespace ATM;

public partial class TakeBillsDepositWindow : Window
{
    
    public TakeBillsDepositWindow()
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