using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class JobValidation : AbstractValidator<Job>
    {
        public JobValidation()
        {
            RuleFor(x => x.customers).NotEmpty();
            RuleFor(x => x.JobID).NotEmpty();
        }
    }
}
