namespace Examination_System
{
    public enum QuestionType:byte
    {
        TrueFalse,
        ChooseOne,
        Multiple
    }
    internal abstract class Question:IComparable<Question>
    {
        protected string Header;
        protected float Marks;
        protected AnswerList QuestionAnswers;
        protected AnswerList ModelAnswers;
        protected QuestionType QType;

        public Question(string header, float marks, AnswerList questionAnswers, AnswerList modelAnswers, QuestionType type)
        {
            Header = header;
            Marks = marks;
            QuestionAnswers = questionAnswers;
            ModelAnswers = modelAnswers;
            QType = type;
        }

        public string GetHeader()
        {
            return Header;
        }

        public AnswerList GetQuestionAnswers()
        {
            return QuestionAnswers;
        }

        public AnswerList GetModelAnswers()
        {
            return ModelAnswers;
        }

        public float GetMarks()
        {
            return Marks;
        }

        public QuestionType GetQType()
        {
            return QType;
        }


        public void ShowQuestion(string num = "")
        {
            num = num.Length >= 1 ? num + ") " : num;
            if(QType == QuestionType.Multiple)
                Console.Write($"{num}Choose all correct answers: {Header}       ({Marks} Marks)\n");
            else
                Console.Write($"{num}{Header}       ({Marks} Marks)\n");
            QuestionAnswers.ShowAnswers();
        }
        public int CompareTo(Question? other)
        {
            if (other == null || this == null)
                return -1;
            else
            return (int)Marks - (int)other.GetMarks();
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Header);
        }
    }
}