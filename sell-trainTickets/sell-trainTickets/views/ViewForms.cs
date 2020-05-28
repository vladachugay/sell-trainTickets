using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sellTrainTickets.Models;


namespace sellTrainTickets.Views
{
    class ViewForms
    {
        public void show()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }

        public void toMainForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            MainForm mainForm = new MainForm();
            if(!isAdmin && !isSuperAdmin)
            {
                mainForm.addRaceButton.Visible = false;
                mainForm.deleteRaceButton.Visible = false;
                mainForm.addAdministratorButton.Visible = false;
                mainForm.deleteAdminButton.Visible = false;
            }
            else if(isAdmin && !isSuperAdmin)
            {
                mainForm.addAdministratorButton.Visible = false;
                mainForm.deleteAdminButton.Visible = false;
            }
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
            form.Close();
        }

        public void fromRegistrationToMainForm(Form RegistrationForm)
        {
            RegistrationForm.Hide();
            MainForm mainForm = new MainForm();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.ShowDialog();
            RegistrationForm.Close();
        }


        public void toAvailableRacesForm(MainForm mainForm, bool isAdmin, bool isSuperAdmin, List<Race> availableRaces,
            int[] departureStationIndexes, int[] arrivalStationIndexes, DateTime date)
        {
            mainForm.Hide();
            AvailableRacesForm availableRacesForm = new AvailableRacesForm();
            if (!isAdmin && !isSuperAdmin)
            {
                availableRacesForm.addRaceButton.Visible = false;
                availableRacesForm.deleteRaceButton.Visible = false;
                availableRacesForm.addAdministratorButton.Visible = false;
                availableRacesForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                availableRacesForm.addAdministratorButton.Visible = false;
                availableRacesForm.deleteAdminButton.Visible = false; ;
            }
            availableRacesForm.createAvailableRacesTable(availableRaces[0].Stations[departureStationIndexes[0]],
                availableRaces[0].Stations[arrivalStationIndexes[0]]);
            for (int i = 0; i < availableRaces.Count; i++)
            {
                availableRacesForm.fillAvailableRacesTable(availableRaces[i].Id, availableRaces[i].Name,
                    availableRaces[i].DepartureTime[departureStationIndexes[i]].ToString("t"), availableRaces[i].ArrivalTime[arrivalStationIndexes[i]].ToString("t"), 
                    date.ToString("d"));
            }
            availableRacesForm.StartPosition = FormStartPosition.CenterScreen;
            availableRacesForm.ShowDialog();
            mainForm.Close();
        }

        public void toPayForm(Form form, bool isAdmin, bool isSuperAdmin, Ticket ticket)
        {
            form.Hide();
            PayForm payForm = new PayForm();
            if (!isAdmin && !isSuperAdmin)
            {
                payForm.addRaceButton.Visible = false;
                payForm.deleteRaceButton.Visible = false;
                payForm.addAdministratorButton.Visible = false;
                payForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                payForm.addAdministratorButton.Visible = false;
                payForm.deleteAdminButton.Visible = false;
            }
            payForm.raceIDTextBox.Text = ticket.RaceId.ToString();
            payForm.departureStationTextBox.Text = ticket.DepartureCity;
            payForm.departureTimeTextBox.Text = ticket.DepartureTime.ToString("t");
            payForm.arrivalStationTextBox.Text = ticket.ArrivalCity;
            payForm.arrivalTimeTextBox.Text = ticket.ArrivalTime.ToString("t");
            payForm.priceTextBox.Text = ticket.Price.ToString();
            payForm.fullNameTextBox.Text = ticket.FullName;
            payForm.dateTextBox.Text = ticket.Date.ToString("d");
            payForm.StartPosition = FormStartPosition.CenterScreen;
            payForm.ShowDialog();
            form.Close();
        }

        public void toInfoForm(Form form, bool isAdmin, bool isSuperAdmin, List<Ticket> tickets, User user)
        {
            form.Hide();
            InfoForm infoForm = new InfoForm();
            if (!isAdmin && !isSuperAdmin)
            {
                infoForm.addRaceButton.Visible = false;
                infoForm.deleteRaceButton.Visible = false;
                infoForm.addAdministratorButton.Visible = false;
                infoForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                infoForm.addAdministratorButton.Visible = false;
                infoForm.deleteAdminButton.Visible = false;
            }
            infoForm.surnameTextBox.Text = user.FullName.Split(' ')[0];
            infoForm.nameTextBox.Text = user.FullName.Split(' ')[1];
            infoForm.emailTextBox.Text = user.Email;
            foreach (var ticket in tickets)
            {
                infoForm.fillUsersTicketsTable(ticket.Id, ticket.RaceId, ticket.DepartureCity, ticket.ArrivalCity,
                    ticket.DepartureTime, ticket.ArrivalTime, ticket.Date);
            }
            infoForm.StartPosition = FormStartPosition.CenterScreen;
            infoForm.ShowDialog();
            form.Close();
        }

        public void toAddRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddRaceForm addRaceForm = new AddRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                addRaceForm.addRaceButton.Visible = false;
                addRaceForm.deleteRaceButton.Visible = false;
                addRaceForm.addAdministratorButton.Visible = false;
                addRaceForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                addRaceForm.addAdministratorButton.Visible = false;
                addRaceForm.deleteAdminButton.Visible = false;
            }
            addRaceForm.StartPosition = FormStartPosition.CenterScreen;
            addRaceForm.ShowDialog();
            form.Close();
        }

        public void toDeleteRaceForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteRaceForm deleteRaceForm = new DeleteRaceForm();
            if (!isAdmin && !isSuperAdmin)
            {
                deleteRaceForm.addRaceButton.Visible = false;
                deleteRaceForm.deleteRaceButton.Visible = false;
                deleteRaceForm.addAdministratorButton.Visible = false;
                deleteRaceForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                deleteRaceForm.addAdministratorButton.Visible = false;
                deleteRaceForm.deleteAdminButton.Visible = false;
            }
            deleteRaceForm.StartPosition = FormStartPosition.CenterScreen;
            deleteRaceForm.ShowDialog();
            form.Close();
        }

        public void toAddAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            AddAdminForm addAdminForm = new AddAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                addAdminForm.addRaceButton.Visible = false;
                addAdminForm.deleteRaceButton.Visible = false;
                addAdminForm.addAdministratorButton.Visible = false;
                addAdminForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                addAdminForm.addAdministratorButton.Visible = false;
                addAdminForm.deleteAdminButton.Visible = false;
            }
            addAdminForm.StartPosition = FormStartPosition.CenterScreen;
            addAdminForm.ShowDialog();
            form.Close();
        }

        public void toDeleteAdminForm(Form form, bool isAdmin, bool isSuperAdmin)
        {
            form.Hide();
            DeleteAdminForm deleteAdminForm = new DeleteAdminForm();
            if (!isAdmin && !isSuperAdmin)
            {
                deleteAdminForm.addRaceButton.Visible = false;
                deleteAdminForm.deleteRaceButton.Visible = false;
                deleteAdminForm.addAdministratorButton.Visible = false;
                deleteAdminForm.deleteAdminButton.Visible = false;
            }
            else if (isAdmin && !isSuperAdmin)
            {
                deleteAdminForm.addAdministratorButton.Visible = false;
                deleteAdminForm.deleteAdminButton.Visible = false;
            }
            deleteAdminForm.StartPosition = FormStartPosition.CenterScreen;
            deleteAdminForm.ShowDialog();
            form.Close();
        }

        public void deleteTicket(Form InfoForm)
        {

        }

        public void getAuthorizationError(AuthorizationForm authorizationForm)
        {
            authorizationForm.errorLabel.Visible = true;
        }
    }
}