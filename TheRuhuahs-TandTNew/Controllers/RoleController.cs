using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public IActionResult Index()
        {
            var role = _roleService.GetRole();
            return View(role);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddRole(CreateRoleViewModel model)
        {
            _roleService.AddRole(model);

            return RedirectToAction("Index");
        }
        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(UpdateRoleViewModel model)
        {
            _roleService.UpdateRole(model);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Find(string name)
        {
            _roleService.FindByRoleName(name);
            return RedirectToAction("Index");
        }
        public IActionResult Delete (string name)
        {
            _roleService.DeleteRole(name);
            return RedirectToAction("Index");
        }
    }
}