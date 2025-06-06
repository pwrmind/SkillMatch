using Domain.Entities;

namespace Domain.Aggregates;

public class QuestionId : EntityId<Guid>
{
    public QuestionId(Guid value) : base(value) { }
}
