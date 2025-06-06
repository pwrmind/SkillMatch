using Domain.Entities;

namespace Domain.Aggregates;

// Сущность Skill
public class Skill : AggregateRoot<SkillId>
{
    public string Name { get; private set; }
    public ICollection<Feature> Features { get; private set; }

    public Skill(string name)
    {
        Id = new SkillId(Guid.NewGuid());
        Name = name;
        Features = new List<Feature>();
    }

    public void AddFeature(Feature feature)
    {
        Features.Add(feature);
    }
}

