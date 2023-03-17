using Microsoft.EntityFrameworkCore;
using NMKTAPP.DAL.Interface;
using NMKTAPP.DatabaseContext.DatabaseContext;
using NMKTAPP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DAL.DAL
{
    public class UserInfoRepository : IUserInfoRepository
    {
        ProjectDbContext Db;
        public UserInfoRepository(DbContext db)
        {
            Db = (ProjectDbContext)db;
        }

        public List<User> UserLst (string usrMail, string usrPass)
        {
            return Db.users.Where(x => x.usrEmail == usrMail && x.usrPass == usrPass).ToList();
        }
        public bool UserRes(User user)
        {
             Db.users.Add(user);
            return 0 < Db.SaveChanges();
        }

    }
}
