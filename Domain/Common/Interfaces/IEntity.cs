namespace exam_system.Domain.Common.Interfaces
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
