using Domain.Entities;

namespace Domain.Aggregates;

public class SkillId : EntityId<Guid>
{
    public SkillId(Guid value) : base(value) { }
}
