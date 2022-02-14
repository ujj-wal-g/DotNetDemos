using ModelValidationDemo.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationDemo.Model
{
    public class PersonModel:IValidatableObject
    {
        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "FirstName can only contain 1-50 characters")]
        [RegularExpression("^[A-Za-z]+$",ErrorMessage="First Name is not valid")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50,MinimumLength =1,ErrorMessage="LastName can only contain 1-50 characters")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Last Name is not valid")]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(1,400)]
        public int WeightInLbs { get; set; }
        [Required]
        [RegularExpression("[0-1]",ErrorMessage ="Phone number only contain digits")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="Phone number can only contain ten digits")]
        public string PhoneNo { get; set; }
        [Required]
        public  DateTime  DateOfBirth { get; set; }
        [DateOneShouldLessThanDateTwo("DateOfBirth",ErrorMessage ="Father's date of birth should be prior than son date of birth")]
        public DateTime FatherdateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
           if(DateOfBirth>DateTime.Now)
           {
                yield return new ValidationResult("Person's Date of birth can not be future date");
           }
            if (FatherdateOfBirth > DateTime.Now)
            {
                yield return new ValidationResult("Father's Date of birth can not be future date");
            }
        }
        
    }
}
