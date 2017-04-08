using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testownik.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Ask { get; set; }
        public virtual Quiz Quiz { get; set; }
        public virtual List<Answer> Answers { get; set; }

    }
}
