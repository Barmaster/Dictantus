using DictantusCore;
using DictantusData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class AuthorizationModel
    {
        private UserDAO currentUserDAO;
        private User currentUser;
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
            }
        }
        public void setCurrentUser(string login, string password)
        {
            currentUserDAO = new UserDAO();
            CurrentUser = currentUserDAO.signIn(login, password);
        }
    }
}
