namespace CentricaBeerExchange.Dto.Auth;

[DataContract]
public class SignUpRequest
{
    public SignUpRequest() { }

    public SignUpRequest(string? email, string? name)
    {
        Email = email;
        Name = name;
    }

    [DataMember(Order = 1)] public string? Email { get; set; }
    [DataMember(Order = 2)] public string? Name { get; set; }
}
