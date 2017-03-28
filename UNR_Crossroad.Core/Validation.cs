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
    }
}