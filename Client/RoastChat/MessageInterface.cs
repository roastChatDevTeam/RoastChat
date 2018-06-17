using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoastChat
{
    interface MessageInterface
    {
        String getTime();
        String getMessage();
        String getSender();
    }
}
