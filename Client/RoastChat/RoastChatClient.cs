using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastChat
{
    class RoastChatClient : RoastChatClientInterface
    {
        public bool changePassword(string oldPass, string newPass)
        {
            return false;
        }

        public bool createUser(string username, string password)
        {
            return false;
        }

        public bool login(string username, string password)
        {
            return false;
        }

        public bool logout()
        {
            return false;
        }

        public bool send(string s)
        {
            return false;
        }

        public void setWindow(MainWindow window)
        {
            return;
        }
    }
}
