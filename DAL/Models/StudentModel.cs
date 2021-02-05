using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class StudentModel
    {

        public StudentModel()
        {
        }

        public StudentModel(int studentId)
        {
            StudentId = studentId;
        }

        public StudentModel(string name, DateTime surname, DateTime dob)
        {
            Name = name;
            Surname = surname;
            DOB = dob;
        }

        public StudentModel(int studentId, string name, DateTime surname, DateTime dob)
        {
            StudentId = studentId;
            Name = name;
            Surname = surname;
            DOB = dob;
        }

        public int StudentId { get; set; }
        [Required(ErrorMessage = "You need to enter first name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You need to enter surname.")]
        public DateTime Surname { get; set; }

        [Required(ErrorMessage = "You need to enter date of birth.")]
        public DateTime DOB { get; set; }
    }
}
