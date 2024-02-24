namespace CentricaBeerExchange.Dto;

[DataContract]
public class Style
{
    public Style()
    {
        Name = string.Empty;
    }

    public Style(short id, string name)
    {
        Id = id;
        Name = name;
    }

    [DataMember(Order = 1)] public short Id { get; set; }
    [DataMember(Order = 2)] public string Name { get; set; }
}
