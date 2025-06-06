using Domain.Aggregates;

namespace Domain.Specifications;

public class UniqueEmailSpecification : ISpecification<Applicant>
{
    private readonly string _email;

    public UniqueEmailSpecification(string email)
    {
        _email = email;
    }

    public bool IsSatisfiedBy(Applicant applicant)
    {
        return true;
    }
}
