using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        private string questID { get; set; }
        private List<Question> questList { get; set; }


        public AddingPanel()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void AddingPanel_Load(object sender, EventArgs e)
        {
            UpdateDgv();
            Name_of_quiz_label.Text = NameOfQuizDeliver;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////dodawanie pytań
            if (Add_button.Text == "Dodaj")
            {
                if (IsChecked())
                {
                    using (var db = new AppContext())
                    {
                        var quiz = db.Quizes.FirstOrDefault(); // FirstOrDefault(a => a.Id == quizID); - zmieniłem ze bierze pierwszy z bazy testowo
                        if (quiz == null) return;
                        if (quiz.Questions == null)
                            quiz.Questions = new List<Question>();

                        var answers = new List<Answer>(); //tworzy sie lista ktora potem jest wrzucana do bazy
                        var question = new Question()
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

                        UpdateDgv();
                    }
                    ClearFields();
                    MessageBox.Show("Pomyślnie dodano pytanie");
                }
            }///////////////////////////////////////////////////////////////////////////////////tutaj jest edycja pytań
            else if (Add_button.Text == "Aktualizuj pytanie")
            {
                if (!IsChecked()) return;
                using (var db = new AppContext())
                {
                    //wyciąganie pytania z bazy
                    int questid = Int32.Parse(questID);
                    var question = db.Questions.FirstOrDefault(b => b.Id == questid);
                    if (question == null) return;

                    question.Answers = new List<Answer>();
                    //Answer answers = new Answer();
                    var ans = db.Answers.FirstOrDefault(a => a.Question.Id == questid);
                    if (ans != null)
                    {
                        int ansid = ans.Id;

                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid);
                        if (A_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            if (ans != null)
                            {
                                ans.Ans = A_textbox.Text;
                                ans.IsCorrect = true;

                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }
                        else
                        {
                            if (ans != null)
                            {
                                ans.Ans = A_textbox.Text;
                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }

                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid + 1);
                        if (B_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            if (ans != null)
                            {
                                ans.Ans = B_textbox.Text;
                                ans.IsCorrect = true;

                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }
                        else
                        {
                            if (ans != null)
                            {
                                ans.Ans = B_textbox.Text;
                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }

                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid + 2);
                        if (C_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            if (ans != null)
                            {
                                ans.Ans = C_textbox.Text;
                                ans.IsCorrect = true;

                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }
                        else
                        {
                            if (ans != null)
                            {
                                ans.Ans = C_textbox.Text;
                                db.Entry(ans).State = EntityState.Modified;
                            }
                        }

                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid + 3);
                    }
                    if (D_checkbox.Checked) //dodajemy 1 odp do bazy
                    {
                        if (ans != null)
                        {
                            ans.Ans = D_textbox.Text;
                            ans.IsCorrect = true;

                            db.Entry(ans).State = EntityState.Modified;
                        }
                    }
                    else
                    {
                        if (ans != null)
                        {
                            ans.Ans = D_textbox.Text;
                            db.Entry(ans).State = EntityState.Modified;
                        }
                    }

                    db.SaveChanges();
                    UpdateDgv();
                }

                ClearFields();
                Add_button.Text = "Dodaj";
            }
        }

        private void ClearFields()
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

        private void UpdateDgv()
        {
            using (var db = new AppContext())
            {
                var quizes = db.Quizes.AsNoTracking().ToList();
                if (!quizes.Any())
                {
                    db.Quizes.Add(new Quiz()
                    {
                        Name = NameOfQuizDeliver,
                        Questions = new List<Question>()
                    });
                    db.SaveChanges();
                }

                dataGridView1.DataSource = quizes.FirstOrDefault()?.Questions;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Ask"].HeaderText = "Treść pytania";
                dataGridView1.Columns["Quiz"].Visible = false;
                //dataGridView1.RowHeadersVisible = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //klik prawego przycisku myszki
                //dataGridView1.MouseClick += dataGridView1_MouseClick;
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("left");
            }
            else
            {
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                //MessageBox.Show(position_xy_mouse_row.ToString());
            }
        }

        private bool IsChecked()
        {
            if (string.IsNullOrEmpty(A_textbox.Text) || string.IsNullOrEmpty(B_textbox.Text) ||
                string.IsNullOrEmpty(C_textbox.Text) || string.IsNullOrEmpty(D_textbox.Text) ||
                string.IsNullOrEmpty(Question_textbox.Text))
            {
                MessageBox.Show("Błąd: Nie wypełniłeś wszystkich pól!");
                return false;
            }
            if (A_checkbox.Checked == false && B_checkbox.Checked == false && C_checkbox.Checked == false &&
                D_checkbox.Checked == false)
            {
                MessageBox.Show(
                    "Błąd: Nie zaznaczyłeś ani jednej poprawnej odpowiedzi. Zaznacz przynajmniej jedną!");
                return false;
            }

            return true;

        }

        private void GetAnswersFromQuestions(int questionId)
        {
            using (var db = new AppContext())
            {
                //wyciąganie pytania z bazy
                var question = db.Questions.FirstOrDefault(b => b.Id == questionId);
                if (question == null)
                    return;

                //przypisanie pytań znajdujących się w bazie do textboxów
                Question_textbox.Text = question.Ask;
                //odpowiedź A
                for (int i = 0; i < question.Answers.Count; i++)
                {
                    var ans = question.Answers[i];
                    if (ans == null) break;
                    switch (i)
                    {
                        case 0:
                            {
                                A_textbox.Text = ans.Ans;
                                if (ans.IsCorrect)
                                    A_checkbox.CheckState = CheckState.Checked;
                                break;
                            }
                        case 1:
                            {
                                B_textbox.Text = ans.Ans;
                                if (ans.IsCorrect)
                                    B_checkbox.CheckState = CheckState.Checked;
                                break;
                            }
                        case 2:
                            {
                                C_textbox.Text = ans.Ans;
                                if (ans.IsCorrect)
                                    C_checkbox.CheckState = CheckState.Checked;
                                break;
                            }
                        case 3:
                            {
                                D_textbox.Text = ans.Ans;
                                if (ans.IsCorrect)
                                    D_checkbox.CheckState = CheckState.Checked;
                                break;
                            }

                    }
                }
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            if (dataGridView1.CurrentRow != null) questID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            GetAnswersFromQuestions(Int32.Parse(questID));
            Add_button.Text = "Aktualizuj pytanie";

        }
    }
}
