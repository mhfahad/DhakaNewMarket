using NMKTAPP.Models.Models.Seller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace NMKTAPP.Models.Models.Service
{
    [Bind]
    public class ServiceInfo
    {
        public int id { get; set; }
        [NotMapped]
        public IFormFile[] ImgFile { get; set; }
        [NotMapped]
        public IFormFile ImgFilen { get; set; }
        //public int  { get; set; }
        public string title { get; set; }
        public string serImg1 { get; set; }
        public string serImg2 { get; set; }
        public string serImg3 { get; set; }
        public string serImg4 { get; set; }
        [NotMapped]
        public string serCategoryval { get; set; }
        public int serCategoryId { get; set; }
        public virtual SerCategory serCategory { get; set; }
        public string time { get; set; }
        public string location { get; set; }
        public string serviceClose { get; set; }
        public  string serviceOpen { get; set; }
        public string userUId { get; set; }
        public int CompanyInfoId { get; set; }
        public virtual CompanyInfo companyInfo { get; set; }
        public string serviceDetails { get; set; }
        public string offeredServices { get; set; }
        public bool active { get; set; }
        public bool status { get; set; }
        public string extraServices { get; set; }
        public string whyUs { get; set; }
    }
}
