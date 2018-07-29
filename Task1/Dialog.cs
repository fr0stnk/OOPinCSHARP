using System.Collections.Generic;

namespace Task1
{
    class Dialog
    {
        public Question Question { get; }
        public List<Answer> AnswersList { get; set; }
        public Door Door { get; set; }

        public Dialog(Question question, List<Answer> listOfAnswers)
        {
            Question = question;
            AnswersList = listOfAnswers;
            Door = new Door();
        }

    }
}
