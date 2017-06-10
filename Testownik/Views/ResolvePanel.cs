using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Testownik.Models;
using Testownik.Properties;
using Testownik.Services;

namespace Testownik.Views
{
    public partial class ResolvePanel : Form
    {
        public int QuizIdDeliver { get; set; }
        private List<Question> questsList { get; set; }
        //public List<Answer> answersList { get; set; }
        //private Timer stopwatch;
        private List<TicksAnswers> CorrectOrIncorrect { get; set; }
        private short hours, mins, sec;
        private int numberOfQuestion { get; set; }
        private Button selectedButton { get; set; }
        private readonly ResolveManagmentService _service = new ResolveManagmentService();
        public ResolvePanel()
        {
            InitializeComponent();

        }

        private void ResolvePanel_Load(object sender, EventArgs e)
        {
            Name_of_quiz_label.Text = _service.Get_quiz_name(QuizIdDeliver);
            //ładowanie pierwszego pytania
            numberOfQuestion = 0;
            questsList = _service.Get_question_list(QuizIdDeliver);
            Load_question();
            //ładowanie przycisków nawigacji
            choose_question_flowlayoutPanel.AutoScroll = true;
            choose_question_flowlayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            choose_question_flowlayoutPanel.AutoSize = false;
            choose_question_flowlayoutPanel.WrapContents = false;
            var count = questsList.Count;
            Amount_of_question.Text = count.ToString();
            for (int i = 0; i < count; i++)
            {
                var button = _service.GetButton(string.Format("{0}", i + 1));
                choose_question_flowlayoutPanel.Controls.Add(button);
                button.Click += new EventHandler(button_click);
            }
            timer1.Start();
            sec = 0;
            hours = 0;
            mins = 0;
            Time_label.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, sec);
            CorrectOrIncorrect = _service.Get_list_of_ticked_answers(count);
        }

        private void button_click(object sender, EventArgs e)
        {
            selectedButton = (Button)sender;
            numberOfQuestion = Int32.Parse(selectedButton.Text) - 1;
            Load_question();
            Tick_answers();
        }

        private void Next_question_button_Click(object sender, EventArgs e)
        {
            ++numberOfQuestion;
            if (numberOfQuestion < questsList.Count)
            {
                Load_question();
                Tick_answers();
            }
            else
            {
                --numberOfQuestion;
                MessageBox.Show(Resources.ResolvePanel_Brak_wiekszej_ilości_pytań_);
            }
        }

        private void A_button_Click(object sender, EventArgs e)
        {
            if (A_button.BackColor == SystemColors.Control)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "A", true);
                A_button.BackColor = _service.Get_color(false);
            }
            else if (A_button.BackColor == Color.Aqua)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "A", false);
                A_button.BackColor = _service.Get_color(true);
            }
        }

        private void B_button_Click(object sender, EventArgs e)
        {
            if (B_button.BackColor == SystemColors.Control)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "B", true);
                B_button.BackColor = _service.Get_color(false);
            }
            else if (B_button.BackColor == Color.Aqua)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "B", false);
                B_button.BackColor = _service.Get_color(true);
            }
        }

        private void C_button_Click(object sender, EventArgs e)
        {
            if (C_button.BackColor == SystemColors.Control)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "C", true);
                C_button.BackColor = _service.Get_color(false);
            }
            else if (C_button.BackColor == Color.Aqua)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "C", false);
                C_button.BackColor = _service.Get_color(true);
            }
        }

        private void D_button_Click(object sender, EventArgs e)
        {
            if (D_button.BackColor == SystemColors.Control)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "D", true);
                D_button.BackColor = _service.Get_color(false);
            }
            else if (D_button.BackColor == Color.Aqua)
            {
                CorrectOrIncorrect = _service.Change_tick_answer(CorrectOrIncorrect, numberOfQuestion, "D", false);
                D_button.BackColor = _service.Get_color(true);
            }
        }

        private void Load_question()
        {
            //questsList = _service.Get_question_list(QuizIdDeliver);
            int questid = 0;
            questid = questsList[numberOfQuestion].Id;
            var answersList = _service.Get_answer_list(questid);
            Question_name_label.Text = questsList[numberOfQuestion].Ask;
            A_button.Text = answersList[0].Ans;
            B_button.Text = answersList[1].Ans;
            C_button.Text = answersList[2].Ans;
            D_button.Text = answersList[3].Ans;
            if (numberOfQuestion != 0) Tick_answers();
            Number_of_question.Text = (numberOfQuestion + 1).ToString();
        }

        private void Tick_answers()
        {
            Unmark_answers();
            if (CorrectOrIncorrect[numberOfQuestion].MarkAnswers[0] == false) A_button.BackColor = _service.Get_color(true);
            else A_button.BackColor = _service.Get_color(false);

            if (CorrectOrIncorrect[numberOfQuestion].MarkAnswers[1] == false) B_button.BackColor = _service.Get_color(true);
            else B_button.BackColor = _service.Get_color(false);

            if (CorrectOrIncorrect[numberOfQuestion].MarkAnswers[2] == false) C_button.BackColor = _service.Get_color(true);
            else C_button.BackColor = _service.Get_color(false);

            if (CorrectOrIncorrect[numberOfQuestion].MarkAnswers[3] == false) D_button.BackColor = _service.Get_color(true);
            else D_button.BackColor = _service.Get_color(false);
        }

        private void Unmark_answers()
        {
            A_button.BackColor = _service.Get_color(true);
            B_button.BackColor = _service.Get_color(true);
            C_button.BackColor = _service.Get_color(true);
            D_button.BackColor = _service.Get_color(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sec < 59)
            {
                sec++;
            }
            else
            {
                sec = 0;
                if (mins < 59)
                {
                    mins++;
                }
                else
                {
                    hours++;
                    mins = 0;
                }
            }

            Time_label.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, mins, sec);
        }

        private void End_quiz_button_Click(object sender, EventArgs e)
        {
            var requestForm = new EndQuizRequest();
            var maxscore = _service.Get_maxscore_amount(QuizIdDeliver);
            //przekazanie punktów
            requestForm.Score = _service.Check_answers(CorrectOrIncorrect, questsList.Count, QuizIdDeliver);
            requestForm.Max = maxscore;
            //przekazanie czasu
            timer1.Stop();
            requestForm.Hours = hours;
            requestForm.Mins = mins;
            requestForm.Sec = sec;
            //
            requestForm.Show();
            requestForm.panel = this;
        }

        private void ResolvePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
