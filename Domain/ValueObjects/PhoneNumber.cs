using System.Text.RegularExpressions;

namespace Domain.ValueObjects;

public class PhoneNumber : ValueObject
{
    private readonly string _value;

    private PhoneNumber(string value)
    {
        // Проверка на валидность номера телефона
        if (!IsValid(value))
        {
            throw new ArgumentException("Invalid phone number.");
        }

        _value = value;
    }

    public static PhoneNumber Create(string value)
    {
        return new PhoneNumber(value);
    }

    public override string ToString()
    {
        return _value;
    }

    private static bool IsValid(string phoneNumber)
    {
        // Реализация логики проверки валидности номера телефона
        // Например, с помощью регулярных выражений
        return Regex.IsMatch(phoneNumber, @"^\+?\d{1,3}?[-. ]?$?\d{1,3}$?[-. ]?\d{3,4}[-. ]?\d{4}$");
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _value;
    }
}
