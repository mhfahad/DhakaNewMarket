using NMKTAPP.BILL.Interface;
using NMKTAPP.DAL.Interface;
using NMKTAPP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.BILL.BILL
{
    public class UserInfoManager : IUserInfoManager
    {
        IUserInfoRepository _Repository;
        public UserInfoManager(IUserInfoRepository Repository)
        {
            _Repository = Repository;
        }
        public List<User> UserLst(string usrMail, string usrPass)
        {
            return _Repository.UserLst(usrMail,usrPass);
        }

        public bool UserRes(User user)
        {
           
            return  _Repository.UserRes(user); ;
        }
    }
}
