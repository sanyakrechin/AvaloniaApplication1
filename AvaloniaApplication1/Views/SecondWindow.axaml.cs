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
                welcome.Text = $"Добро пожаловать, {username}!";
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
                    "Код как юмор. Если его нужно объяснять, значит он плох.",
                    "Сначала решите проблему, затем пишите код.",
                    "Опыт — это имя, которое каждый дает своим ошибкам.",
                    "Чтобы быть незаменимым, нужно всегда быть разным.",
                    "Единственный способ делать великие дела — любить то, что вы делаете."
                };
                welcome.Text = quotes[_random.Next(quotes.Length)];
                welcome.Foreground = Brushes.White;
            }
        }
    }
}
