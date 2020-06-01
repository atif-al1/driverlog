using System;
using System.ComponentModel.DataAnnotations;

namespace Drivers.Models
{
    public class TimeCheck : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Trip)validationContext.ObjectInstance;
            DateTime _endTime = Convert.ToDateTime(model.end);
            DateTime _startTime = Convert.ToDateTime(model.start);
            if(_endTime > _startTime)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("End time must be greater than Start time");
            }
        }

    }

    public class Speed : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (Models.Trip)validationContext.ObjectInstance;
            DateTime _endTime = Convert.ToDateTime(model.end);
            DateTime _startTime = Convert.ToDateTime(model.start);
            if(_endTime > _startTime)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("End time must be greater than Start time");
            }
        }

    }

    
}