using System.ComponentModel.DataAnnotations.Schema;
using GRLeaveManagement.Domain.Common;

namespace GRLeaveManagement.Domain;

public class LeaveType : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int DefaultDays { get; set; }
}