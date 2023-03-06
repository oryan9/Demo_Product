using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim boş bırakılmaz.");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Minimum 3 kareketer olmalı.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage(" İsim max 50 karakter yazılabilir.");
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Stok boş bırakılmaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş bırakılmaz.");
        }
    }
}
