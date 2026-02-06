using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            var secondWindow = new SecondWindow();
            secondWindow.Show();
            // Optional: this.Close(); if you want to close the main window
        }
    }
}
