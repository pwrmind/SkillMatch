using Domain.Entities;

namespace Domain.Aggregates;

// Сущность Question
public class Question : AggregateRoot<QuestionId>
{
    public string Text { get; private set; }
    public ICollection<Answer> Answers { get; private set; }

    public Question(string text)
    {
        Id = new QuestionId(Guid.NewGuid());
        Text = text;
        Answers = new List<Answer>();
    }

    public void AddAnswer(Answer answer)
    {
        Answers.Add(answer);
    }
}

