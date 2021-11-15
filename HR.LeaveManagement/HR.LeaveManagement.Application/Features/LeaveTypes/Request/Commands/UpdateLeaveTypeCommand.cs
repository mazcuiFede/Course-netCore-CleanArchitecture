using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }

}
