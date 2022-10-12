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
            try
            {
                var retorno = _employeeRepository.ListAll();
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

 
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            try
            {
                var retorno = _employeeRepository.Select(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

     
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            try
            {
                var retorno = _employeeRepository.Insert(emp);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

  
        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, [FromBody] Employee emp)
        {
            try
            {
                var retorno = _employeeRepository.Edit(emp);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        [HttpDelete("{id}")]
        public ActionResult<Employee> Delete(int id, [FromBody] Employee emp)
        {
            try
            {
                var retorno = _employeeRepository.Delete(emp);
                return Ok(retorno);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

      
    }
}
