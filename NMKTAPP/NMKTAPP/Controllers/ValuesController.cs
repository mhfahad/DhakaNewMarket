using Microsoft.AspNetCore.Mvc;
using NMKTAPP.BILL.Interface;
using NMKTAPP.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NMKTAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IUserInfoManager _userManager;
        public ValuesController(IUserInfoManager userManager)
        {
            _userManager = userManager;
        }
        // GET: api/<ValuesController>
        [Route("GetUser")]
        [HttpGet]
        public IActionResult Get(string usrMail,string usrPass)
        {
            
            return Ok( _userManager.UserLst(usrMail, usrPass));
        }
        [Route("PotsUser")]
        [HttpPost]
        public IActionResult Post(User user)
        {
            bool result = _userManager.UserRes(user);

            return Ok(result);
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
