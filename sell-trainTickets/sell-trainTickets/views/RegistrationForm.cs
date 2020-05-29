using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Controllers;

namespace sellTrainTickets.Views
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string fullname = surnameField.Text + " " + nameField.Text;
            Controller.registrate(fullname, emailField.Text, PassField.Text, this);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Controller.closeApplication();
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(195, 182, 222);
        }

        private void CloseButton_MouseMove(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(70, 77, 156);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        public void showRegistrationError()
        {
            this.registrationErrorLabel.Visible = true;
        }

        private void welcomeToAuthjrizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.StartPosition = FormStartPosition.CenterScreen;
            authorizationForm.ShowDialog();
            this.Close();
        }

        private void welcomeToAuthorizationLabel_MouseEnter(object sender, EventArgs e)
        {
            this.welcomeToAuthorizationLabel.ForeColor = Color.FromArgb(70, 77, 156);
        }

        private void welcomeToAuthorizationLabel_MouseLeave(object sender, EventArgs e)
        {
            this.welcomeToAuthorizationLabel.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
        }
    }
}
