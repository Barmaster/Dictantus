using DictantusCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictantusData
{
    public class DAO
    {
        private static SQLiteConnection _connection;

        protected static SQLiteConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    // var connectionString = "data source=group6303.db; New=true; UseUTF16Encoding=True";
                    const string databaseName = @"..\..\..\DB_DICTATION.db";
                    _connection =
                        new SQLiteConnection(string.Format("Data Source={0};", databaseName));
                    //_connection = new SQLiteConnection("data source=" + @"C:\Users\Ilusa\Documents\Visual Studio 2015\Projects\Dictantus\DB_DICTATION.db");
                }
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
                return _connection;
            }
        }

        public List<List<object>> ExecuteQuery(string query)
        {
            var res = new List<List<object>>();
            var command = Connection.CreateCommand();
            command.CommandText = query;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var list = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                { list.Add(reader[i]); }
                res.Add(list);
            }
            return res;
        }

        public void SetQuery(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, Connection);
            command.ExecuteNonQuery();
        }
        public List<Dictant> getAllDictants()
        {
            var list = ExecuteQuery("select * from Dictant");
            List<Dictant> allDictants = new List<Dictant>();
            for (int i = 0; i < list.Count; i++)
            {
                var dictant = new Dictant();
                dictant.ID = Convert.ToInt32(list[i][0]);
                dictant.Text = list[i][1].ToString();
                dictant.Header = list[i][2].ToString();
                dictant.StudentText = list[i][3].ToString();
                allDictants.Add(dictant);
            }
            return allDictants;
        }
        public int GetMaxId(string table)
        {
            int id = 0;
            var maxId = ExecuteQuery("select max(id_dictant) from " + table);
            if (maxId.Count > 0 && maxId[0][0].ToString().Length > 0)
                id = int.Parse(maxId[0][0].ToString());
            return id;
        }
    }
}
