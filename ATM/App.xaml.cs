using System.Windows;
using Microsoft.Data.Sqlite;

namespace ATM;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public readonly SqliteConnection Connection = new(
        new SqliteConnectionStringBuilder(@"Data Source=C:\Users\HPCee\RiderProjects\ATM\db;")
        {
            Mode = SqliteOpenMode.ReadWrite,
        }.ToString());

    public Card CardInfo;
}