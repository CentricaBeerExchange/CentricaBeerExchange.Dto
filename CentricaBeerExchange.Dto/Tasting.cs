namespace CentricaBeerExchange.Dto;

[DataContract]
public class Tasting
{
    public Tasting() { }

    public Tasting(int id, DateOnly date, string? theme)
    {
        Id = id;
        Date = date;
        Theme = theme;
    }

    [DataMember(Order = 1)] public int Id { get; set; }
    [DataMember(Order = 2)] public DateOnly Date { get; set; }
    [DataMember(Order = 3)] public string? Theme { get; set; }
}
