using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NMKTAPP.BILL.Interface.Service;
using NMKTAPP.Models.Models.Seller;
using NMKTAPP.Models.Models.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace NMKTAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ServivceController : Controller
    {
        IServiceInfoManager _serManager;
        IHostingEnvironment _rootPath;
        
        public ServivceController(IServiceInfoManager serManager, IHostingEnvironment env)
        {
            _serManager = serManager;
            _rootPath = env;
        }
        // GET: api/<ValuesController>
        [Route("GetServiceList")]
        [HttpGet]
        public List<ServiceInfo> Get(int? id)
        {
            List<ServiceInfo> lst = _serManager.ServiceList(id);
            //var name = lst[0].SellerInfo.sellName;
            return lst;
        }
        
        // GET: api/<ValuesController>
        [Route("GetSerCategory")]
        [HttpGet]
        public List<SerCategory> Get()
        {
            List<SerCategory> lst = _serManager.SerCategoryList();
            //var name = lst[0].SellerInfo.sellName;
            return lst;
        }

        [Route("PotService")]
        [HttpPost]
        public IActionResult Post([FromForm] ServiceInfo service)
        {
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    ImgFile.CopyToAsync(stream);
            //    service.Data = stream.ToArray();
            //}
            if (string.IsNullOrWhiteSpace(_rootPath.WebRootPath))
            {
                _rootPath.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "Images");
            }
            string uploadsFolder = Path.Combine(_rootPath.WebRootPath);
            int index = 0;
            foreach (var item in service.ImgFile)
            {
                index++;
                if (item != null)
                {


                    var uniqueFileName = service.title.Trim().Replace(" ", "").ToString()+index.ToString()+ DateTime.Now.ToString("ddMMyyy") + "_" + item.FileName.Trim();
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    switch (index)
                    {
                        case 1 :
                            service.serImg1 = uniqueFileName;
                            break;
                        case 2:
                            service.serImg2 = uniqueFileName;

                            break;
                        case 3:
                            service.serImg3 = uniqueFileName;

                            break;
                        case 4:
                            service.serImg4 = uniqueFileName;
                            break;
                        
                    }
                }
            }
            service.serCategory = new SerCategory();
            if ((service.serCategoryval != null || service.serCategoryval != "" )&& service.serCategoryId==0)
            {
                service.serCategory.value = service.serCategoryval.ToString();
                service.serCategory.label = service.serCategoryval.ToString();
            }
            else
            {
                service.serCategory = null;
            }
            bool result = _serManager.AddService(service);
            index = 0;
            foreach (var item in service.ImgFile)
            {
                index++;
                if (item != null)
                {


                    var uniqueFileName = service.title.Trim().Replace(" ", "").ToString() + index.ToString() + DateTime.Now.ToString("ddMMyyy") + "_" + item.FileName.Trim();
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        item.CopyTo(fileStream);
                    }
                }
            }

            
            return Ok(result);
        }

        // GET: api/<ValuesController>
        [Route("SendMail")]
        [HttpPost]
        public IActionResult Post(MailInfo mailInfo)
        {



            MailMessage mail = new MailMessage();
            mail.To.Add(mailInfo.toMail);
            mail.From = new MailAddress("mahmudhasanbd95@gmail.com");
            mail.Subject = "TEST SUB";
            mail.Body = mailInfo.mailBody;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new System.Net.NetworkCredential("mahmudhasanbd95@gmail.com", "nhmuqhasjixzqiaz"); // Enter seders User name and password  
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return Ok(true);

        }
        [Route("PotCompany")]
        [HttpPost]
        public IActionResult Post(CompanyInfo comp)
        {

            bool result = _serManager.AddServiceComp(comp);
            return Ok(result);

        }
        [Route("PotSerCategory")]
        [HttpPost]
        public IActionResult Post(SerCategory sercat)
        {

            bool result = _serManager.AddSerCategory(sercat);
            return Ok(result);

        }
        [Route("GetServiceCompList")]
        [HttpGet]
        public List<CompanyInfo> Get(string uid)
        {
            List<CompanyInfo> lst = _serManager.ServiceCopmList(uid);
            //var name = lst[0].SellerInfo.sellName;
            return lst;
        }
    }
}
