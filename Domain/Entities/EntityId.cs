namespace Domain.Entities;

public class EntityId<T>
{
    public T Value { get; }

    public EntityId(T value)
    {
        if (EqualityComparer<T>.Default.Equals(value, default))
        {
            throw new ArgumentException($"{typeof(T).Name} cannot be default.", nameof(value));
        }

        Value = value;
    }

    public override bool Equals(object obj)
    {
        return obj is EntityId<T> other && EqualityComparer<T>.Default.Equals(Value, other.Value);
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}

