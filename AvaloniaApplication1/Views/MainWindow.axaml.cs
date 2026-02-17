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
            var nameInput = this.FindControl<TextBox>("NameInput");
            string userName = nameInput?.Text ?? "Аноним";

            var secondWindow = new SecondWindow();
            secondWindow.Title = $"Добро пожаловать, {userName}!";
            
            secondWindow.Show();
            this.Close(); // Закроем главное, когда открываем второе
        }
    }
}
