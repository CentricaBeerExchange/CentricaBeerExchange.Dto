namespace CentricaBeerExchange.Dto;

[DataContract]
public class TastingWrite
{
    public TastingWrite() { }

    public TastingWrite(DateOnly date, string? theme)
    {
        Date = date;
        Theme = theme;
    }

    [DataMember(Order = 1)] public DateOnly Date { get; set; }
    [DataMember(Order = 2)] public string? Theme { get; set; }
}
