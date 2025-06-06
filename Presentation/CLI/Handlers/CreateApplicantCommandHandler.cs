using CLI.Commands;
using Damoin.Repositories;
using Domain.Aggregates;
using Domain.ValueObjects;

namespace CLI.Handlers;

public class CreateApplicantCommandHandler : ICommandHandler<CreateApplicantCommand>
{
    private readonly IApplicantRepository _applicantRepository;

    public CreateApplicantCommandHandler(IApplicantRepository applicantRepository)
    {
        _applicantRepository = applicantRepository;
    }

    public async Task HandleAsync(CreateApplicantCommand command)
    {
        var applicant = new Applicant("OldBoy")
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = Email.Create(command.Email),
            PhoneNumber = PhoneNumber.Create(command.PhoneNumber)
        };

        await _applicantRepository.AddAsync(applicant);
    }
}
