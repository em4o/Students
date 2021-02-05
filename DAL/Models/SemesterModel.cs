using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class SemesterModel
    {

        public SemesterModel()
        {
        }

        public SemesterModel(int semesterId)
        {
            SemesterId = semesterId;
        }

        public SemesterModel(string semesterName, DateTime startDate, DateTime endDate)
        {
            SemesterName = semesterName;
            StartDate = startDate;
            EndDate = endDate;
        }

        public SemesterModel(int semesterId, string semesterName, DateTime startDate, DateTime endDate)
        {
            SemesterId = semesterId;
            SemesterName = semesterName;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int SemesterId { get; set; }
        [Required(ErrorMessage = "You need to enter semester name.")]
        public string SemesterName { get; set; }

        [Required(ErrorMessage = "You need to enter start date.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "You need to enter end date.")]
        public DateTime EndDate { get; set; }
    }
}
