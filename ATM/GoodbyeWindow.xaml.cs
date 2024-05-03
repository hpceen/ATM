using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace ATM;

public partial class GoodbyeWindow : Window
{
    private readonly DispatcherTimer _dispatcherTimer;

    public GoodbyeWindow()
    {
        InitializeComponent();
        _dispatcherTimer = new DispatcherTimer();
        _dispatcherTimer.Tick += dispatcherTimer_Tick!;
        _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
        _dispatcherTimer.Start();
    }

    private void dispatcherTimer_Tick(object sender, EventArgs e)
    {
        _dispatcherTimer.Stop();
        var startWindow = new StartWindow();
        startWindow.Show();
        Close();
    }
}