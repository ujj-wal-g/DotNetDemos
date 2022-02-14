using FluentValidation;
using ModelValidationDemo.Model;

namespace ModelValidationDemo.Validator
{
    public class FluentPersonModelValidator:AbstractValidator<FluentPersonModel>
    {
        public FluentPersonModelValidator()
        {
            //Validations for firstname
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .NotNull()
                .WithMessage("First name can not be null or empty");

            RuleFor(x => x.FirstName)
                .MinimumLength(1)
                .MaximumLength(50);

            RuleFor(x => x.FirstName)
                .Matches("^[A-Za-z]+$")
                .WithMessage("First Name contains only alphabets");

          //  Validations for Lastname
            RuleFor(x => x.LastName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Last name can not be null or empty");

            RuleFor(x => x.LastName)
                .MinimumLength(1)
                .MaximumLength(50);

            RuleFor(x => x.LastName)
                .Matches("^[A-Za-z]+$")
                .WithMessage("Last Name only alphabets");

           // Validations for Email
            RuleFor(x=>x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Email can not be empty or null");

            RuleFor(x => x.Email).EmailAddress();

            //Validations for person Weight
            RuleFor(person => person)
                .Must(x => x.WeightInLbs <= 400 && x.WeightInLbs >= 1)
                .WithMessage("Weight must be between 1 to 400 pounds");

            //Validations for son's date of birth
            RuleFor(x => x.DateOfBirth)
                .LessThan(DateTime.Now)
                .WithMessage("Person date of birth can not be future date");

            //Validations for Father's date of birth
            RuleFor(x => x.FatherDateOfBirth)
               .LessThan(DateTime.Now)
               .WithMessage("Father's date of birth can not be future date");


            RuleFor(person => person)
                .Must(x => x.DateOfBirth > x.FatherDateOfBirth)
               .WithMessage("Father's date of birth should be prior than son's date of birth");

            // //Validations for MobileNumber
            RuleFor(x => x.MobileNumber)
                .NotNull()
                .NotEmpty()
                .Matches(@"^91?\d{10}$").WithMessage("Invalid Mobile number");

           
        }
    }
}
