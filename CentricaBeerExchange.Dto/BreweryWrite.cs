namespace CentricaBeerExchange.Dto;

[DataContract]
public class BreweryWrite
{
    public BreweryWrite() { }

    public BreweryWrite(string name, string? untappdId, string? location, string? type, string? thumbnail)
    {
        Name = name;
        UntappdId = untappdId;
        Location = location;
        Type = type;
        Thumbnail = thumbnail;
    }

    [DataMember(Order = 1)] public string Name { get; set; } = string.Empty;
    [DataMember(Order = 2)] public string? UntappdId { get; set; }
    [DataMember(Order = 3)] public string? Location { get; set; }
    [DataMember(Order = 4)] public string? Type { get; set; }
    [DataMember(Order = 5)] public string? Thumbnail { get; set; }
}
