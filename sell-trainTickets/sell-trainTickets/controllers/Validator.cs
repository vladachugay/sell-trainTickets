using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sellTrainTickets.Models;

namespace sellTrainTickets.Controllers
{
    class Validator
    {
        public Validator()
        {
        }

        public bool checkAuthorization(List<User> users)
        {
            if (users.Count() == 0) return false;
            return true;
        }
    
    }
}
