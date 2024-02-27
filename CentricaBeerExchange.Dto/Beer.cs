namespace CentricaBeerExchange.Dto;

[DataContract]
public class Beer
{
    public Beer()
    {
        Name = string.Empty;
    }

    public Beer(int id, string name, BreweryMeta brewery, Style style, decimal? rating, decimal? abv, int? untappdId)
        : this(id, name, brewery.Id, style.Id, rating, abv, untappdId)
    {
        Brewery = brewery;
        Style = style;
    }

    public Beer(int id, string name, int breweryId, short styleId, decimal? rating, decimal? abv, int? untappdId)
    {
        Id = id;
        Name = name;
        BreweryId = breweryId;
        StyleId = styleId;
        Rating = rating;
        ABV = abv;
        UntappdId = untappdId;
    }

    [DataMember(Order = 1)] public int Id { get; set; }
    [DataMember(Order = 2)] public string Name { get; set; }
    [DataMember(Order = 3)] public int BreweryId { get; set; }
    [DataMember(Order = 4)] public short StyleId { get; set; }
    [DataMember(Order = 5)] public decimal? Rating { get; set; }
    [DataMember(Order = 6)] public decimal? ABV { get; set; }
    [DataMember(Order = 7)] public int? UntappdId { get; set; }

    [DataMember(Order = 8)] public BreweryMeta? Brewery { get; set; }
    [DataMember(Order = 9)] public Style? Style { get; set; }
}
