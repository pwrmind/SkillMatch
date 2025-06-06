using Domain.Entities;

namespace Domain.Aggregates;

public class JobId : EntityId<Guid>
{
    public JobId(Guid value) : base(value) { }
}
