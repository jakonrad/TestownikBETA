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
using Testownik.Services;

namespace Testownik.Views
{
    public partial class GetQuiz : Form
    {
        public GetQuiz()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            StartPage start_form = new StartPage();
            start_form.Show();
            Hide();

        }

        private void Start_quiz_button_Click(object sender, EventArgs e)
        {
            
            ResolvePanel resolve_panel = new ResolvePanel();
           // GetQuizService.Load_selected_quiz(Choose_quiz_combobox.SelectedValue.ToString());
            var id = Int32.Parse(Choose_quiz_combobox.SelectedValue.ToString());
            resolve_panel.QuizIdDeliver = id;
            resolve_panel.Show();
            Hide();
        }

        private void GetQuiz_Load(object sender, EventArgs e)
        {
            using (var db = new AppContext())
            {
                var quizes = db.Quizes.ToList();
                Choose_quiz_combobox.DataSource = quizes;
                Choose_quiz_combobox.ValueMember = "Id";
                Choose_quiz_combobox.DisplayMember = "Name";
            }
        }

        private void Choose_quiz_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Choose_quiz_combobox.SelectedValue.ToString());
            
        }

        private void GetQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
