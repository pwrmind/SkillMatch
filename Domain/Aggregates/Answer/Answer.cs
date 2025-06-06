using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Aggregates;

public class Answer : AggregateRoot<AnswerId>
{
    public string Text { get; private set; }

    public Answer(string text)
    {
        Id = new AnswerId(Guid.NewGuid());
        Text = text;
    }
}

