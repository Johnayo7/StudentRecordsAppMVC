using StudentRecordsMVC.Models.Enums;
using StudentRecordsMVC.Utilities;
using System.ComponentModel.DataAnnotations;

namespace StudentRecordsMVC.Models.ViewModel
{
    public class UpdateStudentRecordsVM
    {
        public Guid MatNo { get; set; }

        [Required(ErrorMessage =("Name is required"))]
        [RegularExpression(@"^[A-Z][a-z]*(\s[A-Z][a-z]*)*$",
            ErrorMessage = "Every Name must start with a capital letter and contain only letters")]
        [MaxLength(100, ErrorMessage =("Name cannot Exceed 100 characters"))]
        public string Name { get; set; }

        [Required(ErrorMessage =("Email is required"))]
        [EmailAddress(ErrorMessage =("Invalid Email Format"))]
        public string Email { get; set; }

        [Required(ErrorMessage =("Gender is required"))]
        public Gender Gender { get; set; }

        [Required(ErrorMessage =("Date of Birth is required"))]
        [DataType(DataType.Date)]
        [DateOfBirth(ErrorMessage="Date of Birth cannot be in the Future")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage =("Phone Number is required"))]
        [RegularExpression(@"^\+?\d{10,14}$", 
            ErrorMessage = "Phone number must be between 10 to 14 digits and may start with a '+' sign")]
        public long PhoneNumber { get; set; }

        [Required(ErrorMessage =("Faculty is required"))]
        [RegularExpression(@"^[A-Z][a-z]*(\s[A-Z][a-z]*)*$",
            ErrorMessage = "Every word must start with a capital letter and contain only letters")]
        [MaxLength(100, ErrorMessage =("Faculty name cannot exceed 100 characters"))]
        public string Faculty { get; set; }

        [Required(ErrorMessage =("Department is Required"))]
        [RegularExpression(@"^[A-Z][a-z]*(\s[A-Z][a-z]*)*$", 
            ErrorMessage = "Every word must start with a capital letter and contain only letters")]
        [MaxLength(100, ErrorMessage =("Department name cannot exceed 100 characters"))]
        public string Department { get; set; }
    }
}
