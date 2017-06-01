using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testownik.Models;

namespace Testownik.Services
{
    class BrowserManagmentService
    {
        public List<Quiz> Get_list_of_quizes()
        {
            using (var db = new AppContext())
            {
                var quizes = db.Quizes.ToList();
                return quizes;
            }
        }

        public void DeleteQuiz(int quizId)
        {
            using (var db= new AppContext())
            {
                var quiz = db.Quizes.FirstOrDefault(a=>a.Id==quizId);
                foreach (var child  in quiz.Questions.ToList())
                {
                    foreach (var ans in child.Answers.ToList())
                    {
                        db.Answers.Remove(ans);
                    }
                    db.Questions.Remove(child);
                }
                db.Quizes.Remove(quiz);
                db.Entry(quiz).State = EntityState.Deleted;
                MessageBox.Show("Test został usunięty");
                db.SaveChanges();

            }
        }
    }
}
