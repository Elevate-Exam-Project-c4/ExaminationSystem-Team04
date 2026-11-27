namespace exam_system.Domain.Common.Interfaces
{
    public interface ISoftDeletable
    {
        bool IsDeletable { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
