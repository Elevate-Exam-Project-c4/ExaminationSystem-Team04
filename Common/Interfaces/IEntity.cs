namespace exam_system.Common.Interfaces
{
    public interface IEntity<TId>
    {
        TId Id { get; set; }
    }
}
