using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testownik
{
    public partial class NameOfQuiz : Form
    {
        public NameOfQuiz()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            if (Name_of_quiz_textbox.Text.Length < 3)
            {
                MessageBox.Show("Nazwa testu musi się składać z minimum trzech znaków!");
            }
            else
            {
                var panel = new AddingPanel
                {
                    NameOfQuizDeliver = Name_of_quiz_textbox.Text,
                    IsQuizExist = false
                };
                panel.Show();
                Hide();
            }
            
        }

        private void NameOfQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
