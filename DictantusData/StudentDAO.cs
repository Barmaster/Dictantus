using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusData
{
    public class StudentDAO : DAO
    {
        //public void Save()
        //{

        //    ExecuteQuery("CREATE TABLE example (id INTEGER PRIMARY KEY, value TEXT);");

        //}

        public string getDictantByID(int id_dictant)
        {

            return ExecuteQuery("select text from Dictants where id_dictant=" + id_dictant)[0][0].ToString();

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
        public double getStatistic(int id_user)
        {
            return (double)ExecuteQuery("select statistics from User where id_user=" + id_user)[0][0];
        }
        public void editStatistic(int id_user, string statistics)
        {
            SetQuery("update User set statistics=" + statistics + " where id_user=" + id_user);
        }
        /*private string GetByQuery(string query)
        {
            var list = ExecuteQuery(query);
            foreach (var r in list)
            {
                return r[0].ToString();
            }
            return null;
        }*/
    }
}
