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
using static PlayMe.Page_for_redactor_tests;

namespace PlayMe
{
    public partial class test_done : Page
    {
        private List<Questions> questions;
        int pos = 0;
        public int correctAnswerCount = 0;


        public test_done()
        {
            InitializeComponent();

            questions = Converter_to_JSON.MyDerealize<List<Questions>>("questions.json");
            Show_Data_In_Objects(questions, pos);
        }

        private void Show_Data_In_Objects(List<Questions> questions, int pos)
        {
            Question.Text = questions[pos].Name;
            Descripruion.Text = questions[pos].Description;
            Anwser1.Content = questions[pos].FirstAnswer;
            Anwser2.Content = questions[pos].SecondAnswer;
            Anwser3.Content = questions[pos].ThirdAnswer;
        }

        private void Anwser1_Click(object sender, RoutedEventArgs e)
        {
            if (pos < questions.Count)
            {
                if (questions[pos].RightAnswer == Questions.Answers.FirstAnswer)
                {
                    correctAnswerCount++;
                }

                pos++;

                if (pos < questions.Count)
                {
                    Show_Data_In_Objects(questions, pos);
                }
                else
                {
                    Question.Text = Convert.ToString(correctAnswerCount);
                    Descripruion.Text = "╰(*°▽°*)╯";
                    Anwser1.Content = "(❁´◡`❁)";
                    Anwser2.Content = ":-D";
                    Anwser3.Content = "(┬┬﹏┬┬)";
                }
            }
        }

        private void Anwser2_Click(object sender, RoutedEventArgs e)
        {
            if (pos < questions.Count)
            {
                if (questions[pos].RightAnswer == Questions.Answers.SecondAnswer)
                {
                    correctAnswerCount++;
                }

                pos++;

                if (pos < questions.Count)
                {
                    Show_Data_In_Objects(questions, pos);
                }
                else
                {
                    Question.Text = Convert.ToString(correctAnswerCount);
                    Descripruion.Text = "╰(*°▽°*)╯";
                    Anwser1.Content = "(❁´◡`❁)";
                    Anwser2.Content = ":-D";
                    Anwser3.Content = "(┬┬﹏┬┬)";
                }
            }
        }

        private void Anwser3_Click(object sender, RoutedEventArgs e)
        {
            if (pos < questions.Count)
            {
                if (questions[pos].RightAnswer == Questions.Answers.ThirdAnswer)
                {
                    correctAnswerCount++;
                }

                pos++;

                if (pos < questions.Count)
                {
                    Show_Data_In_Objects(questions, pos);
                }
                else
                {
                    Question.Text = "Your result: " + Convert.ToString(correctAnswerCount);
                    Descripruion.Text = "╰(*°▽°*)╯";
                    Anwser1.Content = "(❁´◡`❁)";
                    Anwser2.Content = ":-D";
                    Anwser3.Content = "(┬┬﹏┬┬)";
                }
            }
        }
    }
}
