using DictantusCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusData
{
    public class UserDAO : DAO
    {
        public void addUser(User user)
        {
            SetQuery("insert into User (login,password,role) values ('" + user.Login + "','" + user.Password + "','" + user.Role + "')");

        }
        public void deleteUser(User user)
        {
            SetQuery("delete from User where login='" + user.Login + "'");
        }
        public User signIn(string login, string password)
        {
            User user;
            var role = ExecuteQuery("select id_user,role,statistics from User where login='" + login + "'and password='" + password + "'");
            if (role.Count == 0)
                return null;
            user = new User();
            user.ID = Convert.ToInt32(role[0][0]);
            user.Login = login;
            user.Password = password;
            if (role[0][1].ToString().Equals("Student"))
            {
                user.Role = UserRole.Student;
                user.Statistic = Convert.ToDouble(role[0][2]);
            }
            else user.Role = UserRole.Teacher;
            return user;
        }

    }
}
