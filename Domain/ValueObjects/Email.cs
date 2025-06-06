using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public class Email : ValueObject
{
    private readonly string _value;

    private Email(string value)
    {
        // Проверка на валидность email-адреса
        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid email address.");
        }

        _value = value;
    }

    public static Email Create(string value)
    {
        return new Email(value);
    }

    public override string ToString()
    {
        return _value;
    }

    private static bool IsValid(string email)
    {
        // Реализация логики проверки валидности email-адреса
        // Например, с помощью регулярных выражений
        return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _value;
    }
}
