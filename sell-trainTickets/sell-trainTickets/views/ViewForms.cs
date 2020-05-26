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


        public void toAvailableRacesForm(Form form, bool isAdmin, bool isSuperAdmin, ArrayList availableRaces)
        {
            form.Hide();
            AvailableRacesForm availableRacesForm = new AvailableRacesForm();
            if (!isAdmin && !isSuperAdmin)
            {
                //hideOptionsForUser(availableRacesForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(availableRacesForm);
            }
            foreach (var availableRace in availableRaces)
            {
                //
            }
            availableRacesForm.StartPosition = FormStartPosition.CenterScreen;
            availableRacesForm.ShowDialog();
            form.Close();
        }

        //public PayForm PayForm { get; private set; }
        public void toPayForm(Form form, bool isAdmin, bool isSuperAdmin, Ticket ticket)
        {
            form.Hide();
            PayForm payForm = new PayForm();
            //AvailableRacesForm = new AvailableRacesForm();
            if (!isAdmin && !isSuperAdmin)
            {
                //hideOptionsForUser(payForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(payForm);
            }
            //вивести квиток
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
                //hideOptionsForUser(infoForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(infoForm);
            }
            infoForm.surnameTextBox.Text = user.FullName.Split(' ')[0];
            infoForm.nameTextBox.Text = user.FullName.Split(' ')[1];
            infoForm.emailTextBox.Text = user.Email;
            //вивсти інфрмацію про користувача та його квитки
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
                //hideOptionsForUser (addRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(addRaceForm);
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
                //hideOptionsForUser(deleteRaceForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(deleteRaceForm);
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
                //hideOptionsForUser(addAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(addAdminForm);
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
                //hideOptionsForUser(deleteAdminForm);
            }
            else if (isAdmin && !isSuperAdmin)
            {
                //hideOptionsForAdmin(deleteAdminForm);
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