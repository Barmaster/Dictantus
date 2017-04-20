using DictantusCore;
using DictantusData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class DictantStudentModel
    {
        private Dictant currentDictant;
        private List<int> positions = new List<int>();
        private List<string> answers = new List<String>();
        private List<int> correctPosAfterCheck = new List<int>();
        private StudentDAO currentStudent;
        public User CurrentUser { get; set; }
        public DictantStudentModel(Dictant dictant, User user)
        {
            currentStudent = new StudentDAO();
            currentDictant = dictant;
            CurrentUser = user;
            currentStudent.getPositionAndAnswer(currentDictant.ID, out positions, out answers);

        }

        public Dictant CurrentDictant
        {
            get
            {
                return currentDictant;
            }
        }
        public List<int> Positions
        {
            get
            {
                return positions;
            }
        }
        public List<string> Answers
        {
            get
            {
                return answers;
            }
           
        }
        public List<int> CorrectPosAfterCheck
        {
            get
            {
                return correctPosAfterCheck;
            }
            set
            {
                correctPosAfterCheck = value;
            }
        }
        public void checkDictant(List<string> studentAnswers)
        {
            for (int i = 0; i < positions.Count; i++)
            {
                if (studentAnswers[i].Equals(answers[i]))
                {
                    correctPosAfterCheck.Add(positions[i]);
                }
            }

            if (CurrentUser.Statistic!=0) CurrentUser.Statistic = Math.Round(((CurrentUser.Statistic + correctPosAfterCheck.Count * 100 / positions.Count) / 2),1);
            else CurrentUser.Statistic = Math.Round(((CurrentUser.Statistic + correctPosAfterCheck.Count * 100 / positions.Count)), 1);
            string s = CurrentUser.Statistic.ToString().Replace(',', '.');
            currentStudent.editStatistic(CurrentUser.ID,s);
        }

    }
}
