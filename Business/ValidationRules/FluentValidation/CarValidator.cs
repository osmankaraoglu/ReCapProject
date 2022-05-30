using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThanOrEqualTo(0);
            RuleFor(car => car.Name).NotEmpty();
            RuleFor(car => car.Name).MinimumLength(3);
        }

    }
}
