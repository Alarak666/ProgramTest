using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FormTest
{
    class ListTest
    {
        int ID;
        string[] Answer;
        string Question;
        string[] TrueAnswer;
        public ListTest() { }
        List<ListTest> listTests = new List<ListTest>();
        List<ListTest> listTestsRead = new List<ListTest>();

        public int _ID { get => ID; set => ID = value; }
        public string[] _Answer { get => Answer; set => Answer = value; }
        public string _Question { get => Question; set => Question = value; }
        public string[] _TrueAnswer { get => TrueAnswer; set => TrueAnswer = value; }

        public ListTest(string[] answer, string question, string[] trueAnswer, int iD = 0)
        {
            ID = iD;
            Answer = answer;
            Question = question;
            TrueAnswer = trueAnswer;
        }
        public void Add(string Question, string[] Answer, string[] TrueAnswer)
        {
            ID = listTests.Count + 1;
            listTests.Add(new ListTest(Answer, Question, TrueAnswer, ID));
        }
        public void WriteModul()
        {
            using (TextWriter tw = new StreamWriter("Рошен.txt", false))
            {
                string str = "";
                foreach (var list in listTests)
                {
                    tw.WriteLine($"{list.ID}");
                    tw.WriteLine($"{list.Question}");
                    for (int i = 0; i < list.Answer.Length; i++)
                    {
                        str += $"{list.Answer[i].ToString()},";
                    }
                    str = str.Remove(str.Length-1);
                    tw.WriteLine(str);
                    str = "";
                    for (int i = 0; i < list.TrueAnswer.Length; i++)
                    {
                        str += $"{list.TrueAnswer[i].ToString()},";
                    }
                    str = str.Remove(str.Length - 1);
                    tw.WriteLine(str);
                    str = "";
                }
            }
        }
        public List<ListTest> ReadModul()
        {
            string str = "";
            List<string> lines = System.IO.File.ReadLines("Рошен.txt").ToList();
            for (int i = 0; i < lines.Count; i +=4)
            {
                Answer = new string[] { };
                TrueAnswer = new string[] { };
                ID = Convert.ToInt32(lines[i]);
                Question = lines[i + 1].ToString();
                for (int j = 0; j < lines[i + 2].Length; j++)
                {
                    if (lines[i + 2].Length == 1 || lines[i + 2].Length - 1 == j)
                    {
                        str += lines[i + 2][j].ToString();
                        Array.Resize(ref Answer, Answer.Length + 1);
                        Answer[Answer.Length - 1] = str;
                        str = "";
                        continue;
                    }
                    if (lines[i + 2][j] == ',' )
                    {
                        Array.Resize(ref Answer, Answer.Length + 1);
                        Answer[Answer.Length - 1] = str;
                        str = "";
                        continue;
                    }
                    str += lines[i + 2][j].ToString();
                }
                str = "";
                for (int j = 0; j < lines[i + 3].Length; j++)
                {
                    if(lines[i + 3].Length == 1 || lines[i + 3].Length - 1 == j)
                    {
                        str += lines[i + 3][j].ToString();
                        Array.Resize(ref TrueAnswer, TrueAnswer.Length + 1);
                        TrueAnswer[TrueAnswer.Length - 1] = str;
                        str = "";
                        continue;
                    }
                    if (lines[i + 3][j] == ',' )
                    {
                        Array.Resize(ref TrueAnswer, TrueAnswer.Length + 1);
                        TrueAnswer[TrueAnswer.Length - 1] = str;
                        str = "";
                        continue;
                    }
                    str += lines[i + 3][j].ToString();
                }
                str = "";
                listTestsRead.Add(new ListTest(Answer, Question, TrueAnswer, ID));
            }
            return listTestsRead;
        }
        public int GiveAnswer(int inputID)
        {
            int i = 0;
            string [] s = listTestsRead[inputID].TrueAnswer;
            if(s.Length == 0)
            {
                return 0;
            }
            else if(s.Length == 1){
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public int GiveCreateElement(int inputID)
        {
            int i = 0;
            string[] s = listTestsRead[inputID].TrueAnswer;
            if (s.Length == 0)
            {
                return 1;
            }
            else
            {
                return listTestsRead[inputID].Answer.Length;
            }
        }
        public decimal Cool(List<string[]> UserAnswer)
        {
            int i = 0;
            decimal Rating = 0;
            decimal Target = 0;
            foreach (var item in UserAnswer)
            {
                for (int j = 0; j < item.Length; j++)
                {
                    if(listTestsRead[i].Answer[j].Length > 1)
                    {
                        if (listTestsRead[i].Answer[j] == item[j])
                        {
                            Target += 0.3m;
                        }
                        else
                            Target -= 0.3m;
                        if(listTestsRead[i].Answer[j].Length-1 == j)
                        {
                            Target = (Target > 1) ? Target = 1 : Target = 0;
                            Rating += Target;
                        }
                        continue;
                    }
                    if(listTestsRead[i].Answer[j] == item[j])
                    {
                        Rating++;
                    }
                }
            }
            return Rating;
        }
    }
}

