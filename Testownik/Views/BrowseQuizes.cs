using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testownik.Services;

namespace Testownik.Views
{
    public partial class BrowseQuizes : Form
    {
        //zmienne
        private readonly BrowserManagmentService _service = new BrowserManagmentService();
        public string quizID { get; set; }
        public string quizName { get; set; }
        public BrowseQuizes()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BrowseQuizes_Load(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
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
                quizID = dataGridView1.Rows[position_xy_mouse_row].Cells["Id"].Value.ToString();
                quizName = dataGridView1.Rows[position_xy_mouse_row].Cells["Name"].Value.ToString();

                if (position_xy_mouse_row >= 0)
                {
                    menu_for_question.Items.Add("Usuń test").Name = "Del";
                    menu_for_question.Items.Add("Edytuj test").Name = "Edit";
                }
                menu_for_question.Show(dataGridView1, new Point(e.X, e.Y));
                menu_for_question.ItemClicked += new ToolStripItemClickedEventHandler(menu_for_ItemClicked);
            }
        }

        private void menu_for_ItemClicked(object sender, ToolStripItemClickedEventArgs e)           // obsługa kliku opcji w menu
        {
            int quizId = Int32.Parse(quizID);
            switch (e.ClickedItem.Name)
            {
                case "Del":
                    
                    _service.DeleteQuiz(quizId);
                    UpdateDgv();
                    break;

                case "Edit":
                   var panel= new AddingPanel()
                    {
                        IsQuizExist = true,
                        NameOfQuizDeliver = quizName,
                        QuizID = quizId
                    };
                    panel.Show();
                    Hide();
                    break;
            }
        }

        private void UpdateDgv()
        {
            dataGridView1.DataSource = _service.Get_list_of_quizes();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Name"].HeaderText = "Nazwa testu";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
        }

        private void Return_button_Click(object sender, EventArgs e)
        {
            var menu = new StartPage();
            menu.Show();
            Hide();
        }

        private void BrowseQuizes_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
