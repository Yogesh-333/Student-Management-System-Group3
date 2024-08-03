using System.Windows;
using System.Windows.Controls;

namespace StudentPortal.Helpers
{
    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty BoundPassword =
            DependencyProperty.RegisterAttached("BoundPassword", typeof(string), typeof(PasswordBoxHelper), new PropertyMetadata(string.Empty, OnBoundPasswordChanged));

        public static readonly DependencyProperty BindPassword =
            DependencyProperty.RegisterAttached("BindPassword", typeof(bool), typeof(PasswordBoxHelper), new PropertyMetadata(false, OnBindPasswordChanged));

        private static bool _isUpdating;

        public static string GetBoundPassword(DependencyObject dp) => (string)dp.GetValue(BoundPassword);

        public static void SetBoundPassword(DependencyObject dp, string value) => dp.SetValue(BoundPassword, value);

        public static bool GetBindPassword(DependencyObject dp) => (bool)dp.GetValue(BindPassword);

        public static void SetBindPassword(DependencyObject dp, bool value) => dp.SetValue(BindPassword, value);

        private static void OnBoundPasswordChanged(DependencyObject dp, DependencyPropertyChangedEventArgs e)
        {
            if (dp is PasswordBox passwordBox && !_isUpdating)
            {
                passwordBox.PasswordChanged -= HandlePasswordChanged;
                passwordBox.Password = (string)e.NewValue;
                passwordBox.PasswordChanged += HandlePasswordChanged;
            }
        }

        private static void OnBindPasswordChanged(DependencyObject dp, DependencyPropertyChangedEventArgs e)
        {
            if (dp is PasswordBox passwordBox)
            {
                if ((bool)e.OldValue)
                {
                    passwordBox.PasswordChanged -= HandlePasswordChanged;
                }

                if ((bool)e.NewValue)
                {
                    passwordBox.PasswordChanged += HandlePasswordChanged;
                }
            }
        }

        private static void HandlePasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                _isUpdating = true;
                SetBoundPassword(passwordBox, passwordBox.Password);
                _isUpdating = false;
            }
        }
    }
}
