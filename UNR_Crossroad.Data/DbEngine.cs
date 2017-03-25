using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UNR_Crossroad.Data
{
    public static class DbEngine
    {
        private static SQLiteDataReader reader;
        private static SQLiteCommand command;
        private static SQLiteConnection connect;

        public static void Connect()
        {
            connect = new SQLiteConnection("Data Source=DB\\UNR_Database.db;");
            connect.Open();
        }

        public static Dictionary<string,string> GetUsers()
        {
            command = new SQLiteCommand("SELECT * FROM 'Users';", connect);
            reader = command.ExecuteReader();
            Dictionary<string, string> users = new Dictionary<string, string>();
            foreach (DbDataRecord record in reader)
            {
                users.Add(record["login"].ToString(),record["password"].ToString());
            }
            return users;
        }

        public static int GetAccLevel(string name)
        {
            command = new SQLiteCommand("SELECT * FROM 'Users' WHERE login='"+name+"';", connect);
            reader = command.ExecuteReader();
            int lvl = 0;
            foreach (DbDataRecord record in reader)
            {
                lvl = Convert.ToInt32(record["level"]);
            }
            return lvl;
        }

        public static string AddUser(string login, string pass, int lvl)
        {
            command = new SQLiteCommand("INSERT INTO 'Users' ('id','login','password','level') VALUES ((SELECT MAX(id) FROM Users)+1,'"+login+"','"+pass+"',"+lvl+");",connect);
            command.ExecuteNonQuery();
            return "Пользователь добавлен";
        }

        public static void Close()
        {
            connect.Close();
        }
    }
}
