using Microsoft.EntityFrameworkCore;

namespace ProductWeb.Services
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<IdentityRole> _rm;
        private readonly UserManager<IdentityUser> _um;

        public RoleService(RoleManager<IdentityRole> _rm, UserManager<IdentityUser> _um) 
        {
            this._rm = _rm;
            this._um = _um;
        }

        public async Task<bool> Add(RoleDto roleDto)
        {
            var identityRole = new IdentityRole
            {
                Name = roleDto.Name,
                NormalizedName = _rm.NormalizeKey(roleDto.Name)
            };
            var result = await _rm.CreateAsync(identityRole);
            if (!result.Succeeded) return false;
            return true;
        }

        public async Task<bool> Delete(string name)
        {
            var identityRole = await Find(name);
            if (identityRole == null) return false;
            var usersInRole = await _um.GetUsersInRoleAsync(name);
            if (usersInRole.Count != 0) return false;
            var result = await _rm.DeleteAsync(identityRole);
            if (!result.Succeeded) return false;
            return true;
        }

        public async Task<IdentityRole> Find(string name)
        {
            return await _rm.FindByNameAsync(name);
        }

        public async Task<List<IdentityRole>> GetAll()
        {
            return await _rm.Roles.ToListAsync();
        }

        public async Task<bool> Update(RoleUpdateDto roleUpdateDto)
        {
            var identityRole = await Find(roleUpdateDto.Name);
            if (identityRole == null) return false;
            identityRole.Name = roleUpdateDto.UpdateName;
            identityRole.NormalizedName = _rm.NormalizeKey(roleUpdateDto.UpdateName);
            var result = await _rm.UpdateAsync(identityRole);
            if (!result.Succeeded) return false;
            return true;
        }
    }
}
