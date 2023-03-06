using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş geçilmez");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgileri boş geçilmez.");
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
