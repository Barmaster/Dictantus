using DictantusCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class ChoiseStudentPresenter
    {
        ChoiseStudentForm _f;
        ChoiseStudentModel _m;

        public void Init(ChoiseStudentForm f, ChoiseStudentModel m)
        {

            f.choiseTheDictant += new Action<Dictant>(f_choiseThisDictant);
            _f = f;
            _m = m;
            _f.showHeadersDictants(_m.AvialableDictants);
        }

        void f_choiseThisDictant(Dictant dictant)
        {
            _f.Hide();
            new DictantStudentForm(dictant, _m.CurrentUser,_f).ShowDialog();
        }
    }
}
