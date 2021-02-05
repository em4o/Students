using DAL.DataAccess;
using DAL.Models;
using System.Collections.Generic;

namespace DAL.BusinessLogic
{
    public class StudentRepository : IGenericRepository<StudentModel>
    {
        public IEnumerable<StudentModel> GetAll()
        {
            string sql = @"select * from dbo.Discipline;";
            return SqlDataAccess.LoadAll<StudentModel>(sql);
        }

        public StudentModel GetById(int id)
        {
            StudentModel data = new StudentModel(id);
            string sql = @"select * from dbo.Discipline where DisciplineId=@DisciplineId";
            return SqlDataAccess.LoadSingle<StudentModel>(sql, data);
        }

        public void Insert(StudentModel obj)
        {
            string sql = @"insert into dbo.Discipline (DisciplineName, ProfessorName) values (@DisciplineName, @ProfessorName);";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Update(StudentModel obj)
        {
            string sql = @"update dbo.Discipline set DisciplineName=@DisciplineName,ProfessorName=@ProfessorName where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, obj);
        }

        public void Delete(int id)
        {
            StudentModel data = new StudentModel(id);
            string sql = @"delete from dbo.Discipline where DisciplineId=@DisciplineId";
            SqlDataAccess.SaveData(sql, data);
        }
    }
}
