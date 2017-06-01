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
using Testownik.Properties;
using Testownik.Services;

namespace Testownik
{
    public partial class AddingPanel : Form
    {
        //zmienne
        public string NameOfQuizDeliver { get; set; }
        public bool IsQuizExist { get; set; }
        private string questID { get; set; }
        private List<Question> questList { get; set; }
        public int QuizID { get; set; }
        private bool bool_changeButton = true;
        
        

        private readonly QuestionManagmentService _service = new QuestionManagmentService();


        public AddingPanel()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Change_name_of_quiz_textbox.Visible = false;
            this.Cancel_button.Visible = false;
        }

        private void AddingPanel_Load(object sender, EventArgs e)
        {
            //UpdateDgv();
            Name_of_quiz_label.Text = NameOfQuizDeliver;
            if(!IsQuizExist) QuizID = _service.Add_quiz_to_database(NameOfQuizDeliver);
            UpdateDgv();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////////////////////dodawanie pytań
            if (Add_button.Text == Resources.AddingPanel_Clear_button_Click_Dodaj)
            {
                if (IsChecked())
                {
                    var questId = _service.Add_question_to_database(QuizID, Question_textbox.Text);


                    if (A_checkbox.Checked) //dodajemy 1 odp do bazy
                    {
                        _service.Add_answer_to_database(questId, A_textbox.Text, true);
                    }
                    else
                    {
                        _service.Add_answer_to_database(questId, A_textbox.Text, false);
                    }

                    if (B_checkbox.Checked) //dodajemy 2 odp
                    {
                        _service.Add_answer_to_database(questId, B_textbox.Text, true);
                    }
                    else
                    {
                        _service.Add_answer_to_database(questId, B_textbox.Text, false);
                    }

                    if (C_checkbox.Checked) //dodajemy 3 odp
                    {
                        _service.Add_answer_to_database(questId, C_textbox.Text, true);
                    }
                    else
                    {
                        _service.Add_answer_to_database(questId, C_textbox.Text, false);
                    }

                    if (D_checkbox.Checked) //dodajemy 4 odp
                    {
                        _service.Add_answer_to_database(questId, D_textbox.Text, true);
                    }
                    else
                    {
                        _service.Add_answer_to_database(questId, D_textbox.Text, false);
                    }

                    UpdateDgv();
                    ClearFields();
                    MessageBox.Show(Resources.AddingPanel_Add_button_Click_Pomyślnie_dodano_pytanie);
                }
            }///////////////////////////////////////////////////////////////////////////////////tutaj jest edycja pytań
            else if (Add_button.Text == Resources.AddingPanel_Add_button_Click_Aktualizuj_pytanie)
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
                                ans.IsCorrect = false;
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
                MessageBox.Show(Resources.AddingPanel_Add_button_Click_Pomyślnie_edytowano_pytanie);
                Add_button.Text = Resources.AddingPanel_Clear_button_Click_Dodaj;
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            ClearFields();
            Add_button.Text = Resources.AddingPanel_Clear_button_Click_Dodaj;
        }

        private void Change_quiz_name_button_Click(object sender, EventArgs e)
        {
            if (bool_changeButton)
            {
                Name_of_quiz_label.Visible = false;
                Change_name_of_quiz_textbox.Visible = true;
                Change_name_of_quiz_textbox.Text = Name_of_quiz_label.Text;
                Change_quiz_name_button.Text = Resources.AddingPanel_Change_quiz_name_button_Click_Potwierdź_zmianę;
                Cancel_button.Visible = true;
                bool_changeButton = false;
            }
            else
            {
                if (Change_name_of_quiz_textbox.Text.Length < 3)
                {
                    MessageBox.Show(Resources.Change_name_button_warning_min_3_letters);
                }
                else
                {
                    _service.Change_quiz_name(QuizID, Change_name_of_quiz_textbox.Text);
                    MessageBox.Show(Resources.AddingPanel_Change_quiz_name_button_Click_Nazwa_testu_została_pomyślnie_zmieniona);
                }

                Name_of_quiz_label.Text = Change_name_of_quiz_textbox.Text;
                Change_name_of_quiz_textbox.Visible = false;
                Name_of_quiz_label.Visible = true;
                Cancel_button.Visible = false;
                Change_quiz_name_button.Text = Resources.AddingPanel_Change_quiz_name_button_Click_Zmień_nazwę_testu;
                bool_changeButton = !bool_changeButton;
            }

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Change_name_of_quiz_textbox.Visible = false;
            Name_of_quiz_label.Visible = true;
            Change_quiz_name_button.Text = Resources.AddingPanel_Change_quiz_name_button_Click_Zmień_nazwę_testu;
            bool_changeButton = true;
            Cancel_button.Visible = false;
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
                MessageBox.Show("Błąd: Nie zaznaczyłeś ani jednej poprawnej odpowiedzi. Zaznacz przynajmniej jedną!");
                return false;
            }

            return true;

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
            dataGridView1.DataSource = _service.Get_list_of_question(QuizID);
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Ask"].HeaderText = "Treść pytania";
            dataGridView1.Columns["Quiz"].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //klik prawego przycisku myszki
            dataGridView1.MouseClick += dataGridView1_MouseClick;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ClearFields();
            //if (dataGridView1.CurrentRow != null) questID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            //GetAnswersFromQuestions(Int32.Parse(questID));
            //Add_button.Text = Resources.AddingPanel_Add_button_Click_Aktualizuj_pytanie;

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


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)    //////////////////metoda która wczytuje klik myszki
        {
            if (e.Button == MouseButtons.Left)
            {
                //MessageBox.Show("left");
            }
            else
            {
                ContextMenuStrip menu_for_question = new ContextMenuStrip();
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                //MessageBox.Show(position_xy_mouse_row.ToString());
                questID = dataGridView1.Rows[position_xy_mouse_row].Cells["Id"].Value.ToString();

                if (position_xy_mouse_row >= 0)
                {
                    menu_for_question.Items.Add("Usuń pytanie").Name = "Del";
                }
                menu_for_question.Show(dataGridView1, new Point(e.X, e.Y));
                menu_for_question.ItemClicked += new ToolStripItemClickedEventHandler(menu_for_question_ItemClicked);
            }
        }

        private void menu_for_question_ItemClicked(object sender, ToolStripItemClickedEventArgs e)           // obsługa kliku opcji w menu
        {

            switch (e.ClickedItem.Name.ToString())
            {
                case "Del":
                    int questId = Int32.Parse(questID);
                    _service.DeleteQuestion(questId);
                    UpdateDgv();

                    break;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearFields();
            if (dataGridView1.CurrentRow != null) questID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            GetAnswersFromQuestions(Int32.Parse(questID));
            Add_button.Text = Resources.AddingPanel_Add_button_Click_Aktualizuj_pytanie;
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            var menu= new StartPage();
            menu.Show();
            Hide();
        }

        private void AddingPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
