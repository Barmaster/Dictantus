using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictantus
{
    public class DictantStudentPresenter
    {
        DictantStudentForm _f;
        DictantStudentModel _m;

        public void Init(DictantStudentForm f, DictantStudentModel m)
        {
            f.CheckDictant += new Action<List<string>>(f_checkDictant);
            f.BackToStChoise += new Action(f_backToCHoiseStudent);
            f.RestartThisDictant += new Action(f_restartThisDictant);
            _f = f;
            _m = m;
            fillTheField();
        }

        private void f_restartThisDictant()
        {
            _m.CorrectPosAfterCheck.Clear();
            _f.restartField();
        }

        private void f_checkDictant(List<string> studentAnswers)
        {
            _m.checkDictant(studentAnswers);
            _f.resultOfCheck(_m.CorrectPosAfterCheck, _m.CurrentUser.Statistic,_m.Answers);
        }

        private void f_backToCHoiseStudent()
        {
            _f.Hide();
            _f.unbidingFromClosing();
            new ChoiseStudentForm(_m.CurrentUser,_f).ShowDialog();
        }
        private void fillTheField()
        {
            _f.setTextAndStatistic(_m.CurrentDictant.StudentText,_m.CurrentDictant.Header, _m.Positions, _m.Answers, _m.CurrentUser.Statistic);
        }
    }
}
