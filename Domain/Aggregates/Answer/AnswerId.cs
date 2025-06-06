using Domain.Entities;

namespace Domain.Aggregates;

public class AnswerId : EntityId<Guid>
{
    public AnswerId(Guid value) : base(value) { }
}
