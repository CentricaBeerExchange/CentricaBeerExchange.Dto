namespace CentricaBeerExchange.Dto;

[DataContract]
public class TastingParticipant
{
    public TastingParticipant()
    {
        Name = string.Empty;
        Beer = new Beer();
    }

    public TastingParticipant(int id, string name, Beer beer)
    {
        Id = id;
        Name = name;
        Beer = beer;
    }

    [DataMember(Order = 1)] public int Id { get; set; }
    [DataMember(Order = 2)] public string Name { get; set; }
    [DataMember(Order = 3)] public Beer Beer { get; set; }
}
