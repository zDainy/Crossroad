using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using UNR_Crossroad.Core;

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

        public static bool UserCheck(string name, string pass)
        {
            command = new SQLiteCommand("SELECT * FROM 'Users' WHERE login='"+name+"' AND password='"+pass+"';", connect);
            reader = command.ExecuteReader();
            return reader.HasRows;
        }

        public static bool LoginCheck(string name)
        {
            command = new SQLiteCommand("SELECT * FROM 'Users' WHERE login='"+name+"';", connect);
            reader = command.ExecuteReader();
            return reader.HasRows;
        }

        public static string AddUser(string login, string pass, int lvl)
        {
            command = new SQLiteCommand("INSERT INTO 'Users' ('id','login','password','level') VALUES ((SELECT MAX(id) FROM Users)+1,'"+login+"','"+pass+"',"+lvl+");",connect);
            command.ExecuteNonQuery();
            return "Пользователь добавлен";
        }

        public static void SaveRoad(string name,int right, int left, int up, int down,int i1,int i2,bool pright, bool pleft, bool pup, bool pdown)
        {
            command = new SQLiteCommand("INSERT INTO 'Crossroads' VALUES ((SELECT MAX(id) FROM Crossroads)+1,'" + name + "'," + right + "," + left + "," + up + "," + down + "," + i1 + "," + i2 + ",'" + pright + "','" + pleft + "','" + pup + "','" + pdown + "');", connect);
            command.ExecuteNonQuery();
        }

        public static Dictionary<int, string> GetRoads()
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads';", connect);
            reader = command.ExecuteReader();
            Dictionary<int, string> roads = new Dictionary<int, string>();
            foreach (DbDataRecord record in reader)
            {
                roads.Add(Convert.ToInt32(record["id"]), record["name"].ToString());
            }
            Close();
            return roads;
        }

        public static bool NameCheck(string name)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE name='" + name + "';", connect);
            reader = command.ExecuteReader();
            bool b = reader.HasRows;
            Close();
            return b;
        }

        public static void DeleteSelectedId(int id)
        {
            Connect();
            command = new SQLiteCommand("DELETE FROM 'Crossroads' WHERE id="+id, connect);
            command.ExecuteNonQuery();
            Close();
        }
        public static void DeleteSelectedName(string name)
        {
            Connect();
            command = new SQLiteCommand("DELETE FROM 'Crossroads' WHERE name='" + name + "'", connect);
            command.ExecuteNonQuery();
            Close();
        }

        public static Road LoadRoadSelectedId(int id)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE id=" + id, connect);
            reader = command.ExecuteReader();
            Road r = null;
            foreach (DbDataRecord record in reader)
            {
                r = new Road(Convert.ToInt32(record["polLeft"]), Convert.ToInt32(record["polRight"]), Convert.ToInt32(record["polUp"]), Convert.ToInt32(record["polDown"]));
            }
            Close();
            return r;
        }
        public static Road LoadRoadSelectedName(string name)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE name='" + name + "'", connect);
            reader = command.ExecuteReader();
            Road r = null;
            foreach (DbDataRecord record in reader)
            {
                r = new Road(Convert.ToInt32(record["polLeft"]), Convert.ToInt32(record["polRight"]), Convert.ToInt32(record["polUp"]), Convert.ToInt32(record["polDown"]));
            }
            Close();
            return r;
        }
        public static RoadTransit LoadTransitSelectedName(string name)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE name='" + name + "'", connect);
            reader = command.ExecuteReader();
            RoadTransit r = null;
            foreach (DbDataRecord record in reader)
            {
                r = new RoadTransit(Convert.ToBoolean(record["peoUp"]), Convert.ToBoolean(record["peoDown"]), Convert.ToBoolean(record["peoLeft"]), Convert.ToBoolean(record["peoRight"]), Convert.ToInt32(record["polLeft"]), Convert.ToInt32(record["polRight"]), Convert.ToInt32(record["polUp"]), Convert.ToInt32(record["polDown"]));
            }
            Close();
            return r;
        }

        public static RoadTransit LoadTransitSelectedId(int id)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE id=" + id, connect);
            reader = command.ExecuteReader();
            RoadTransit r = null;
            foreach (DbDataRecord record in reader)
            {
                r = new RoadTransit(Convert.ToBoolean(record["peoUp"]), Convert.ToBoolean(record["peoDown"]), Convert.ToBoolean(record["peoLeft"]), Convert.ToBoolean(record["peoRight"]), Convert.ToInt32(record["polLeft"]), Convert.ToInt32(record["polRight"]), Convert.ToInt32(record["polUp"]), Convert.ToInt32(record["polDown"]));
            }
            Close();
            return r;
        }
        public static int LoadIntervalName(string name, int i)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE name='" + name + "'", connect);
            reader = command.ExecuteReader();
            int r = 30;
            foreach (DbDataRecord record in reader)
            {
                r = Convert.ToInt32(record["int" + i]);
            }
            Close();
            return r;
        }

        public static int LoadIntervalId(int id,int i)
        {
            Connect();
            command = new SQLiteCommand("SELECT * FROM 'Crossroads' WHERE id=" + id, connect);
            reader = command.ExecuteReader();
            int r = 30;
            foreach (DbDataRecord record in reader)
            {
                r =Convert.ToInt32(record["int"+i]);
            }
            Close();
            return r;
        }

        public static void Close()
        {
            connect.Close();
        }
    }
}
