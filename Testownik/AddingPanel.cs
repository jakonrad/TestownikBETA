using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testownik.Models;

namespace Testownik
{
    public partial class AddingPanel : Form
    {
        //zmienne
        public string NameOfQuizDeliver { get; set; }
        private int quizID { get; set; }

        public AddingPanel()
        {
            InitializeComponent();
        }
        private void AddingPanel_Load(object sender, EventArgs e)
        {
            using (var db = new AppContext())
            {
                Quiz quiz = new Quiz()
                {
                    Name = NameOfQuizDeliver
                };
                db.Quizes.Add(quiz);
                db.SaveChanges();
                quizID = quiz.Id;
                Name_of_quiz_label.Text = NameOfQuizDeliver;


            }
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            if (Add_button.Text == "Dodaj")
            {
                using (var db = new AppContext())
                {
                    Quiz quiz= new Quiz();
                    quiz = db.Quizes.FirstOrDefault(a => a.Id == quizID);

                    quiz.Questions= new List<Question>();
                    var answers= new List<Answer>();    //tworzy sie lista ktora potem jest wrzucana do bazy
                    Question question = new Question()
                    {
                        Ask = Question_textbox.Text,
                        Answers = answers  //tutaj se tą liste wrzuca
                    };

                    if (A_checkbox.Checked)   //dodajemy 1 odp do bazy
                    {
                        answers.Add(new Answer()
                        {
                            Ans = A_textbox.Text,
                            IsCorrect = true
                        });
                    }
                    else 
                    {
                        answers.Add(new Answer()
                        {
                            Ans = A_textbox.Text
                        });
                    }

                    if (B_checkbox.Checked)      //dodajemy 2 odp
                    {
                        answers.Add(new Answer()
                        {
                            Ans = B_textbox.Text,
                            IsCorrect = true
                        });
                    }
                    else
                    {
                        answers.Add(new Answer()
                        {
                            Ans= B_textbox.Text
                        });
                    }

                    if (C_checkbox.Checked)        //dodajemy 3 odp
                    {
                        answers.Add(new Answer()
                        {
                            Ans = C_textbox.Text,
                            IsCorrect = true
                        });
                    }
                    else
                    {
                        answers.Add(new Answer()
                        {
                            Ans = C_textbox.Text
                        });
                    }

                    if (D_checkbox.Checked)       //dodajemy 4 odp
                    {
                        answers.Add(new Answer()
                        {
                            Ans = D_textbox.Text,
                            IsCorrect = true
                        });
                    }
                    else
                    {
                        answers.Add(new Answer()
                        {
                            Ans = D_textbox.Text
                        });
                    }
                     quiz.Questions.Add(question);     //tutaj zostala dodana lista ze wszystkimi odp
                    db.SaveChanges();
                }
                clearFields();
            }
        }

        private void clearFields()
        {
            A_checkbox.CheckState = CheckState.Unchecked;
            B_checkbox.CheckState = CheckState.Unchecked;
            C_checkbox.CheckState = CheckState.Unchecked;
            D_checkbox.CheckState = CheckState.Unchecked;

            A_textbox.Clear();
            B_textbox.Clear();
            C_textbox.Clear();
            D_textbox.Clear();
            Question_textbox.Clear();

        }
    }
}
