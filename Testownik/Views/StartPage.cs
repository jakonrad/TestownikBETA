using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testownik.Views;

namespace Testownik
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            NameOfQuiz form= new NameOfQuiz();
            form.Show();
            Hide();
        }

        private void Resolve_button_Click(object sender, EventArgs e)
        {
            GetQuiz get_form= new GetQuiz();
            get_form.Show();
            Hide();
        }
        private void Browse_button_Click(object sender, EventArgs e)
        {
            BrowseQuizes browse= new BrowseQuizes();
            browse.Show();
            Hide();
        }

        private void Quit_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void StartPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
