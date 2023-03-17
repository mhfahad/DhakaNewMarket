using NMKTAPP.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.DAL.Interface.Service
{
    public interface IServiceInfoRepository
    {
        List<ServiceInfo> ServiceList(int ? id);
        List<CompanyInfo> ServiceCopmList(string uid);
        bool AddService(ServiceInfo service);
        bool AddServiceComp(CompanyInfo comp);
        bool AddSerCategory(SerCategory sercat);
        List<SerCategory> SerCategoryList();


    }
}
