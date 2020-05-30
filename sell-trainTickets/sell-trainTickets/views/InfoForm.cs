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
    public partial class InfoForm : Form
    {
        private int x = 0; private int y = 0;
        DataSet dataSet;
        DataTable usersTicketsTable;
        public InfoForm()
        {
            InitializeComponent();
            createUsersTicketsTable();
        }

        private void createUsersTicketsTable()
        {
            dataSet = new DataSet();
            usersTicketsTable = new DataTable();
            dataSet.Tables.Add(usersTicketsTable);

            usersTicketsTable.Columns.Add(new DataColumn("ID"));
            usersTicketsTable.Columns.Add(new DataColumn("ID рейсу"));
            usersTicketsTable.Columns.Add(new DataColumn("Станція відправлення"));
            usersTicketsTable.Columns.Add(new DataColumn("Станція прибуття"));
            usersTicketsTable.Columns.Add(new DataColumn("Час відправлення"));
            usersTicketsTable.Columns.Add(new DataColumn("Час прибуття"));
            usersTicketsTable.Columns.Add(new DataColumn("Дата"));
            this.userTicketsGrid.DataSource = usersTicketsTable;
        }

        private void searchRaceButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnSearchRacesButton(this);
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

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        public void fillUsersTicketsTable(int id, int raceId, string departureStation, string arrivalStation, DateTime departureTime,
            DateTime arrivalTime, DateTime date)
        {
            this.usersTicketsTable.Rows.Add(id, raceId, departureStation, arrivalStation, departureTime.ToString("t"),
                arrivalTime.ToString("t"), date.ToString("d"));
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if(userTicketsGrid.Rows.Count > 0)
            {
                Controller.clickOnReturnTicket(Int32.Parse(userTicketsGrid.CurrentRow.Cells[0].Value.ToString()), this);
            }    
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnExitButton(this);
        }

        private void InfoForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void InfoForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }
    }
}
