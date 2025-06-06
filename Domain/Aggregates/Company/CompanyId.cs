using Domain.Entities;

namespace Domain.Aggregates;

public class CompanyId : EntityId<Guid>
{
    public CompanyId(Guid value) : base(value) { }
}
