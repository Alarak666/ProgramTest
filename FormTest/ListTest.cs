using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTest
{
    class ListTest 
    {
        int ID;
        string[] Answer;
        string Question;
        public ListTest() { }
        List<ListTest> listTests= new List<ListTest>();

        public ListTest(string[] answer, string question, int iD = 0)
        {
            ID = iD;
            Answer = answer;
            Question = question;
        }
        public  void Add(string Question, string[] Answer)
        {
            ID = listTests.Count + 1;
            listTests.Add(new ListTest(Answer,Question,ID));
        }

     
    }
}
