using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ModelValidationDemo.ValidationAttributes
{
    public class DateOneShouldLessThanDateTwo : ValidationAttribute
    {
        private readonly string _dateTwoPropertyName;
        public DateOneShouldLessThanDateTwo(string dateTwoPropertyName)
        {
            _dateTwoPropertyName = dateTwoPropertyName;

        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime dateOneValue = (DateTime)value;
            DateTime dateTwoValue = (DateTime)validationContext.ObjectInstance.GetType().GetProperty(_dateTwoPropertyName).GetValue(validationContext.ObjectInstance);
            if(dateOneValue< dateTwoValue)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}
