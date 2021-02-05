using System;

namespace DAL.BusinessLogic
{
    public class UnitOfWork : IDisposable
    {
        private DisciplineRepository disciplineRepository;
        private SemesterRepository semesterRepository;

        public UnitOfWork ()
        {
            disciplineRepository = new DisciplineRepository();
            semesterRepository = new SemesterRepository();
        }

        public void Save()
        {
            //context.SaveChanges();
        }

        private bool disposed = false;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
