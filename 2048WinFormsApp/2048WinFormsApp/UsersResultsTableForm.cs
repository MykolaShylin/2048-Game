using _2048GameClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace _2048WinFormsApp
{
    public partial class UsersResultsTableForm : Form
    {
        private DataGridViewCell number;
        private DataGridViewCell name;
        private DataGridViewCell score;
        private DataGridViewRow row;
        private UsersResultsStorage resultsStorage;
        public UsersResultsTableForm()
        {
            InitializeComponent();
        }

        private void mainMenuBatton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearTableButton_Click(object sender, EventArgs e)
        {
            usersResultsTable.Rows.Clear();
            resultsStorage.ClearUsersResults();
            MessageBox.Show("Таблица очищена!", "Информирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bestResultButton_Click(object sender, EventArgs e)
        {
            resultsStorage = new();
            var usersResults = resultsStorage.GetUsersResults();
            DialogResult result;
            if (usersResults.Count() != 0)
            {
                usersResults = usersResults.OrderByDescending(x => x.Score).ToList();
                var name = usersResults.First().Name;
                var score = usersResults.First().Score;
                MessageBox.Show($"{name} - лучший из лучших, счет которого составляет {score} очка(-ов)! Попробуй побей его рекорд и займи место чемпиона!", "Чемпион", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Чемпион пока не определен! Начни игру и стань лидером!", "Чемпион", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UsersResultsTableForm_Load(object sender, EventArgs e)
        {
            resultsStorage = new();
            var usersResults = resultsStorage.GetUsersResults();
            if (usersResults.Count() == 0)
            {
                MessageBox.Show("Результатов нет, пройдите тест и будьте первым в таблице!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                usersResults = usersResults.OrderByDescending(x => x.Score).ToList();
                int rowNumber = 1;

                for (int i = 1; i < usersResults.Count; i++)
                {
                    number = new DataGridViewTextBoxCell();
                    name = new DataGridViewTextBoxCell();
                    score = new DataGridViewTextBoxCell();
                    row = new DataGridViewRow();

                    number.Value = rowNumber++;
                    name.Value = usersResults[i].Name;
                    score.Value = usersResults[i].Score;

                    row.Cells.AddRange(number, name, score);
                    usersResultsTable.Rows.AddRange(row);
                }
            }
        }
    }
}
