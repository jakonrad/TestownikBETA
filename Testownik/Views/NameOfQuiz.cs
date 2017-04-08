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
            var panel = new AddingPanel
            {
                NameOfQuizDeliver = Name_of_quiz_textbox.Text
            };
            panel.Show();
            Hide();
        }
    }
}
