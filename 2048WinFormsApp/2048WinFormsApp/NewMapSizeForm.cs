using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048GameClassLibrary;

namespace _2048WinFormsApp
{
    public partial class NewMapSizeForm : Form
    {
        public NewMapSizeForm()
        {
            InitializeComponent();
        }

        private void mapSizeTextBox_Validating(object sender, CancelEventArgs e)
        {
            string size = mapSizeTextBox.Text;
            if (string.IsNullOrEmpty(size) || size.Any(x => !char.IsDigit(x)) || int.Parse(size) < 4)
            {
                e.Cancel = true;
                mapSizeTextBox.Focus();
                errorProvider.SetError(mapSizeTextBox, "Значение должно быть числовым и не меньше 4!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(mapSizeTextBox, null);
            }
        }
        private void aceptChangesButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                int size = int.Parse(mapSizeTextBox.Text);
                Close();
                var userNameForm = new UserNameForm(size);
                userNameForm.Show();
            }
        }
    }
}
