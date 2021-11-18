using FluentValidation;
using HR.LeaveManagement.Application.Contracts.Persistence;
//using HR.LeaveManagement.Application.Persistance.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.DTOs.LeaveRequest.Validators
{
    public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
        {
            _leaveRequestRepository = leaveRequestRepository;

            RuleFor(x => x.EndDate)
                .NotEmpty()
                .GreaterThan(p => p.StartDate);

            RuleFor(x => x.StartDate).NotEmpty().LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparisonValue}");

            RuleFor(x => x.LeaveTypeId).NotEmpty()
                .GreaterThan(0)
                .MustAsync(async (id, token) => 
                {
                    var leaveTypeExists = await _leaveRequestRepository.Exists(id);
                    return !leaveTypeExists;

                }).WithMessage("{PropertyName} does not exist");
        }
    }
}
