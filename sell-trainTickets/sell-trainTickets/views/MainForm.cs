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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string LabelText1
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public string LabelText2
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
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

        private void findButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnAvailableRacesButton(FROMField.Text, TOField.Text, dateTimePicker.Value, this);
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

        private void addAdministratorButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnAddAdminOption(this);
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnDeleteAdminOption(this);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnRefreshButton();
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnFillButton();
        }
    }
}

