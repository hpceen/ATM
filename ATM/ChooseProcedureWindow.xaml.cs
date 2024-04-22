using System.Windows;

namespace ATM;

public partial class ChooseProcedureWindow : Window
{
    public ChooseProcedureWindow()
    {
        InitializeComponent();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void DepositButton_Click(object sender, RoutedEventArgs e)
    {
        var putBillsWindow = new PutBillsWindow();
        putBillsWindow.Show();
        Close();
    }
}