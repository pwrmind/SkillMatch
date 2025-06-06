namespace Domain.Aggregates;

public class ApplicantSkill(ApplicantId userId, SkillId skillId)
{
    public ApplicantId UserId { get; } = userId;
    public SkillId SkillId { get; } = skillId;
}
