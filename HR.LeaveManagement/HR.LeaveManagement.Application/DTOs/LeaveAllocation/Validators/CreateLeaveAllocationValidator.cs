using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationValidator()
        {
            RuleFor(x => x.LeaveTypeId).NotEmpty();
            RuleFor(x => x.NumberOfDays).NotEmpty().GreaterThan(0);
            RuleFor(x => x.Period).NotEmpty().GreaterThan(0);
        }
    }
}
