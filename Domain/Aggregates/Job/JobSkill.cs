namespace Domain.Aggregates;

public class JobSkill(JobId jobId, SkillId skillId)
{
    public JobId JobId { get; } = jobId;
    public SkillId SkillId { get; } = skillId;
}
