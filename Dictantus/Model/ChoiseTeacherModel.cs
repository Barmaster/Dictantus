using DictantusCore;
using DictantusData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class ChoiseTeacherModel
    {
        public TeacherDAO currentTeacherDAO;
        private List<Dictant> avialableDictants;
        public List<Dictant> AvialableDictants
        {
            get
            {
                return avialableDictants;
            }
        }
        public ChoiseTeacherModel()
        {
            currentTeacherDAO = new TeacherDAO();
            setAvialableDictant();
        }
        private void setAvialableDictant()
        {
            avialableDictants = currentTeacherDAO.getAllDictants();
        }
        public void deleteThisDictant(Dictant dictant)
        {
            currentTeacherDAO.deleteDictant(dictant.ID);
            avialableDictants = currentTeacherDAO.getAllDictants();
        }
    }
}
