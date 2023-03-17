using System;
using System.Collections.Generic;
using NMKTAPP.Models.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.BILL.Interface
{
    public interface IUserInfoManager
    {
        List<User> UserLst(string usrMail, string usrPass);
        bool UserRes(User user);
    }
}
