using Damoin.Repositories;
using Domain.Aggregates;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ApplicantRepository : IApplicantRepository
{
    private readonly ApplicationDbContext _context;

    public ApplicantRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Save(Applicant user)
    {
        _context.Applicants.Add(user);
        _context.SaveChanges();
    }

    public Applicant? GetById(ApplicantId applicantId)
    {
        return _context.Applicants.Find(applicantId.Value);
    }

    public Task AddAsync(Applicant applicant)
    {
        throw new NotImplementedException();
    }

    public Task<Applicant> GetByIdAsync(Guid applicantId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Applicant applicant)
    {
        throw new NotImplementedException();
    }
}
