namespace Examination_System
{
    class Practical : Exam
    {
        public Practical(Subject s, int qnum):base(s,ExamType.Practical, qnum) {}

        public static implicit operator bool(Practical x)
        {
            if (x!=null && x.Subj)
                return true;
            return false;
        }
    }
}
