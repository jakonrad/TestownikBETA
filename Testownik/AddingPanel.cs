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

        private int quizID { get; set; }
        private string questID { get; set; }
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
            /////////////////////////////////////////////////////////////////////dodawanie pytań
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

                    }
                    clearFields();
                    MessageBox.Show("Pomyślnie dodano pytanie");
                }

            }///////////////////////////////////////////////////////////////////////////////////tutaj jest edycja pytań
            else if (Add_button.Text == "Aktualizuj pytanie")
            {
                if (isChecked() == true)
                {
                    using (var db = new AppContext())
                    {
                        Answer ans = new Answer();
                        Question question = new Question();
                        //wyciąganie pytania z bazy
                        int questid= Int32.Parse(questID);
                        question = db.Questions.FirstOrDefault(b => b.Id ==questid );
                        question.Answers = new List<Answer>();
                        //Answer answers = new Answer();
                        ans = db.Answers.FirstOrDefault(a => a.Question.Id == questid);
                        int ansid = ans.Id;

                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid);
                        if (A_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            ans.Ans = A_textbox.Text;
                            ans.IsCorrect = true;
                            
                            db.Entry(ans).State= EntityState.Modified;
                        }
                        else
                        {
                            ans.Ans = A_textbox.Text;
                            db.Entry(ans).State= EntityState.Modified;
                        }
                        
                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid+1);
                        if (B_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            ans.Ans = B_textbox.Text;
                            ans.IsCorrect = true;

                            db.Entry(ans).State = EntityState.Modified;
                        }
                        else
                        {
                            ans.Ans = B_textbox.Text;
                            db.Entry(ans).State = EntityState.Modified;
                        }
                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid+2);
                        if (C_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            ans.Ans = C_textbox.Text;
                            ans.IsCorrect = true;

                            db.Entry(ans).State = EntityState.Modified;
                        }
                        else
                        {
                            ans.Ans = C_textbox.Text;
                            db.Entry(ans).State = EntityState.Modified;
                        }
                        ans = db.Answers.FirstOrDefault(a => a.Id == ansid+3);
                        if (D_checkbox.Checked) //dodajemy 1 odp do bazy
                        {
                            ans.Ans = D_textbox.Text;
                            ans.IsCorrect = true;

                            db.Entry(ans).State = EntityState.Modified;
                        }
                        else
                        {
                            ans.Ans = D_textbox.Text;
                            db.Entry(ans).State = EntityState.Modified;
                        }
                        db.SaveChanges();
                        updateDGV();
                    }
                    clearFields();
                    Add_button.Text = "Dodaj";
                }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////koniec edycji
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
            //qlist = null;
            using (var db = new AppContext())
            {  // Quiz quiz= new Quiz();
                Question question = new Question();
                List<Question> test=new List<Question>();
                //quiz.Questions=new List<Question>();
                //test = quiz.Questions;
                question = db.Questions.FirstOrDefault(a=>a.Quiz.Id==quizID);
                int temp=question.Id;
                for (int i = temp; i <= db.Questions.Count(x => x.Id == temp); i++)
                {
                    question = db.Questions.FirstOrDefault(a => a.Id == i);
                    test.Add(question);
                }
                if (qlist != null) qlist.AddRange(test);
            }

                //qlist.AddRange(questList);
                //dataGridView1.DataSource = null;
            dataGridView1.DataSource = qlist;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ask"].HeaderText = "Treść pytania";
            dataGridView1.Columns["Quiz"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //klik prawego przycisku myszki
            dataGridView1.MouseClick+=new MouseEventHandler(dataGridView1_MouseClick);

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("left");
            }
            else
            {
                //MessageBox.Show("Right");

            ContextMenuStrip menu= new ContextMenuStrip();
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                MessageBox.Show(position_xy_mouse_row.ToString());
            }
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

        private void getAnswersFromQuestions(int test)
        {

            using (var db = new AppContext())
            {
                Answer ans = new Answer();
                Question question = new Question();
                //wyciąganie pytania z bazy
                question = db.Questions.FirstOrDefault(b => b.Id == test);
                question.Answers = new List<Answer>();
                int temp = question.Id;
                //przypisanie pytań znajdujących się w bazie do textboxów
                Question_textbox.Text = question.Ask;
                //odpowiedź A
                ans = db.Answers.FirstOrDefault(c => c.Question.Id == temp);
                int pomocnicza = ans.Id;
                A_textbox.Text = ans.Ans;
                if (ans.IsCorrect == true)
                    A_checkbox.CheckState = CheckState.Checked;
                //odpowiedź B
                ans = db.Answers.FirstOrDefault(c => c.Id == pomocnicza + 1);
                B_textbox.Text = ans.Ans;
                if (ans.IsCorrect == true)
                    B_checkbox.CheckState = CheckState.Checked;
                //odpowiedź C
                ans = db.Answers.FirstOrDefault(c => c.Id == pomocnicza + 2);
                C_textbox.Text = ans.Ans;
                if (ans.IsCorrect == true)
                    C_checkbox.CheckState = CheckState.Checked;
                //odpowiedź D
                ans = db.Answers.FirstOrDefault(c => c.Id == pomocnicza + 3);
                D_textbox.Text = ans.Ans;
                if (ans.IsCorrect == true)
                    D_checkbox.CheckState = CheckState.Checked;




            }


        }

        private void Clear_button_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clearFields();
            questID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            getAnswersFromQuestions(Int32.Parse(questID));
            Add_button.Text = "Aktualizuj pytanie";

        }
    }
}
