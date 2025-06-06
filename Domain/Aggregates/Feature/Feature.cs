using Domain.Entities;

namespace Domain.Aggregates;

// Сущность Feature
public class Feature : AggregateRoot<FeatureId>
{
    public string Description { get; private set; }
    public ICollection<Question> Questions { get; private set; }

    public Feature(string description)
    {
        Id = new FeatureId(Guid.NewGuid());
        Description = description;
        Questions = new List<Question>();
    }

    public void AddQuestion(Question question)
    {
        Questions.Add(question);
    }
}

