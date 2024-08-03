using System.Windows;

namespace StudentPortal
{
    public partial class MainWindow : Window
    {
        private const string ValidUsername = "adam"; // Static username
        private const string ValidPassword = "Test@123"; // Static password

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MVVM.ViewModels.MainWindowViewModel();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == ValidUsername && password == ValidPassword)
            {
                // Successful login
                LoginPanel.Visibility = Visibility.Collapsed;
                MainOptionsPanel.Visibility = Visibility.Visible;
            }
            else
            {
                // Show error message
                LoginErrorMessage.Visibility = Visibility.Visible;
                LoginErrorMessage.Text = "Invalid username or password.";
            }
        }
    }
}
