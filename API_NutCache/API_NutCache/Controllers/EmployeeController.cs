using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DATA;
using DATA.Context;
using DATA.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API_NutCache.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly RepositoryBase _employeeRepository;



        public EmployeeController()
        {
           _employeeRepository = new RepositoryBase();
        }


        [HttpGet]
        public ActionResult<Employee> ListAll()
        {
            
            var retorno = _employeeRepository.ListAll();
            return Ok(retorno);
        }

 
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var retorno = _employeeRepository.Select(id);
            return Ok(retorno);
        }

     
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            var retorno = _employeeRepository.Insert(emp);
            return Ok(retorno);
        }

  
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee emp)
        {
            var retorno = _employeeRepository.Edit(emp);
            return Ok(retorno);
        }

        
        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id, [FromBody] Employee emp)
        {
            var retorno = _employeeRepository.Delete(emp);
            return Ok(retorno);
        }

      
    }
}
