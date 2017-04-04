using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSIMSServer.Model
{
    public class User
    {
        public User()
        { }

        private string _user_num;
        private string _password;

        /// <summary>
        /// 
        /// </summary>
        public string user_num
        {
            set { _user_num = value; }
            get { return _user_num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
    }
}
