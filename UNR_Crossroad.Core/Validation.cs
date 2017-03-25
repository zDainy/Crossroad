using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UNR_Crossroad.Core
{
    public static class Validation
    {
        private static string _user;
        private static string _pass;

        public static string EmptyCheck(string user, string pass)
        {
            _user = user;
            _pass = pass;
            if (_user == "")
            {
                return "Пустое имя пользователя";
            }
            if (_pass == "")
            {
                return "Пустой пароль";
            }
            return "OK";
        }

        public static string EntranceCheck(string user, string pass)
        {
            if (user == _user)
            {
                if (pass == _pass)
                {
                    return "OK";
                }
                return "Неверный пароль";
            }
            return "Пользователь не найден";
        }

        public static string NameCheck(string user)
        {
            if (user == _user)
            {
                return "Пользователь с таким именем уже существует";
            }
            return "OK";
        }

    }
}