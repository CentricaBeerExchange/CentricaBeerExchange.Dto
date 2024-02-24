namespace CentricaBeerExchange.Dto;

[DataContract]
public class Brewery
{
    public Brewery()
    {
        Name = string.Empty;
    }

    public Brewery(int id, string name, string? untappdId, string? location, string? type, string? thumbnail)
    {
        Id = id;
        Name = name;
        UntappdId = untappdId;
        Location = location;
        Type = type;
        Thumbnail = thumbnail;
    }

    [DataMember(Order = 1)] public int Id { get; set; }
    [DataMember(Order = 2)] public string Name { get; set; }
    [DataMember(Order = 3)] public string? UntappdId { get; set; }
    [DataMember(Order = 4)] public string? Location { get; set; }
    [DataMember(Order = 5)] public string? Type { get; set; }
    [DataMember(Order = 6)] public string? Thumbnail { get; set; }
}
