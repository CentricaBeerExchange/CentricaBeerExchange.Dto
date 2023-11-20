namespace CentricaBeerExchange.Dto.Auth;

[DataContract]
public class RefreshRequest
{
    public RefreshRequest() { }

    public RefreshRequest(string accessToken, string refreshToken)
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
    }

    [DataMember(Order = 1)] public string? AccessToken { get; set; }
    [DataMember(Order = 2)] public string? RefreshToken { get; set; }
}
