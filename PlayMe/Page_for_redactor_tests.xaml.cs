using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static PlayMe.Questions;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Specialized;
using System.Collections;

namespace PlayMe
{
    public partial class Page_for_redactor_tests : Page
    {

        internal List<Questions> question = new List<Questions>();
        public static class PageElements
        {
            public static DataGrid DataGrid_with_qst { get; set; }
        }

        public Page_for_redactor_tests()
        {
            InitializeComponent();

            List<Questions> questions_json = Converter_to_JSON.MyDerealize<List<Questions>>("questions.json");
            DataGrid_with_qst.ItemsSource = questions_json; 
            PageElements.DataGrid_with_qst = DataGrid_with_qst;
        }

        public void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            question.Add(new Questions("NameQ", "Discr", "Ans1", "Ans2", "Ans3", Answers.FirstAnswer));
            PageElements.DataGrid_with_qst.ItemsSource = null;
            PageElements.DataGrid_with_qst.ItemsSource = question;
        }

        public void Save_btn_Click(object sender, RoutedEventArgs e)
        {
            Converter_to_JSON.MySerealize(question,"questions.json");
        }
    }
}
