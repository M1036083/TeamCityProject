using MyWebApi.DataAccessRepository;
using MyWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MyWebApi.Controllers
{
    public class EmployeeInfoApiController : ApiController
    {
       readonly private IDataAccessRepository<EmployeeInfo, int> _repository;

        //public EmployeeInfoApiController() : this(new clsDataAccessRepository())
        //{
        //}
        //Inject the DataAccessRepository using Construction Injection 
        public EmployeeInfoApiController(IDataAccessRepository<EmployeeInfo, int> _repository)
        {
            this._repository = _repository;
        }

      

        public IEnumerable<EmployeeInfo> Get()
        {
            return _repository.Get();
        }

        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Get(int id)
        {
            return Ok(_repository.Get(id));
        }

        [ResponseType(typeof(EmployeeInfo))]
        public IHttpActionResult Post(EmployeeInfo emp)
        {
            _repository.Post(emp);
            return Ok(emp);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, EmployeeInfo emp)
        {
            _repository.Put(id, emp);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(void))]
        public IHttpActionResult Delete(int id)
        {
            _repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
