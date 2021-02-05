using DAL.DataAccess;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.BusinessLogic
{
    public class SemesterRepository : IGenericRepository<SemesterModel>
    {
        public IEnumerable<SemesterModel> GetAll()
        {
            string sql = @"select * from dbo.Discipline;";
            return SqlDataAccess.LoadAll<SemesterModel>(sql);
        }

        public SemesterModel GetById(int id)
        {
            SemesterModel data = new SemesterModel(id);
            string sql = @"select * from dbo.Discipline where DisciplineId=@DisciplineId";
            return SqlDataAccess.LoadSingle<SemesterModel>(sql, data);
        }

        public void Insert(SemesterModel obj)
        {
            string sql = @"insert into dbo.Discipline (DisciplineName, ProfessorName) values (@DisciplineName, @ProfessorName);";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Update(SemesterModel obj)
        {
            string sql = @"update dbo.Discipline set DisciplineName=@DisciplineName,ProfessorName=@ProfessorName where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Delete(int id)
        {
            SemesterModel data = new SemesterModel(id);
            string sql = @"delete from dbo.Discipline where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, data);
        }
    }
}
