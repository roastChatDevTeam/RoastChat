using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastChat
{
    interface RoastChatClientInterface
    {
        bool send(String s);

        bool login(String username, String password);

        bool logout();

        bool changePassword(String oldPass, String newPass);

        bool createUser(String username, String password);

        void setWindow(MainWindow window);




    }
}
