namespace CentricaBeerExchange.Dto;

[DataContract]
public class TastingParticipantRegistration
{
    public TastingParticipantRegistration() { }

    public TastingParticipantRegistration(int userId, int beerId)
    {
        UserId = userId;
        BeerId = beerId;
    }

    [DataMember(Order = 1)] public int UserId { get; set; }
    [DataMember(Order = 2)] public int BeerId { get; set; }
}
