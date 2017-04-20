using DictantusCore;
using DictantusData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictantus
{
    public class TeacherDictantModel
    {
        private Dictant currentDictant;
        private List<int> positions = new List<int>();
        private List<string> answers = new List<String>();
        private TeacherDAO currentTeacher;

        public TeacherDictantModel(Dictant dictant)
        {
            currentTeacher = new TeacherDAO();
            currentDictant = dictant;
            if (currentDictant != null)
            {
                currentTeacher.getPositionAndAnswer(currentDictant.ID, out positions, out answers);
            }

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
        public void saveDictant(string text, string header, List<int> positions, List<string> answers)
        {
            StringBuilder stdText = new StringBuilder(text);
            for (int i = 0; i < positions.Count; i++)
            {
                stdText.Remove(positions[i], answers[i].Length);
                stdText.Insert(positions[i], new string('一', answers[i].Length));
            }
            if (currentDictant != null)
            {
                currentTeacher.editDictant(CurrentDictant.ID, text, header, positions, answers,stdText);
            }
            else
            {
                currentTeacher.addNewDictant(text, header, positions, answers,stdText);
                currentDictant = currentTeacher.getDictantByID(currentTeacher.GetMaxId("Dictant"));
            }
        }
    }
}
