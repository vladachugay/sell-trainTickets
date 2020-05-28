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
    public partial class AvailableRacesForm : Form
    {
        DataSet dataSet;
        DataTable availableRacesTable;
        public AvailableRacesForm()
        {
            InitializeComponent();
        }

        public void createAvailableRacesTable(string departureStation, string arrivalStation)
        {
            dataSet = new DataSet();
            availableRacesTable = new DataTable();
            dataSet.Tables.Add(availableRacesTable);

            availableRacesTable.Columns.Add(new DataColumn("ID"));
            availableRacesTable.Columns.Add(new DataColumn("Назва"));
            availableRacesTable.Columns.Add(new DataColumn($"Час відправлення із станції {departureStation}"));
            availableRacesTable.Columns.Add(new DataColumn($"Час прибуття на станцію {arrivalStation}")) ; 
            availableRacesTable.Columns.Add(new DataColumn("Дата"));
            this.availableRacesGrid.DataSource = availableRacesTable;
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

        private void addAdministratorButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnAddAdminOption(this);
        }

        private void deleteAdminButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnDeleteAdminOption(this);
        }

        private void AvailableRacesForm_Load(object sender, EventArgs e)
        {

        }
        public void fillAvailableRacesTable(int id, string name, string departureTime, string arrivalTime, string date)
        {
            availableRacesTable.Rows.Add(id, name, departureTime, arrivalTime, date);    
        }

        private void availableRacesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] columnNames = availableRacesTable.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();

            Controller.clickOnRace(Int32.Parse(availableRacesGrid.CurrentRow.Cells[0].Value.ToString()), 
                Convert.ToDateTime(availableRacesGrid.CurrentRow.Cells[4].Value.ToString()),
               columnNames[2].Split(' ')[4], columnNames[3].Split(' ')[4], this);
        }
    }
}
