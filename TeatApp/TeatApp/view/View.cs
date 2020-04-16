using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TeatApp.Views
{
    class ViewForms
    {
        public void show()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }

        public Form2 Form2 { get; private set; }
        public void createForm2(Form form1)
        {
            form1.Hide();
            Form2 = new Form2();
            Form2.StartPosition = FormStartPosition.CenterScreen;
            Form2.ShowDialog();
           
            
        }
    }
}
