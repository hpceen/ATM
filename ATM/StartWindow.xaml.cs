using System.Windows;

namespace ATM;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
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