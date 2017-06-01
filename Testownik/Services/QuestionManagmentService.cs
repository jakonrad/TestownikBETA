using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testownik.Models;

namespace Testownik.Services
{
    class QuestionManagmentService
    {
        public void DeleteQuestion(int questionId)
        {
            using (var db = new AppContext())
            {

                var ans_in_question = db.Questions.Include(x => x.Answers).FirstOrDefault(a => a.Id == questionId);

                foreach (var child in ans_in_question.Answers.ToList())
                {
                    db.Answers.Remove(child);
                }
                var question = db.Questions.FirstOrDefault(a => a.Id == questionId);
                if (question != null) db.Questions.Remove(question);
                db.Entry(question).State = EntityState.Deleted;
                MessageBox.Show("Pytanie zostało usunięte");
                db.SaveChanges();
            }
        }

        public List<Question> Get_list_of_question(int quizId)
        {
            using (var db = new AppContext())
            {
                var quizes = db.Quizes.AsNoTracking().ToList();
                var dataSource = quizes.FirstOrDefault(a => a.Id == quizId)?.Questions;
                return dataSource;
            }
        }
            //dodawanie 
        public int Add_quiz_to_database(string nameOfQuiz)////////////dodawanie quizu
        {
            using (var db = new AppContext())
            {
                Quiz quiz = new Quiz()
                {
                    Name = nameOfQuiz
                };
                db.Quizes.Add(quiz);
                db.SaveChanges();
                return quiz.Id;
                //Name_of_quiz_label.Text = NameOfQuizDeliver;
            }
        }

        public int Add_question_to_database(int quizId, string ask)//////////////////dodawanie pytań
        {
            using (var db = new AppContext())
            {
                var quiz = db.Quizes.FirstOrDefault(a => a.Id == quizId);
                if (quiz.Questions == null)
                    quiz.Questions = new List<Question>();
                //var answers = new List<Answer>(); //tworzy sie lista ktora potem jest wrzucana do bazy
                var question = new Question()
                {
                    Ask = ask,
                };
                quiz.Questions.Add(question);
                db.SaveChanges();
                return question.Id;
                
            }
        }

        public void Add_answer_to_database(int questId, string answer, bool isCorrect)/////////////dodawanie odpowiedzi
        {
            using (var db = new AppContext())
            {
                
                var question = db.Questions.FirstOrDefault(a => a.Id == questId);
                question.Answers = new List<Answer>();
                //var answers = question.Answers;
                //question.Answers = answers;

                question.Answers.Add(new Answer()
                {
                  Ans  = answer,
                  IsCorrect = isCorrect
                });
                
                db.SaveChanges();
            }
        }
        //edytowanie
        public void Change_quiz_name(int quizId, string nameOfQuiz)
        {
            using (var db = new AppContext())
            {
                var quiz = db.Quizes.FirstOrDefault(a => a.Id == quizId);
                if (quiz != null) quiz.Name = nameOfQuiz;
                db.Entry(quiz).State=EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
