using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplicationTest.Data;
using WebApplicationTest.Models;

namespace WebApplicationTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IAppRepository _appRepository;
        
        public TestController(IAppRepository appRepository)
        {
            _appRepository = appRepository;
        }
        [HttpPost("SaveUser")]
        public IActionResult SaveUser([FromBody] User user)
        {
            _appRepository.Add(user); 
            return Ok(User);
        }
    }
}
