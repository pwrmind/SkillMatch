using Domain.Entities;

namespace Domain.Aggregates;

public class FeatureId : EntityId<Guid>
{
    public FeatureId(Guid value) : base(value) { }
}
