using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class MsgClassifier
    {


        //Message Types from Client to Server, 0~127
        public static enum MsgType :byte
        {
            C_ASK_REGISTER = 0,
            C_ASK_ONLINE,
            C_ADD_BCGROUP,
            C_MSG_TO_BCGROUP,
            C_ADD_FRIEND,
            C_REMOVE_FRIEND,


        //Message Types from Server to Client , 128~255
            S_REGISTER_RESULT = 128,
            S_LOGIN_FAILED,
            S_LOGIN_SUCC,
            S_ADD_TO_BCGROUP,
            S_MSG_FROM_BCGROUP,
            S_ONLINE_LIST,
            S_ADD_FRIEND,
            S_REMOVE_FRIEND
        }

    }
}
