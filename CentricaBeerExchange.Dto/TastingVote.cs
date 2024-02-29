namespace CentricaBeerExchange.Dto;

[DataContract]
public class TastingVote
{
    public TastingVote()
    {
        UserName = string.Empty;
        VotedUserName = string.Empty;
    }

    public TastingVote(int userId, string userName, int votedUserId, string votedUserName)
    {
        UserId = userId;
        UserName = userName;
        VotedUserId = votedUserId;
        VotedUserName = votedUserName;
    }

    [DataMember(Order = 1)] public int UserId { get; set; }
    [DataMember(Order = 2)] public string UserName { get; set; }
    [DataMember(Order = 3)] public int VotedUserId { get; set; }
    [DataMember(Order = 4)] public string VotedUserName { get; set; }
}
