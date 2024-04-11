using StudentRecordsMVC.Models.Enums;

namespace StudentRecordsMVC.Models.ViewModel
{
    public class UpdateStudentRecordsVM
    {
        public Guid MatNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long PhoneNumber { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
    }
}
