using DAL.DataAccess;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.BusinessLogic
{
    public class DisciplineRepository: IGenericRepository<DisciplineModel>
    {
        public IEnumerable<DisciplineModel> GetAll()
        {
            string sql = @"select * from dbo.Discipline;";
            return SqlDataAccess.LoadAll<DisciplineModel>(sql);
        }

        public DisciplineModel GetById(int id)
        {
            DisciplineModel data = new DisciplineModel(id);
            string sql = @"select * from dbo.Discipline where DisciplineId=@DisciplineId";
            return SqlDataAccess.LoadSingle<DisciplineModel>(sql, data);
        }

        public void Insert(DisciplineModel obj)
        {
            string sql = @"insert into dbo.Discipline (DisciplineName, ProfessorName) values (@DisciplineName, @ProfessorName);";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Update(DisciplineModel obj)
        {
            string sql = @"update dbo.Discipline set DisciplineName=@DisciplineName,ProfessorName=@ProfessorName where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Delete(int id)
        {
            DisciplineModel data = new DisciplineModel(id);
            string sql = @"delete from dbo.Discipline where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, data);
        }
    }
}
