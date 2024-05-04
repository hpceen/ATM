using System;
using System.Collections.Generic;
using System.Windows;
using Microsoft.Data.Sqlite;

namespace ATM;

public partial class InsertCardWindow : Window
{
    public InsertCardWindow()
    {
        InitializeComponent();
    }

    private static string RandomCardNumber(SqliteConnection connection)
    {
        var cardNumbers = new List<string>();
        var command = new SqliteCommand("SELECT card_number FROM cards", connection);
        using var reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                cardNumbers.Add(reader.GetString(0));
            }
        }

        var rand = new Random();
        return cardNumbers[rand.Next(cardNumbers.Count)];
    }

    private static void InitCard(string cardNumber, SqliteConnection connection)
    {
        var app = (Application.Current as App)!;
        var command = new SqliteCommand(
            "SELECT card_number, pin_code, balance, client_name FROM cards\n" +
            "INNER JOIN main.accounts a on a.account_number = cards.account_number\n" +
            "INNER JOIN main.clients c on c.id = a.client_id\n" +
            $"WHERE card_number = {cardNumber}", connection);
        using var reader = command.ExecuteReader();
        if (!reader.HasRows) return;
        while (reader.Read())
        {
            app.CardInfo = new Card(reader.GetString(0),
                reader.GetString(1),
                reader.GetDouble(2),
                reader.GetString(3).Split(' ')[1]);
        }
    }

    private void DebugButton_Click(object sender, RoutedEventArgs e)
    {
        var app = Application.Current as App;
        var connection = app!.Connection;
        connection.Open();
        InitCard(RandomCardNumber(connection), connection);
        connection.Close();
        
        var pinCodeWindow = new PinCodeWindow();
        pinCodeWindow.Show();
        Close();
    }
}