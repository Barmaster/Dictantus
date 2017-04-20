using DictantusCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dictantus
{
    public class AuthorizationPresenter
    {
         private AuthorizationForm _f;
         private AuthorizationModel _m;

        public void Init(AuthorizationForm f, AuthorizationModel m)
        {
            f.trySignIn += new Action<string, string>(f_trySignIn);
            _f = f;
            _m = m;
        }

        void f_trySignIn(string login, string password)
        {
            _m.setCurrentUser(login, password);
            if (_m.CurrentUser == null) { wrongLoginOrPassword(); return; }
            switch (_m.CurrentUser.Role)
            {
                case UserRole.Teacher:
                    {
                        SignInLikeATeacher();
                        break;
                    }
                case UserRole.Student:
                    {
                        SignInLikeAStudent();
                        break;
                    }
            }
        }

        private void SignInLikeAStudent()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;

            _f.Hide();
            new ChoiseStudentForm(_m.CurrentUser).ShowDialog();
            _f.Close();

        }

        private void SignInLikeATeacher()
        {
            _f.Hide();
            new ChoiseTeacherForm().ShowDialog();
            _f.Close();
        }

        private void wrongLoginOrPassword()
        {
            _f.wrongLoginOrPassword();
        }

    }
}
