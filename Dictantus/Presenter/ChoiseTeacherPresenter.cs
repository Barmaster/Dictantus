using DictantusCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class ChoiseTeacherPresenter
    {
        ChoiseTeacherForm _f;
        ChoiseTeacherModel _m;

        public void Init(ChoiseTeacherForm f, ChoiseTeacherModel m)
        {

            f.EditDictant += new Action<Dictant>(f_editThisDictant);
            f.DeleteDictant += new Action<Dictant>(f_deleteThisDictant);
            f.AddDictant += new Action(f_addNewDictant);
            _f = f;
            _m = m;
            _f.showHeadersDictants(_m.AvialableDictants);
        }

        private void f_addNewDictant()
        {
            _f.Hide();
            new TeacherDictantForm(null,_f).ShowDialog();
        }

        private void f_deleteThisDictant(Dictant dictant)
        {
            _m.deleteThisDictant(dictant);
            _f.showHeadersDictants(_m.AvialableDictants);
        }

        void f_editThisDictant(Dictant dictant)
        {
            _f.Hide();
            new TeacherDictantForm(dictant,_f).ShowDialog();
        }
    }
}
