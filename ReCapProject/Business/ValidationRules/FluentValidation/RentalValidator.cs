using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<RentalDetailDto>
    {
        public RentalValidator()
        {
            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(cu => cu.CompanyName).NotEmpty();
            RuleFor(r => r.RentDate).NotEmpty();
            RuleFor(r => r.ReturnDate).Null().WithMessage("Araç Dönmedi");
        }
    }
}
