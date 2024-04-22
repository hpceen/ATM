using System.Windows;

namespace ATM;

public partial class InsertCardWindow : Window
{
    public InsertCardWindow()
    {
        InitializeComponent();
    }

    private void DebugButton_Click(object sender, RoutedEventArgs e)
    {
        var pinCodeWindow = new PinCodeWindow();
        pinCodeWindow.Show();
        Close();
    }
}