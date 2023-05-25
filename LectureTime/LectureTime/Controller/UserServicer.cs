using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LectureTime.Utility;

namespace LectureTime.Controller
{
    internal class UserServicer
    {
        public bool IsLoginSuccess(string inputId, string inputPw)
        {
            if (inputId == Constant.USER_ID && inputPw == Constant.USER_PASSWORD)
                return true;
            return true;
        }


    }
}
