using AspNetCoreSample.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace AspNetCoreSample.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignupUser userModel);
    }
}