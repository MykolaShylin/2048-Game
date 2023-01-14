using _2048GameClassLibrary;
using System.Drawing;
using System.Security.Policy;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {

        private Label[,] labelsMap;
        private static int mapSize = 4;
        private static Random random = new Random();
        private int score = 0;
        private User User;
        private int countEmptyLabels;
        private UsersResultsStorage userResult;
        private string[,] lastMoveLabelsMapText;
        private int lastScore;
        private int lastCountEmptyLabels;

        public MainForm(User user)
        {
            InitializeComponent();
            User = user;
            countEmptyLabels = mapSize * mapSize;
        }
        public MainForm(User user, int size)
        {
            InitializeComponent();
            User = user;
            mapSize = size;
            countEmptyLabels = mapSize * mapSize;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }

        private void GenerateNumber()
        {

            if (countEmptyLabels == 0)
            {
                UserRestartChoice(false);
            }
            while (true)
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == String.Empty)
                {
                    var rendomValue = random.Next(101);
                    switch (rendomValue)
                    {
                        case < 26:
                            labelsMap[indexRow, indexColumn].Text = "4";
                            labelsMap[indexRow, indexColumn].BackColor = SystemColors.ScrollBar;
                            break;
                        case > 25:
                            labelsMap[indexRow, indexColumn].Text = "2";
                            labelsMap[indexRow, indexColumn].BackColor = SystemColors.Menu;
                            break;
                    }
                    countEmptyLabels--;
                    break;
                }
            }  

        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLable = CreateLabel(i, j);
                    Controls.Add(newLable);
                    labelsMap[i, j] = newLable;
                }
            }

            int height = (mapSize * 76) + 30;
            int width = mapSize * 76 + 200;

            this.Size = new Size(height, width);
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.Menu;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label.Size = new Size(70, 70);
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Location = new Point(x, y);
            label.Anchor = AnchorStyles.Bottom;
            return label;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Close();
            var newGame = new MainForm(User, mapSize);
            newGame.Show();
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            ReturnOneMoveBack();

            if (e.KeyCode == Keys.Right)
            {
                RightButtonClic();
                GenerateNumber();

            }
            if (e.KeyCode == Keys.Left)
            {
                LeftButtonClic();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Up)
            {
                UpButtonClic();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Down)
            {
                DownButtonClic();
                GenerateNumber();
            }

            ShowScore();
            cancelMoveButton.Enabled = true;

        }

        private void ReturnOneMoveBack()
        {
            lastMoveLabelsMapText = new string[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    lastMoveLabelsMapText[i, j] = labelsMap[i, j].Text;
                }
            }
            lastScore = score;
            lastCountEmptyLabels = countEmptyLabels;
        }

        private void DownButtonClic()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (var i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    mapLablesColorChange(i, j);
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        UserRestartChoice(true);
                                    }
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = SystemColors.Menu;
                                    countEmptyLabels++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (var i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                mapLablesColorChange(i, j);
                                labelsMap[k, j].Text = string.Empty;
                                labelsMap[k, j].BackColor = SystemColors.Menu;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void UpButtonClic()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    mapLablesColorChange(i, j);
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        UserRestartChoice(true);
                                    }
                                    labelsMap[k, j].Text = string.Empty;
                                    labelsMap[k, j].BackColor = SystemColors.Menu;
                                    countEmptyLabels++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (var i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                mapLablesColorChange(i, j);
                                labelsMap[k, j].Text = string.Empty;
                                labelsMap[k, j].BackColor = SystemColors.Menu;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void LeftButtonClic()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    mapLablesColorChange(i, j);
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        UserRestartChoice(true);
                                    }
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.Menu;
                                    countEmptyLabels++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (var j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                mapLablesColorChange(i, j);
                                labelsMap[i, k].Text = string.Empty;
                                labelsMap[i, k].BackColor = SystemColors.Menu;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void RightButtonClic()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (var j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    mapLablesColorChange(i, j);
                                    if (labelsMap[i, j].Text == "2048")
                                    {
                                        UserRestartChoice(true);
                                    }
                                    labelsMap[i, k].Text = string.Empty;
                                    labelsMap[i, k].BackColor = SystemColors.Menu;
                                    countEmptyLabels++;
                                }
                                break;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (var j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                mapLablesColorChange(i, j);
                                labelsMap[i, k].Text = string.Empty;
                                labelsMap[i, k].BackColor = SystemColors.Menu;
                                break;
                            }
                        }
                    }
                }
            }
            GenerateNumber();
        }

        private void UserRestartChoice(bool isAnyLable2048)
        {
            User.Score = score;
            userResult = new UsersResultsStorage();
            DialogResult result = MessageBox.Show($"Поздравляем {User.Name}, ваш результат {User.Score} очка(-ов)! \nХотите перезапустить игру?", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Close();
                var newGame = new MainForm(User, mapSize);
                newGame.Show();
            }
            else if (result == DialogResult.No && !isAnyLable2048)
            {
                userResult.SaveResultOfTesting(User);
                Close();
            }
            else if (result == DialogResult.No && isAnyLable2048)
            {
                result = MessageBox.Show("Желаете продолжить играть или выйти? \nДа - продолжить, нет - закончить и выйти", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    userResult.SaveResultOfTesting(User);
                    Close();
                }
                else
                {
                    endGameButton.Enabled = true;
                }
            }
        }
        private void mapLablesColorChange(int i, int j)
        {
            switch (labelsMap[i, j].Text)
            {
                case "":   
                    labelsMap[i, j].BackColor = SystemColors.Menu;
                    break;                 
                case "2":
                    labelsMap[i, j].BackColor = SystemColors.Menu;
                    break;
                case "4":
                    labelsMap[i, j].BackColor = SystemColors.ScrollBar;
                    break;
                case "8":
                    labelsMap[i, j].BackColor = Color.Khaki;
                    break;
                case "16":
                    labelsMap[i, j].BackColor = Color.Goldenrod;
                    break;
                case "32":
                    labelsMap[i, j].BackColor = Color.Orange;
                    break;
                case "64":
                    labelsMap[i, j].BackColor = Color.DarkOrange;
                    break;
                case "128":
                    labelsMap[i, j].BackColor = Color.Gold;
                    break;
                case "256":
                    labelsMap[i, j].BackColor = Color.Yellow;
                    break;
                case "512":
                    labelsMap[i, j].BackColor = Color.Coral;
                    break;
                case "1024":
                    labelsMap[i, j].BackColor = Color.OrangeRed;
                    break;
                case "2048":
                    labelsMap[i, j].BackColor = Color.Red;
                    break;
                default:
                    labelsMap[i, j].BackColor = SystemColors.ControlText;
                    labelsMap[i, j].ForeColor = SystemColors.HighlightText;
                    break;
            }
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Поздравляем {User.Name}, ваш результат {User.Score} очка(-ов)!", "Конец игры", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            userResult.SaveResultOfTesting(User);
            Close();
        }

        private void cancelMoveButton_Click(object sender, EventArgs e)
        {
            foreach(var label in labelsMap)
            {
                label.Text = String.Empty;
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    labelsMap[i, j].Text = lastMoveLabelsMapText[i,j];
                    mapLablesColorChange(i, j);
                }
            }
            countEmptyLabels = lastCountEmptyLabels;
            score = lastScore;
            ShowScore();
            cancelMoveButton.Enabled = false;
        }
    }
}