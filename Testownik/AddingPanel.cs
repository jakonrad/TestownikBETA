using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        private int questID { get; set; }
        private List<Question> questList { get; set; }
        private List<Question> qlist = new List<Question>();

        public AddingPanel()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                if (isChecked() == true)
                {
                    using (var db = new AppContext())
                    {
                        Quiz quiz = new Quiz();
                        quiz = db.Quizes.FirstOrDefault(a => a.Id == quizID);

                        quiz.Questions = new List<Question>();
                        var answers = new List<Answer>(); //tworzy sie lista ktora potem jest wrzucana do bazy
                        Question question = new Question()
                        {
                            Ask = Question_textbox.Text,
                            Answers = answers //tutaj se tą liste wrzuca
                        };

                        if (A_checkbox.Checked) //dodajemy 1 odp do bazy
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

                        if (B_checkbox.Checked) //dodajemy 2 odp
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
                                Ans = B_textbox.Text
                            });
                        }

                        if (C_checkbox.Checked) //dodajemy 3 odp
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

                        if (D_checkbox.Checked) //dodajemy 4 odp
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
                        quiz.Questions.Add(question); //tutaj zostala dodana lista ze wszystkimi odp
                        db.SaveChanges();
                        questList = quiz.Questions;
                        updateDGV();
                        questID = question.Id;
                    }
                    clearFields();
                    MessageBox.Show("Pomyślnie dodano pytanie");
                }

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

        private void updateDGV()
        {
            qlist.AddRange(questList);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = qlist;
            dataGridView1.Columns["Id"].HeaderText = "Id pytania";
            dataGridView1.Columns["Ask"].HeaderText = "Treść pytania";
            dataGridView1.Columns["Quiz"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private bool isChecked()
        {
            if (string.IsNullOrEmpty(A_textbox.Text) || string.IsNullOrEmpty(B_textbox.Text) ||
                string.IsNullOrEmpty(C_textbox.Text) || string.IsNullOrEmpty(D_textbox.Text) ||
                string.IsNullOrEmpty(Question_textbox.Text))
            {
                MessageBox.Show("Błąd: Nie wypełniłeś wszystkich pól!");
                return false;
            }
            else
            {
                if (A_checkbox.Checked == false && B_checkbox.Checked == false && C_checkbox.Checked == false &&
                    D_checkbox.Checked == false)
                {
                    MessageBox.Show(
                        "Błąd: Nie zaznaczyłeś ani jednej poprawnej odpowiedzi. Zaznacz przynajmniej jedną!");
                    return false;
                }
            }
            return true;

        }

        private void getAnswersFromQuestions(int quID)
        {

            using (var db = new AppContext())
            {
                Quiz quiz = new Quiz();
                quiz = db.Quizes.FirstOrDefault(a => a.Id == quizID);
                quiz.Questions = new List<Question>();
                Question question = new Question();
                question = db.Questions.FirstOrDefault(b => b.Id == questID);
                List<Answer>[] ans = new List<Answer>[4];
                

            }


        }

    }
}
