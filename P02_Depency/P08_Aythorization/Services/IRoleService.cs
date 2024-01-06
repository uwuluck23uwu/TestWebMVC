using Microsoft.AspNetCore.Identity;
using P08_Aythorization.Models;

namespace P08_Aythorization.Services
{
    public interface IRoleService
    {
        Task<List<IdentityRole>> Get();
        Task<bool> Add(RoleDto roleDto);
        Task<bool> Update(RoleUpdateDto roleUpdateDto);
        Task<bool> Delete(string name);
        Task<IdentityRole> Find(string name);
    }
}
