namespace Examination_System
{
    internal class Answer
    {
        public string answer { get; private set; }
        public Answer(string answer)
        {
            this.answer = answer;
        }

        public override string ToString()
        {
            return answer;
        }

        public static implicit operator bool(Answer a)
        {
            if (a != null || a?.answer.Length > 0)
                return true;
            return false;
        }

        public override bool Equals(object? obj)
        {
            Answer? a = obj as Answer;
            if (a != null && this != null)
                return a.answer == answer;
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(answer);
        }
    }
}
