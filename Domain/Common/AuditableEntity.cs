using exam_system.Domain.Common.Interfaces;

namespace exam_system.Domain.Common;

public abstract class AuditableEntity<TId> : IEntity<TId> 
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public TId Id { get; set; }

}
