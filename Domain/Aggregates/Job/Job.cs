using Domain.Entities;

namespace Domain.Aggregates;

// Сущность Job
public class Job : AggregateRoot<JobId>
{
    public string Title { get; private set; }
    public ICollection<JobSkill> Skills { get; private set; }

    public Job(string title)
    {
        Id = new JobId(Guid.NewGuid());
        Title = title;
        Skills = new List<JobSkill>();
    }

    public void AddSkill(SkillId skillId)
    {
        Skills.Add(new JobSkill(Id, skillId));
    }
}