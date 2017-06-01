using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testownik.Views
{
    public partial class EndQuiz : Form
    {
        public int Score { get; set; }
        public int Max { get; set; }

        public EndQuiz()
        {
            InitializeComponent();
        }

        private void Ok_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void EndQuiz_Load(object sender, EventArgs e)
        {
            Total_pts.Text = Score.ToString();
            Max_pts.Text = Max.ToString();
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            var menu = new StartPage();
            menu.Show();
            Hide();
        }

        private void EndQuiz_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
