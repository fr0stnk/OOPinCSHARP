using System.Collections.Generic;

namespace Task1
{
    class Dialog
    {
        public Question Question { get; }
        public List<Answer> Answers { get; }
        public Door Door { get; set; }

        public Dialog(Question question, List<Answer> arrayAnswers)
        {
            Question = question;
            Answers = arrayAnswers;
            Door = new Door();
        }

    }
}
