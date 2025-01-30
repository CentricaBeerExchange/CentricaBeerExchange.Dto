namespace CentricaBeerExchange.Dto;

[DataContract]
public class BeerWrite
{
    public BeerWrite() { }

    public BeerWrite(string name, int breweryId, short styleId, decimal? rating, decimal? aBV, int? untappdId)
    {
        Name = name;
        BreweryId = breweryId;
        StyleId = styleId;
        Rating = rating;
        ABV = aBV;
        UntappdId = untappdId;
    }

    [DataMember(Order = 1)] public string Name { get; set; } = string.Empty;
    [DataMember(Order = 2)] public int BreweryId { get; set; }
    [DataMember(Order = 3)] public short StyleId { get; set; }
    [DataMember(Order = 4)] public decimal? Rating { get; set; }
    [DataMember(Order = 5)] public decimal? ABV { get; set; }
    [DataMember(Order = 6)] public int? UntappdId { get; set; }
}
