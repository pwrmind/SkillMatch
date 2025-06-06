using Domain.Aggregates;

namespace Damoin.Repositories;

public interface IApplicantRepository
{
    void Save(Applicant user);
    Applicant? GetById(ApplicantId userId);
    Task AddAsync(Applicant applicant);
    Task<Applicant> GetByIdAsync(Guid applicantId);
    Task UpdateAsync(Applicant applicant);
}