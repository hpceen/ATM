using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Microsoft.Data.Sqlite;

namespace ATM;

public partial class GoodbyeWindow : Window
{
    private readonly DispatcherTimer _dispatcherTimer;
    private readonly SqliteConnection _connection = (Application.Current as App)!.Connection;
    private readonly Card _cardInfo = (Application.Current as App)!.CardInfo;

    public GoodbyeWindow()
    {
        InitializeComponent();
        SendToDatabase();
        _dispatcherTimer = new DispatcherTimer();
        _dispatcherTimer.Tick += dispatcherTimer_Tick!;
        _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
        _dispatcherTimer.Start();
    }

    private void SendToDatabase()
    {
        var command = new SqliteCommand($"UPDATE accounts\n" +
                                        $"SET balance = {_cardInfo.Balance}\n" +
                                        $"WHERE account_number = (SELECT account_number FROM cards WHERE card_number = {_cardInfo.CardNumber})",
            _connection);
        _connection.Open();
        using (_connection)
        {
            command.ExecuteNonQuery();
        }

        _connection.Close();
    }

    private void dispatcherTimer_Tick(object sender, EventArgs e)
    {
        _dispatcherTimer.Stop();
        var startWindow = new StartWindow();
        startWindow.Show();
        Close();
    }
}