using DAL.BusinessLogic;
using DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentsWebApp.Controllers
{
    public class StudentController : ApiController
    {
        private StudentRepository _repository;

        public StudentController()
        {
            _repository = new StudentRepository();
        }

        [HttpGet]
        [Route("api/student/GetAll")]
        public IEnumerable<StudentModel> GetAll()
        {
            var data = _repository.GetAll();
            return data;
        }

        [Route("api/student/GetById")]
        public StudentModel GetById(int id)
        {
            var data = _repository.GetById(id);
            return data;
        }

        [HttpPost]
        [Route("api/student/Insert")]
        public void Insert(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(model);
            }
        }

        [HttpPost]
        [Route("api/student/Update")]
        public void Update(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
            }
        }

        [HttpPost]
        [Route("api/student/Delete")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
