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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            this.LoginField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 50);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(195, 182, 222);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(70, 77, 156);
        }

        private void EnterButton_MouseEnter(object sender, EventArgs e)
        {
            EnterButton.BackColor = Color.FromArgb(124, 124, 204);
        }

        private void EnterButton_MouseLeave(object sender, EventArgs e)
        {
            EnterButton.BackColor = Color.FromArgb(80, 94, 177);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            GoToRegistrationButton.ForeColor = Color.FromArgb(124, 124, 204);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            GoToRegistrationButton.ForeColor = Color.FromArgb(52, 59, 130);
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            Controller.login(LoginField.Text, PassField.Text, this);
           
        }
    }
}
