using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static PlayMe.Questions;
using static PlayMe.Page_for_redactor_tests;

namespace PlayMe
{
    public partial class Tests_window : Window
    {

        public DataGrid DataGrid_with_qst { get; set; }

        public Tests_window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Take_test_btn_Click(object sender, RoutedEventArgs e)
        {
            List<Questions> questions_json = Converter_to_JSON.MyDerealize<List<Questions>>("questions.json");
            if (questions_json == null)
            {
                PageFrame.Content = new empty_tests();
            }
            else
            {
                PageFrame.Content = new test_done();
            }
        }

        private void Test_redactor_btn_Click(object sender, RoutedEventArgs e)
        {
            PageFrame.Content = new Page_for_redactor_tests();
        }

    }
}
