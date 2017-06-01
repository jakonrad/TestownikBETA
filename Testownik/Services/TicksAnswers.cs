using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testownik.Services
{
    class TicksAnswers
    {
        public int NumberOfQuestion { get; set; }
       public bool[] MarkAnswers { get; set; }

        public TicksAnswers(int numberOfQuestion)
        {
            NumberOfQuestion = numberOfQuestion;
            MarkAnswers =new bool[4];
            
            //AnsA = false;
            //AnsB = false;
            //AnsC = false;
            //AnsD = false;
        }
    }
}
