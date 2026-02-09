using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;

namespace AvaloniaApplication1.Views
{
    public partial class SecondWindow : Window
    {
        private readonly Random _random = new Random();

        public SecondWindow() : this("Guest") { }

        public SecondWindow(string username)
        {
            InitializeComponent();
            var welcome = this.FindControl<TextBlock>("WelcomeText");
            if (welcome != null)
            {
                welcome.Text = $"Welcome, {username}!";
            }
        }

        private void Logout_Click(object? sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MagicButton_Click(object? sender, RoutedEventArgs e)
        {
            // 1. Change Background Color
            var color = Color.FromRgb((byte)_random.Next(256), (byte)_random.Next(256), (byte)_random.Next(256));
            this.Background = new SolidColorBrush(color);

            // 2. Change Welcome Text to a Random Quote
            var welcome = this.FindControl<TextBlock>("WelcomeText");
            if (welcome != null)
            {
                string[] quotes = {
                    "Code is like humor. When you have to explain it, it’s bad.",
                    "First, solve the problem. Then, write the code.",
                    "Experience is the name everyone gives to their mistakes.",
                    "In order to be irreplaceable, one must always be different.",
                    "The only way to do great work is to love what you do."
                };
                welcome.Text = quotes[_random.Next(quotes.Length)];
                welcome.Foreground = Brushes.White;
            }
        }
    }
}
