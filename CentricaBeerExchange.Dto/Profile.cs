namespace CentricaBeerExchange.Dto;

[DataContract]
public class Profile
{
    public Profile() { }

    public Profile(int userId, string email, string? name, string? thumbnail)
    {
        UserId = userId;
        Email = email;
        Name = name;
        Thumbnail = thumbnail;
    }

    [DataMember(Order = 1)] public int UserId { get; set; }
    [DataMember(Order = 2)] public string? Email { get; set; }
    [DataMember(Order = 3)] public string? Name { get; set; }
    [DataMember(Order = 4)] public string? Thumbnail { get; set; }
}
