namespace Examination_System
{
    internal class QuestionList:List<Question>,ICloneable,IEnumerable<Question>
    {
        public string listName { get; set; }
        public QuestionList(string listName, Question[]? questions = null)
        {
            this.listName = listName;
            if(questions!=null && questions.Length > 0)
            {
                foreach(Question q in questions)
                    Add(q);
            }
        }
        
        public new void Add(Question? val)
        {
            if (val != null)
            {
                base.Add(val);
                string filePath = @$"{listName}.txt";
                using (StreamWriter w = File.AppendText(filePath))
                {
                    w.WriteLine($"{val.GetHeader()},{val.GetMarks()},{val.GetQType()},{val.GetQuestionAnswers().ToString()},{val.GetModelAnswers().ToString()}");
                }
            }
        }
        public object Clone()
        {
            return new QuestionList(listName, ToArray());
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            if(this!=null && Count > 0)
            {
                int hash = 0;
                foreach (var item in this)
                {
                    hash += item.GetHashCode();
                }
                return hash;
            }
            return 0;
        }


    }
}
