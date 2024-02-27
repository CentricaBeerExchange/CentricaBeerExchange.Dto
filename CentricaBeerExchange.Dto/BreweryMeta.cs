namespace CentricaBeerExchange.Dto;

[DataContract]
public class BreweryMeta
{
    public BreweryMeta()
    {
        Name = string.Empty;
    }

    public BreweryMeta(int id, string name)
    {
        Id = id;
        Name = name;
    }

    [DataMember(Order = 1)] public int Id { get; set; }
    [DataMember(Order = 2)] public string Name { get; set; }
}
