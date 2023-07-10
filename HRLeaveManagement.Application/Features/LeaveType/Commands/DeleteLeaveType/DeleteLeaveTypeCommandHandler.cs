﻿using HRLeaveManagement.Application.Contracts.Persistence;
using HRLeaveManagement.Application.Exceptions;
using MediatR;

namespace HRLeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;

public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _leaveTypeRepository;

    public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository leaveTypeRepository)
    {
        _leaveTypeRepository = leaveTypeRepository;
    }

    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        // retrieve to domain entity object
        var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

        // verify that record exists
        if (leaveTypeToDelete == null)
        {
            throw new NotFoundException(nameof(LeaveType), request.Id);
        }
        
        // add to database
        await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);

        //return Unit value;
        return Unit.Value;
    }
}