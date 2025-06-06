using Domain.Entities;

namespace Domain.Aggregates;

// Сущность Company
public class Company : AggregateRoot<CompanyId>
{
    public string Name { get; private set; }
    public ICollection<JobId> Jobs { get; private set; }

    public Company(string name)
    {
        Id = new CompanyId(Guid.NewGuid());
        Name = name;
        Jobs = new List<JobId>();
    }

    public void AddJob(JobId job)
    {
        Jobs.Add(job);
    }
}

