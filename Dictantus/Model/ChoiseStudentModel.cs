using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DictantusCore;
using DictantusData;

namespace Dictantus
{
    public class ChoiseStudentModel
    {
        private StudentDAO currentStudentDAO;
        private List<Dictant> avialableDictants;
        public User CurrentUser { get; set; }
        public List<Dictant> AvialableDictants

        {
            get
            {
                return avialableDictants;
            }
        }
        public ChoiseStudentModel(User curentUser)
        {
            currentStudentDAO = new StudentDAO();
            CurrentUser = curentUser;
            setAvialableDictant();
        }
        

        private void setAvialableDictant()
        {
            avialableDictants = currentStudentDAO.getAllDictants();
        }

    }
}
