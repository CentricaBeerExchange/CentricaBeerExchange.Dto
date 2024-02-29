namespace CentricaBeerExchange.Dto;

[DataContract]
public class TastingVoteRegistration
{
    public TastingVoteRegistration() { }

    public TastingVoteRegistration(int userId, int votedUserId)
    {
        UserId = userId;
        VotedUserId = votedUserId;
    }

    [DataMember(Order = 1)] public int UserId { get; set; }
    [DataMember(Order = 2)] public int VotedUserId { get; set; }
}
