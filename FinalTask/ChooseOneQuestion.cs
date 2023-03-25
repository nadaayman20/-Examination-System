namespace Examination_System
{
    internal class ChooseOneQuestion : Question
    {

        public ChooseOneQuestion(string header, float marks, AnswerList QuestionAnswers, AnswerList ModelAnswer) : base(header, marks, QuestionAnswers, ModelAnswer, QuestionType.ChooseOne)
        {
        }
    }
}
