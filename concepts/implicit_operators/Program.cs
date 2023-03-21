using System.Text.Json;

User user = new User()
{
    Id = Guid.NewGuid(),
    Name = "William",
    Email = "me@willsena.dev",
    Active = true,
    InsertedAt = DateTime.Now
};

var credentials = (UserCredentials)user;

Console.WriteLine(JsonSerializer.Serialize(credentials));

Wine wine = new Grape() + new Foot();

Console.WriteLine(wine.ToString());
