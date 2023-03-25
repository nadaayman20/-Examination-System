namespace Examination_System
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, float marks, AnswerList ModelAnswer) : base(header, marks, new AnswerList(new string[] { "True", "False" }), ModelAnswer, QuestionType.TrueFalse)
        {}
    }
}
