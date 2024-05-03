using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using Microsoft.Data.Sqlite;

namespace ATM;

public partial class InsertCardWindow : Window
{
    public InsertCardWindow()
    {
        InitializeComponent();
    }

    private void DebugButton_Click(object sender, RoutedEventArgs e)
    {
        var app = Application.Current as App;
        var connection = app!.Connection;
        connection.Open();
        string cardNumber;
        SqliteCommand? command;
        {
            var cardNumbers = new List<string>();
            command = new SqliteCommand("SELECT card_number FROM cards", connection);
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cardNumbers.Add(reader.GetString(0));
                    }
                }
            }

            var rand = new Random();
            cardNumber = cardNumbers[rand.Next(cardNumbers.Count)];
        }
        command = new SqliteCommand(
            "SELECT card_number, pin_code, balance, client_name FROM cards\n" +
            "INNER JOIN main.accounts a on a.account_number = cards.account_number\n" +
            "INNER JOIN main.clients c on c.id = a.client_id\n" +
            $"WHERE card_number = {cardNumber}", connection);
        using (var reader = command.ExecuteReader())
        {
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    app.CardInfo = new Card(reader.GetString(0),
                        reader.GetString(1),
                        reader.GetDouble(2),
                        reader.GetString(3).Split(' ')[1]);
                }
            }
        }

        connection.Close();
        var pinCodeWindow = new PinCodeWindow();
        pinCodeWindow.Show();
        Close();
    }
}