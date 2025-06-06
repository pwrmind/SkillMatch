using Damoin.Repositories;
using Domain.Aggregates;

namespace Application.Services;

public class ApplicantService
{
    private readonly IApplicantRepository _applicantRepository;

    public ApplicantService(IApplicantRepository applicantRepository)
    {
        _applicantRepository = applicantRepository;
    }

    public void CreateApplicant(string name)
    {
        var applicant = new Applicant(name);
        
        _applicantRepository.Save(applicant);
    }
}
