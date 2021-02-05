using DAL.BusinessLogic;
using DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentsWebApp.Controllers
{
    public class SemesterController : ApiController
    {
        private SemesterRepository _repository;

        public SemesterController()
        {
            _repository = new SemesterRepository();
        }

        [HttpGet]
        [Route("api/semester/GetAll")]
        public IEnumerable<SemesterModel> GetAll()
        {
            var data = _repository.GetAll();
            return data;
        }

        [Route("api/semester/GetById")]
        public SemesterModel GetById(int id)
        {
            var data = _repository.GetById(id);
            return data;
        }

        [HttpPost]
        [Route("api/semester/Insert")]
        public void Insert(SemesterModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(model);
            }
        }

        [HttpPost]
        [Route("api/semester/Update")]
        public void Update(SemesterModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
            }
        }

        [HttpPost]
        [Route("api/semester/Delete")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
