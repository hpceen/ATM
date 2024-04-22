using System.Windows;

namespace ATM;

public partial class WithdrawWindow : Window
{
    public WithdrawWindow()
    {
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
        //TODO проверка на количество денег на счету
        
    }
}