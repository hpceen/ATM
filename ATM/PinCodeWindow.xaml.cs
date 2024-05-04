using System.Windows;
using System.Windows.Media;
using Microsoft.Data.Sqlite;

namespace ATM;

public partial class PinCodeWindow : Window
{
    private int _counter = 5;

    private readonly Card _cardInfo = (Application.Current as App)!.CardInfo;

    public PinCodeWindow()
    {
        InitializeComponent();
        GreetingTextBlock.Text = $"Здравствуйте {_cardInfo.ClientName}";
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        var takeCardWindow = new TakeCardWindow();
        takeCardWindow.Show();
        Close();
    }

    private void ContinueButton_Click(object sender, RoutedEventArgs e)
    {
        if (PinCodeBox.Password != _cardInfo.PinCode)
        {
            _counter--;
            EnterPinTextBlock.Text = $"Повторите ввод пинкода\nОсталось попыток {_counter}";
            EnterPinTextBlock.Foreground = Brushes.Red;
            if (_counter != 0) return;
            var takeCardWindow = new TakeCardWindow();
            takeCardWindow.Show();
            Close();
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