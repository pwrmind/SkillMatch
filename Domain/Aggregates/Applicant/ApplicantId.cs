using Domain.Entities;

namespace Domain.Aggregates;

public class ApplicantId : EntityId<Guid>
{
    public ApplicantId(Guid value) : base(value) { }
}
