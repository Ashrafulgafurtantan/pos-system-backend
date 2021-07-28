using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;
using pos_system.Repository;
namespace pos_system.Controllers
{
    public class ServiceController : Controller
    {
        private ServiceRepository _serviceRepository = new ServiceRepository();

        [HttpPost("api/staff/service/add")]
        public IActionResult Add([FromBody] Service service)
        {
            var addedService = _serviceRepository.Add(service);
            return Ok(addedService);
        }

        [HttpPost("api/staff/service/update")]
        public IActionResult Update([FromBody] Service service)
        {
            var updatedService = _serviceRepository.Update(service);
            return Ok(updatedService);
        }

        [HttpGet("api/service/view")]
        public IActionResult Search(string pid)
        {
            var service = _serviceRepository.Search(pid);
            return Ok(service);
        }

        [HttpGet("api/service/report")]
        public IActionResult GetAll()
        {
            var allServices = _serviceRepository.GetAll();
            return Ok(allServices);
        }
    }
}
