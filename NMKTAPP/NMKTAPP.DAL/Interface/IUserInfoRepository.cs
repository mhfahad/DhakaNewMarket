using NMKTAPP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DAL.Interface
{
    public interface IUserInfoRepository
    {
        List<User> UserLst(string usrMail, string usrPass);
        bool UserRes(User user);
    }
}
