using Examination_System;

QuestionList Questions = new QuestionList("Maths",new Question[]
            {
                    new ChooseOneQuestion("What number should come next: 31, 29, 24, 22, 17,... ",2.5f,new AnswerList(new string[] { "15", "14", "13", "12" }),new AnswerList(new string[] { "15" })),
                    new ChooseOneQuestion("1080 / ? = 9 * 8",2.5f,new AnswerList(new string[] { "13", "15", "17", "19" }),new AnswerList(new string[] { "15" })),
                    new ChooseOneQuestion("12 * 9 / 4 = ?",2.5f,new AnswerList(new string[] { "25", "26", "27", "28" }),new AnswerList(new string[] { "27" })),
                    new ChooseOneQuestion("What number should come next: 14, 28, 20, 40, 32, 64,... ",2.5f,new AnswerList(new string[] { "52", "56", "96", "128" }),new AnswerList(new string[] { "56" })),
                    new ChooseOneQuestion("3 + 27 * 2 = ?",2.5f,new AnswerList(new string[] { "33", "54", "57", "60" }),new AnswerList(new string[] { "57" })),
                    new ChooseOneQuestion("What number should come next: 7, 10, 8, 11, 9, 12,... ",2.5f,new AnswerList(new string[] { "7", "10", "12", "13" }),new AnswerList(new string[] { "10" })),
                    new TrueFalseQuestion("55 * 3 < 820 / 4 ?",2.5f,new AnswerList(new string[]{"True"})),
                    new TrueFalseQuestion("4232 > 8520 / 2 ?",2.5f,new AnswerList(new string[]{"False"})),
                    new ChooseMultiple("Which is the factorial of 4 ?",5f,new AnswerList(new string[] { "22", "24", "8 * 3", "12 * 2" }),new AnswerList(new string[] { "24", "8 * 3", "12 * 2" })),
                    new ChooseMultiple("8 * 2 * 15 / 4 = ?",5f,new AnswerList(new string[] { "60", "240 / 6", "480 / 8", "15 * 3" }),new AnswerList(new string[] {  "60","480 / 8" })),
            });

Exam exam;
byte choice;
Subject Subj;
int i = 1;
do
{
    Subj = new Subject("Maths", Questions);
    Console.WriteLine("Enter Exam type \n1.Practical\n2.Final\n0.Exit");
    while (!byte.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
        Console.WriteLine("Enter a valid number");

    if (choice == 0)
        break;
    switch (choice)
    {
        case 1:
            exam = new Practical(Subj, 10);
            exam.StartExam();
            Console.WriteLine("\n");
            break;
        case 2:
            exam = new FinalExam(Subj, 10);
            exam.StartExam();
            Console.WriteLine("\n");
            break;
        default:
            exam = null;
            break;
    }
    i = 1;
} while (choice != 0);
