namespace Examination_System
{
    internal class Subject
    {
        public string Name { get; private set; }
        // Aggregation relationship
        public QuestionList Questions { get; private set; }
        public Subject(string subjname, QuestionList Q)
        {
            Name = subjname;
            Questions = Q;
        }
        public static implicit operator bool(Subject subject)
        {
            if (subject.Questions.Count > 0 || !String.IsNullOrEmpty(subject.Name))
                return true;
            return false;
        }
    }
}