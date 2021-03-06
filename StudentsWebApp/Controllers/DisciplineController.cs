﻿using DAL.BusinessLogic;
using DAL.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace StudentsWebApp.Controllers
{
    public class DisciplineController : ApiController
    {
        private DisciplineRepository _repository;

        public DisciplineController()
        {
            _repository = new DisciplineRepository();
        }

        [HttpGet]
        [Route("api/discipline/GetAll")]
        public IEnumerable<DisciplineModel> GetAll()
        {
            var data = _repository.GetAll();
            return data;
        }

        [Route("api/discipline/GetById")]
        public DisciplineModel GetById(int id)
        {
            var data = _repository.GetById(id);
            return data;
        }

        [HttpPost]
        [Route("api/discipline/Insert")]
        public void Insert(DisciplineModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(model);
            }
        }

        [HttpPost]
        [Route("api/discipline/Update")]
        public void Update(DisciplineModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
            }
        }

        [HttpPost]
        [Route("api/discipline/Delete")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
