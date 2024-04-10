using StudentRecordsMVC.Models.Enums;

namespace StudentRecordsMVC.Models.Domain
{
    public class Student
    {
        public Guid MatNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }

    }
}
