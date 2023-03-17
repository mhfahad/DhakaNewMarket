using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMKTAPP.Models.Models.Service
{
    public class CompanyInfo
    {
        
            public int id { get; set; }
            public string binNumber { get; set; }
            public string companyName { get; set; }
            public string confirmPassword { get; set; }
            public string document { get; set; }
            public string email { get; set; }
            public string licenseKey { get; set; }
            public string location { get; set; }
            public string userUId { get; set; }
            public int userid { get; set; }
            public virtual User User { get; set; }
            public string logo { get; set; }
            public string phoneNumber { get; set; }
            public string taxNumber { get; set; }
    }
}
