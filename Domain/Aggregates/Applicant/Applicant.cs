using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Aggregates;

public class Applicant : AggregateRoot<ApplicantId>
{
    public string Name { get; private set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Email Email { get; set; }

    public PhoneNumber PhoneNumber { get; set; }
    public ICollection<ApplicantSkill> Skills { get; private set; }
    public ICollection<AnswerId> Answers { get; private set; }

    public Applicant(string name)
    {
        Id = new ApplicantId(Guid.NewGuid());
        Name = name;
        Skills = new List<ApplicantSkill>();
        Answers = new List<AnswerId>();
    }

    public void AddSkill(SkillId skillId)
    {
        Skills.Add(new ApplicantSkill(Id, skillId));
    }

    public void AddAnswer(AnswerId answer)
    {
        Answers.Add(answer);
    }
}
