using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;

namespace PlayMe
{
    public partial class MainWindow : Window
    {
        public bool isAdmin;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tests_window Testswindow = new Tests_window();
            Testswindow.Show();
            Testswindow.Test_redactor_btn.IsEnabled = false;
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Password_for_Admin.Password == "123")
            {
                Tests_window Testswindow = new Tests_window();
                Testswindow.Show();
                Testswindow.Test_redactor_btn.IsEnabled = true;
                Close();
            }
            else if (Password_for_Admin.Password == "")
            {
                MessageBox.Show("You can't enter here!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Incorrect password", "Message!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}