using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }

}
