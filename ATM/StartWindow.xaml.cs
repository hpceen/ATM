using System.Windows;

namespace ATM;

public partial class StartWindow : Window
{
    public StartWindow()
    {
        InitializeComponent();
    }

    private void StartButton_Click(object sender, RoutedEventArgs e)
    {
        Window insertCard = new InsertCardWindow();
        insertCard.Show();
        Close();
    }
}