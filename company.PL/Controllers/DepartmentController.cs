using Company.demo.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace company.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DepartmentRepository departmentRepository;
        public DepartmentController(DepartmentRepository _departmentRepository) // ASK CLR TO CREATE OBJECT FROM departmentRepository
        {
            departmentRepository = _departmentRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(departmentRepository.GetAll());
        }
    }
}
