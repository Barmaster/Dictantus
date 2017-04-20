using DictantusCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusData
{
    public class TeacherDAO : DAO
    {
        public Dictant getDictantByID(int id_dictant)
        {
            Dictant dictant = null;
            var list = ExecuteQuery("select * from Dictant where id_dictant=" + id_dictant);
            if (list.Count > 0)
            {
                dictant = new Dictant();
                dictant.ID = Convert.ToInt32(list[0][0]);
                dictant.Text = list[0][1].ToString();
                dictant.Header = list[0][2].ToString();
            }
            return dictant;
        }
        public void getPositionAndAnswer(int id_dictant, out List<int> position, out List<string> answer)
        {
            position = new List<int>();
            answer = new List<string>();
            List<List<object>> posAndAns = ExecuteQuery("select position,answer from Error where id_dictant=" + id_dictant);
            for (int i = 0; i < posAndAns.Count; i++)
            {
                position.Add(Convert.ToInt32(posAndAns[i][0]));
                answer.Add(posAndAns[i][1].ToString());

            }


        }
        public void addNewDictant(string text, string header, List<int> position, List<string> answer,StringBuilder studentText)
        {
            SetQuery("insert into Dictant (text,header,student_text) values ('" + text + "','" + header + "','"+ studentText + "')");
            int id_dictant = Convert.ToInt32(ExecuteQuery("select max(id_dictant) from Dictant")[0][0]);
            for (int i = 0; i < position.Count; i++)
            {
                SetQuery("insert into Error (position,answer,id_dictant) values (" + position[i] + ",'" + answer[i] + "','" + id_dictant + "')");
            }
        }
        public void deleteDictant(int id_dictant)
        {
            SetQuery("delete from Dictant where id_dictant=" + id_dictant);
        }
        public void editDictant(int id_dictant, string text, string header, List<int> position, List<string> answer, StringBuilder studentText)
        {
            SetQuery("delete from Error where id_dictant=" + id_dictant);
            SetQuery("update Dictant set  text='" + text + "',header='" + header + "',student_text='" + studentText + "'where id_dictant=" + id_dictant);
            for (int i = 0; i < position.Count; i++)
            {
                SetQuery("insert into Error (position,answer,id_dictant) values (" + position[i] + ",'" + answer[i] + "'," + id_dictant + ")");
            }
        }
    }
}
