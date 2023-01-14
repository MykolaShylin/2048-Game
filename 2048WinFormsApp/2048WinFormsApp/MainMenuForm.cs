namespace _2048WinFormsApp
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {            
            var newGame = new UserNameForm();
            newGame.Show();
        }

        private void AndGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameRulesButton_Click(object sender, EventArgs e)
        {
            var rulesForm = new GameRulesForm();
            rulesForm.ShowDialog();
        }

        private void AllScoresTable_Click(object sender, EventArgs e)
        {
            var scoreTable = new UsersResultsTableForm();
            scoreTable.Show();
        }

        private void mapSizeButton_Click(object sender, EventArgs e)
        {
            var mapSizeForm = new NewMapSizeForm();
            mapSizeForm.Show();
        }
    }
}