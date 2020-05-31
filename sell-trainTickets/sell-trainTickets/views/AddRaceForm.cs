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
        //Координаты мышки
        private int x = 0;
        private int y = 0;
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
            DataColumn arrivalTime = new DataColumn("Час прибуття (hh:mm)");
            DataColumn departureTime = new DataColumn("Час відправлення (hh:mm)");
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
            int num_of_seats;
            int price;
            if(!Int32.TryParse(this.seatsTextBox.Text, out num_of_seats) || num_of_seats < 10)  
            {
                MessageBox.Show("Кількість місць повинна бути натуральним числом і більшою за 10. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(!Int32.TryParse(this.priceTextBox.Text, out price) || price < 1)
            {
                MessageBox.Show("Ціна повинна бути натуральним числом і більшою за 0. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string stations = "";
            string arrivalTime = "";
            string departureTime = "";
            if(addRaceDataGrid.Rows.Count == 1)
            {
                MessageBox.Show("Таблиця повинна бути повністю заповненою. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < addRaceDataGrid.Rows.Count-1; i++)
            {
                if (addRaceDataGrid.Rows[i].Cells["Зупинка"].Value.ToString() == "" || addRaceDataGrid.Rows[i].Cells["Час прибуття (hh:mm)"].Value.ToString() == "" 
                    || addRaceDataGrid.Rows[i].Cells["Час відправлення (hh:mm)"].Value.ToString() == "")
                {
                    MessageBox.Show("Таблиця повинна бути повністю заповненою. Перевірте введені дані.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (i != addRaceDataGrid.Rows.Count - 2)
                    {
                        stations += $"{addRaceDataGrid.Rows[i].Cells["Зупинка"].Value.ToString()};";
                        arrivalTime += $"{addRaceDataGrid.Rows[i].Cells["Час прибуття (hh:mm)"].Value.ToString()};";
                        departureTime += $"{addRaceDataGrid.Rows[i].Cells["Час відправлення (hh:mm)"].Value.ToString()};";
                    }
                    else
                    {
                        stations += addRaceDataGrid.Rows[i].Cells["Зупинка"].Value.ToString();
                        arrivalTime += addRaceDataGrid.Rows[i].Cells["Час прибуття (hh:mm)"].Value.ToString();
                        departureTime += addRaceDataGrid.Rows[i].Cells["Час відправлення (hh:mm)"].Value.ToString();
                    }
                }       
            }
            string name = addRaceDataGrid.Rows[0].Cells["Зупинка"].Value.ToString() + " - " +
                addRaceDataGrid.Rows[addRaceDataGrid.Rows.Count - 2].Cells["Зупинка"].Value.ToString();
            Controller.clickOnAddRaceButton(this, Int32.Parse(IDTextBox.Text), name, stations, arrivalTime, departureTime, 
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

        private void AddRaceForm_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void AddRaceForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }
    }
}
