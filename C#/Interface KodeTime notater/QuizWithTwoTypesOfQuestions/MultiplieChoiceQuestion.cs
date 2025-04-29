using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizWithTwoTypesOfQuestions
{
    internal class MultiplieChoiceQuestion : IQuestion
    {
        private readonly string _question;
        private readonly string[] _answers;
        private readonly int _correctAnswearNo;


        public MultiplieChoiceQuestion(string question, int correctAnswearNo, params string[] answers)
        {
            _question = question;
            _correctAnswearNo = correctAnswearNo;
            _answers = answers;
        }

        public bool Run()
        {
            Console.WriteLine(_question);
            Console.WriteLine("Svaralternativer");
            for (var index = 0; index < _answers.Length; index++)
            {
                var answerNo = index + 1;
                var answer = _answers[index];
                Console.WriteLine(answerNo + ": " + answer);
            }

            Console.Write("Velg svaralternativ: ");
            var selectedAnswearNoStr = Console.ReadLine();
            var selectedAnswerNo = Convert.ToInt32(selectedAnswearNoStr);
            return selectedAnswerNo ==  _correctAnswearNo;
        }
    }
}
