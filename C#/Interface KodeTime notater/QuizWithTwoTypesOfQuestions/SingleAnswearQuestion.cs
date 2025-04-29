using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizWithTwoTypesOfQuestions
{
    internal class SingleAnswearQuestion : IQuestion
    {
        private readonly string _question;
        private readonly string _correctAnswear;

        public SingleAnswearQuestion(string question, string correctAnswear)
        {
            _correctAnswear = correctAnswear;
            _question = question;
        }

        public bool Run()
        {
            Console.WriteLine(_question + " ");
            var answer = Console.ReadLine();
            return answer == _correctAnswear;
        }
    }
}
