using DAL.BusinessLogic;
using DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentsWebApp.Controllers
{
    public class DisciplineController : ApiController
    {
        private DisciplineRepository _disciplineRepository;

        public DisciplineController()
        {
            _disciplineRepository = new DisciplineRepository();
        }

        [HttpGet]
        [Route("api/discipline/GetAll")]
        public IEnumerable<DisciplineModel> GetAll()
        {
            var data = _disciplineRepository.GetAll();
            return data;
        }

        [Route("api/discipline/GetById")]
        public DisciplineModel GetById(int id)
        {
            var data = _disciplineRepository.GetById(id);
            return data;
        }

        [HttpPost]
        [Route("api/discipline/Insert")]
        public void Insert(DisciplineModel model)
        {
            if (ModelState.IsValid)
            {
                _disciplineRepository.Insert(model);
            }
        }

        [HttpPost]
        [Route("api/discipline/Update")]
        public void Update(DisciplineModel model)
        {
            if (ModelState.IsValid)
            {
                _disciplineRepository.Update(model);
            }
        }

        [HttpPost]
        [Route("api/discipline/Delete")]
        public void Delete(int id)
        {
            _disciplineRepository.Delete(id);
        }
    }
}
