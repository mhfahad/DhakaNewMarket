using NMKTAPP.BILL.Interface.Service;
using NMKTAPP.DAL.Interface.Service;
using NMKTAPP.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.BILL.BILL.Service
{
    public class ServiceInfoManager : IServiceInfoManager
    {
        IServiceInfoRepository _Repository;
        public ServiceInfoManager(IServiceInfoRepository serManager)
        {
            _Repository = serManager;
        }

        public List<ServiceInfo> ServiceList( int? id)
        {
            return _Repository.ServiceList(id).ToList();
        }
        public List<SerCategory> SerCategoryList()
        {
            return _Repository.SerCategoryList().ToList();
        }

       public  bool AddService(ServiceInfo service)
        {
            return _Repository.AddService(service);
        }
        public bool AddServiceComp(CompanyInfo comp)
        {
            return _Repository.AddServiceComp(comp);
        }
        public bool AddSerCategory(SerCategory sercat)
        {
            return _Repository.AddSerCategory(sercat);
        }
        
        public List<CompanyInfo> ServiceCopmList(string uid)
        {
            return _Repository.ServiceCopmList(uid).ToList();
        }
    }
}
