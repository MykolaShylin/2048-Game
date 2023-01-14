using System;
using System.Collections.Generic;
using System.ComponentModel;
using _2048GameClassLibrary;

namespace _2048WinFormsApp
{
    public partial class UserNameForm : Form
    {
        public User User;
        private int MapSize;
        public UserNameForm()
        {
            InitializeComponent();
        }
        public UserNameForm(int size)
        {
            InitializeComponent();
            MapSize = size;
        }

        private void userNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string name = userNameTextBox.Text;
            if (string.IsNullOrEmpty(name) || name.Any(x => !char.IsLetter(x)))
            {
                e.Cancel = true;
                userNameTextBox.Focus();
                errorProvider.SetError(userNameTextBox, "Имя должно содержать только буквы!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(userNameTextBox, null);
            }
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string name = userNameTextBox.Text;
                User = new User(name);
                if (MapSize > 4)
                {
                    Close();
                    var gameForm = new MainForm(User, MapSize);
                    gameForm.Show();
                }
                else
                {                    
                    Close();
                    var gameForm = new MainForm(User);
                    gameForm.Show();
                }
            }
            
        }
    }
}
