using CLI.Commands;
using Damoin.Repositories;
using Domain.ValueObjects;

namespace CLI.Handlers;

public class UpdateApplicantCommandHandler : ICommandHandler<UpdateApplicantCommand>
{
    private readonly IApplicantRepository _applicantRepository;

    public UpdateApplicantCommandHandler(IApplicantRepository applicantRepository)
    {
        _applicantRepository = applicantRepository;
    }

    public async Task HandleAsync(UpdateApplicantCommand command)
    {
        var applicant = await _applicantRepository.GetByIdAsync(command.ApplicantId);
        if (applicant == null)
            throw new ApplicationException($"Applicant with ID {command.ApplicantId} not found.");

        applicant.FirstName = command.FirstName;
        applicant.LastName = command.LastName;
        applicant.Email = Email.Create(command.Email);
        applicant.PhoneNumber = PhoneNumber.Create(command.PhoneNumber);

        await _applicantRepository.UpdateAsync(applicant);
    }
}
