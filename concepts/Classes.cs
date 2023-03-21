using System;

public class User
{
    public Guid Id { get; set; }

    public String Name { get; set; }

    public String Email { get; set; }

    public Boolean Active { get; set; }

    public DateTime InsertedAt { get; set; }
}

public class UserCredentials
{
    public String Id { get; private set; }

    public String Name { get; private set; }

    public static implicit operator UserCredentials(User user)
    {
        if (user == null) return null;

        return new UserCredentials()
        {
            Id = user.Id.ToString(),
            Name = user.Name
        };
    }
}

class Wine
{
    public override string ToString() => "🍷";
}

class Foot
{
    public override string ToString() => "🦶";
}

class Grape
{
    public static Wine operator +(Grape grape, Foot foot) => new Wine();
    public override string ToString() => "🍇";
}