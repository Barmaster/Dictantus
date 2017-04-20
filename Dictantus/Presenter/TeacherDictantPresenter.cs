using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class TeacherDictantPresenter
    {
        TeacherDictantForm _f;
        TeacherDictantModel _m;

        public void Init(TeacherDictantForm f, TeacherDictantModel m)
        {
            f.SaveDictant += new Action<List<int>, List<string>, string, string>(f_saveDictant);
            f.BackToTeachChoise += new Action(f_backToCHoiseTeacher);
            _f = f;
            _m = m;
            fillTheField();
        }

        private void f_saveDictant(List<int> positions, List<string> answers, string text, string header)
        {
            _m.saveDictant(text, header, positions, answers);
        }

        private void f_backToCHoiseTeacher()
        {
            _f.Hide();
            _f.unbindingFromClosing();
            new ChoiseTeacherForm(_f).ShowDialog();
        }
        private void fillTheField()
        {
            if (_m.CurrentDictant != null)
            {
                _f.fillTheField(_m.Positions, _m.Answers, _m.CurrentDictant.Text, _m.CurrentDictant.Header);
            }
        }
    }
}
