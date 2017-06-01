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
    public partial class EndQuizRequest : Form
    {
        public int Score { get; set; }
        public int Max { get; set; }
        public int Hours { get; set; }
        public int Mins { get; set; }
        public int Sec { get; set; }
        public ResolvePanel panel { get; set; }
        public EndQuizRequest()
        {
            InitializeComponent();
        }

        private void Yes_button_Click(object sender, EventArgs e)
        {
            var form=new EndQuiz();
            form.Max = Max;
            form.Score = Score;
            form.Hours = Hours;
            form.Mins = Mins;
            form.Sec = Sec;
            form.Show();
            Hide();
            panel.Visible = false;
        }

        private void No_button_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void EndQuizRequest_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
