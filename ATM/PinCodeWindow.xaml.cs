using System.Windows;
using System.Windows.Media;
using Microsoft.Data.Sqlite;

namespace ATM;

public partial class PinCodeWindow : Window
{
    private readonly Card cardInfo = (Application.Current as App)!.CardInfo;

    public PinCodeWindow()
    {
        InitializeComponent();
        GreetingTextBlock.Text = $"Здравствуйте {cardInfo.ClientName}";
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void ContinueButton_Click(object sender, RoutedEventArgs e)
    {
        if (PinCodeBox.Password != cardInfo.PinCode)
        {
            EnterPinTextBlock.Text = "Повторите ввод пинкода";
            EnterPinTextBlock.Foreground = Brushes.Red;
            return;
        }

        var chooseProcedureWindow = new ChooseProcedureWindow();
        chooseProcedureWindow.Show();
        Close();
    }

    private void ClearButton_Click(object sender, RoutedEventArgs e)
    {
        PinCodeBox.Password = "";
    }
}