using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypesDetails;

public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;