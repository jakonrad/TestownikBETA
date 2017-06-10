using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Testownik.Models;
using Testownik.Views;

namespace Testownik.Services
{
    class ResolveManagmentService
    {
        //public int QuizID { get; set; }
        public Button GetButton(string text)       //dodaje buttony do szybkiej nawigacji
        {
            var button = new Button();
            button.Text = text;
            button.Width = 45;
            button.Height = button.Width;
            return button;
        }

        public string Get_quiz_name(int id)     //przekazuje nazwe quizu
        {

            using (var db = new AppContext())
            {
                var quiz = db.Quizes.FirstOrDefault(a => a.Id == id);
                string name = quiz.Name;
                return name;
            }
        }

        public List<Question> Get_question_list(int quizId)     //przekazuje gotową liste pytan w danym quizie
        {
            using (var db = new AppContext())
            {
                var firstOrDefault = db.Quizes.FirstOrDefault(b => b.Id == quizId);
                var questions = firstOrDefault?.Questions.ToList();
                short temp=0;
                if (questions != null && questions.Count == 0) return null;
                foreach (var t in questions)
                {
                    if (t.Answers.Count == 0)
                    {

                        temp++;
                    }
                }
                if (temp == 0)
                {
                    return questions;
                }
                return null;
            }
        }

        public List<Answer> Get_answer_list(int questId)       //przekazuje liste odpowiedzi dla danego pytania
        {
            using (var db = new AppContext())
            {
                var answers = db.Questions.FirstOrDefault(a => a.Id == questId).Answers.ToList();
                return answers;
            }
        }

        public Color Get_color(bool isColored)          //przekazuje odpowiedni kolor 
        {
            if (isColored)
            {
                return SystemColors.Control;
            }
            else
            {
                return Color.Aqua;
            }

        }

        public int Get_maxscore_amount(int numberOfQuiz)       //przekazuje maksymalna ilosc punktow do zdobycia aby poprawnie moglo podliczyc
        {
            using (var db = new AppContext())
            {
                int score=0;
                var questions = db.Quizes.FirstOrDefault(a => a.Id == numberOfQuiz).Questions;
                var answers=new List<Answer>();
                int count = questions.Count+questions[0].Id-1;
                for (int i = questions[0].Id; i <= count; i++)
                {
                    answers = db.Questions.FirstOrDefault(c => c.Id == i).Answers;
                    for (int b = 0; b < 4; b++)
                    {
                        if (answers[b].IsCorrect) score++;
                    }
                }
                return score;
                
            }
        }
        public List<TicksAnswers> Get_list_of_ticked_answers(int amount)         //przekazuje gotowa niewypelniona liste zaznaczonych odpowiedzi do widoku
        {
            List<TicksAnswers> list = new List<TicksAnswers>();
            for (int i = 0; i < amount; i++)
            {
                var ticksanswers = new TicksAnswers(i);
                list.Add(ticksanswers);
            }
            return list;
        }

        public List<TicksAnswers> Change_tick_answer(List<TicksAnswers> list, int numberOfQuestion, string ans, bool tick)    //metoda ktora sprawdza jakie odpowiedzi sa zaznaczone i wpisuje odpowiednie wartosci do listy
        {
            

            if (ans == "A" && tick) list[numberOfQuestion].MarkAnswers[0] = true;
            else if (ans == "A" && !tick) list[numberOfQuestion].MarkAnswers[0] = false;

            if (ans == "B" && tick) list[numberOfQuestion].MarkAnswers[1] = true;
            else if (ans == "B" && !tick) list[numberOfQuestion].MarkAnswers[1] = false;

            if (ans == "C" && tick) list[numberOfQuestion].MarkAnswers[2] = true;
            else if (ans == "C" && !tick) list[numberOfQuestion].MarkAnswers[2] = false;

            if (ans == "D" && tick) list[numberOfQuestion].MarkAnswers[3] = true;
            else if (ans == "D" && !tick) list[numberOfQuestion].MarkAnswers[3] = false;

            return list;
        }

        public int Check_answers(List<TicksAnswers> marked_answers, int count, int quizId)        //metoda sprawdzająca poprawne odpowiedzi i zliczająca punkty
        {
            int score = 0;
            int ansScore = 0;
            using (var db = new AppContext())
            {
               // bool[] correctAns = new bool[4];
                for (int i = 0; i < count; i++)
                {
                   // marked_answers[i].markAnswers = new bool[4];
                    var answer = db.Questions.FirstOrDefault(a => a.Quiz.Id == quizId).Answers;
                    for (int a = 0; a < 4; a++)
                    {
                        if (marked_answers[i].MarkAnswers[a] && answer[a].IsCorrect) ansScore++;
                    }

                    for (int a = 0; a < 4; a++)
                    {
                        if (marked_answers[i].MarkAnswers[a] && !answer[a].IsCorrect) ansScore=0;
                        if (ansScore == 0) break;
                    }
                    score =ansScore+score;
                    ansScore = 0;
                }
            }

            return score;
        }

    }
}