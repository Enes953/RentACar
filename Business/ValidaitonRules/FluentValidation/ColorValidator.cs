using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidaitonRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
        RuleFor(c => c.ColorName).NotEmpty();
        RuleFor(c => c.ColorName).MaximumLength(2);
        }
        
    }
}
