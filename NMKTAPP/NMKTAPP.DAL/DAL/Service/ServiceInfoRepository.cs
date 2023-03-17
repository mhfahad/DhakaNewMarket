using Microsoft.EntityFrameworkCore;
using NMKTAPP.DAL.Interface.Service;
using NMKTAPP.DatabaseContext.DatabaseContext;
using NMKTAPP.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DAL.DAL.Service
{
    public class ServiceInfoRepository : IServiceInfoRepository
    {
        ProjectDbContext Db;
        public ServiceInfoRepository(DbContext db)
        {
            Db = (ProjectDbContext)db;
        }
        public List<ServiceInfo> ServiceList(int ? id)
        {
            if (id !=null)
            {
                return Db.ServiceInfos.Where(c=>c.CompanyInfoId==id).Include(m => m.companyInfo).Include(n => n.serCategory).ToList();
            }
            else
            {
                return Db.ServiceInfos.Include(m => m.companyInfo).Include(n => n.serCategory).ToList();

            }
        }
        public List<SerCategory> SerCategoryList()
        {

            return Db.serCategories.ToList();


        }
        public bool AddService(ServiceInfo service)
        {
            Db.ServiceInfos.Add(service);
            return Db.SaveChanges() > 0;
        }
        public bool AddServiceComp(CompanyInfo comp)
        {
            Db.companyInfos.Add(comp);
            return Db.SaveChanges() > 0;
        }
        public bool AddSerCategory(SerCategory sercat)
        {
            Db.serCategories.Add(sercat);
            return Db.SaveChanges() > 0;
        }
        public List<CompanyInfo> ServiceCopmList(string uid)
        {
            if (uid != null)
            {
                return Db.companyInfos.Where(c => c.userUId == uid).Include(m => m.User).ToList();
            }
            else
            {
                return Db.companyInfos.Include(m => m.User).ToList();

            }
        }
    }
}
