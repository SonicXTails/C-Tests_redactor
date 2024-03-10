using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayMe
{
    internal class Questions
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; } 
        public string ThirdAnswer { get; set; }
        public enum Answers
        {
            FirstAnswer = 1,
            SecondAnswer = 2,
            ThirdAnswer = 3
        };
        public Answers RightAnswer { get; set; }

        public Questions(string Name, string Description, string FirstAnswer, string SecondAnswer, string ThirdAnswer, Answers RightAnswer) 
        {
            this.Name = Name;
            this.Description = Description;
            this.FirstAnswer = FirstAnswer;
            this.SecondAnswer = SecondAnswer;
            this.ThirdAnswer = ThirdAnswer;
            this.RightAnswer = RightAnswer;
        }
    }
}
