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
    public partial class AddRaceForm : Form
    {
        public AddRaceForm()
        {
            InitializeComponent();
            createTable();
        }

        private void createTable()
        {
            DataSet dataSet = new DataSet();
            DataTable raceTable = new DataTable();
            dataSet.Tables.Add(raceTable);

            DataColumn station = new DataColumn("Зупинка");
            DataColumn arrivalTime = new DataColumn("Час прибуття");
            DataColumn departureTime = new DataColumn("Час відправлення");
            raceTable.Columns.Add(station);
            raceTable.Columns.Add(arrivalTime);
            raceTable.Columns.Add(departureTime);
            this.addRaceDataGrid.DataSource = raceTable;
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

        private void addRButton_Click(object sender, EventArgs e)
        {
            int id;
            if(!Int32.TryParse(IDTextBox.Text, out id))
            {
                //MessageBox.Show()
            }

            string stations = "";
            string arrivalTime = "";
            string departureTime = "";
            Console.WriteLine(addRaceDataGrid.Rows.Count);
            for (int i = 0; i < addRaceDataGrid.Rows.Count-1; i++)
            {
                if (i != addRaceDataGrid.Rows.Count - 2)
                {
                    stations += $"{addRaceDataGrid.Rows[i].Cells["Зупинка"].Value.ToString()};";
                    arrivalTime += $"{addRaceDataGrid.Rows[i].Cells["Час прибуття"].Value.ToString()};";
                    departureTime += $"{addRaceDataGrid.Rows[i].Cells["Час відправлення"].Value.ToString()};";
                }
                else
                {
                    stations += addRaceDataGrid.Rows[i].Cells["Зупинка"].Value.ToString();
                    arrivalTime += addRaceDataGrid.Rows[i].Cells["Час прибуття"].Value.ToString();
                    departureTime += addRaceDataGrid.Rows[i].Cells["Час відправлення"].Value.ToString();
                }   
            }
            Console.WriteLine(stations);
            Console.WriteLine(arrivalTime);
            Console.WriteLine(departureTime);
            string name = addRaceDataGrid.Rows[0].Cells["Зупинка"].Value.ToString() + " - " +
                addRaceDataGrid.Rows[addRaceDataGrid.Rows.Count - 2].Cells["Зупинка"].Value.ToString();
            Controller.clickOnAddRaceButton(this, id, name, stations, arrivalTime, departureTime, 
                Int32.Parse(seatsTextBox.Text), Int32.Parse(priceTextBox.Text));
        }

        private void searchRaceButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnSearchRacesButton(this);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            Controller.clickOnInfoButton(this);
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
    }
}
