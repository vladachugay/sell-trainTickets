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
    public partial class AddAdminForm : Form
    {
        //Координаты мышки
        private int x = 0;
        private int y = 0;
        public AddAdminForm()
        {
            InitializeComponent();
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

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.FromArgb(70, 77, 156);
        }

        private void searchRaceButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnSearchRacesButton(this);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnInfoButton(this);
        }

        private void addRaceButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnAddRaceOption(this);
        }

        private void deleteRaceButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnDeleteRaceOption(this);
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnDeleteAdminOption(this);
        }

        private void addAButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnAddAdminButton(emailField.Text);
        }

        private void AddAdminForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void AddAdminForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }
    }
}
