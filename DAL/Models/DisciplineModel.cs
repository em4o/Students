using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class DisciplineModel
    {

        public DisciplineModel()
        {
        }

        public DisciplineModel(int disciplineId)
        {
            DisciplineId = disciplineId;
        }

        public DisciplineModel(string disciplineName, string professorName)
        {
            DisciplineName = disciplineName;
            ProfessorName = professorName;
        }

        public DisciplineModel(int disciplineId, string disciplineName, string professorName)
        {
            DisciplineId = disciplineId;
            DisciplineName = disciplineName;
            ProfessorName = professorName;
        }

        public int DisciplineId { get; set; }
        [Required(ErrorMessage = "You need to enter discipline name.")]
        public string DisciplineName { get; set; }

        [Required(ErrorMessage = "You need to enter discipline name.")]
        public string ProfessorName { get; set; }
    }
}
