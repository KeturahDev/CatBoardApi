namespace CatBoardApi.Models
{

  public interface IAuthenticateService
  {
      bool IsAuthenticated(TokenRequest request, out string token);
  }

  public class TokenAuthenticationService : IAuthenticateService
  {
    public bool IsAuthenticated(TokenRequest request, out string token)
    {
      throw new System.NotImplementedException();
    }
  }
}