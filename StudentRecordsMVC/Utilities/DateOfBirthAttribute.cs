using System.ComponentModel.DataAnnotations;

namespace StudentRecordsMVC.Utilities
{
    public class DateOfBirthAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime dateOfBirth = (DateTime)value;
                if (dateOfBirth > DateTime.Today)
                {
                    return new ValidationResult("Date of Birth cannot be in the Future");
                }
            }
            return ValidationResult.Success;
        }
    }
}
