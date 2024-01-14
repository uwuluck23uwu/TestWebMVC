using Microsoft.AspNetCore.Mvc;
using ProductWeb.Services;

namespace ProductWeb.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _roleService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleDto roleDto)
        {
            var result = await _roleService.Add(roleDto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(string name)
        {
            var result = await _roleService.Find(name);
            return View(new RoleUpdateDto { Name = result.Name });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RoleUpdateDto roleUpdateDto)
        {
            var result = await _roleService.Update(roleUpdateDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string name)
        {
            var result = await _roleService.Delete(name);
            return RedirectToAction(nameof(Index));
        }

    }
}
