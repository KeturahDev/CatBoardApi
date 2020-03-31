using System.Threading.Tasks;

namespace CatBoardApi.Models
{
    public interface IUserManagementService
    {
      Task<bool> IsValidUser(string username, string password);
    }
}