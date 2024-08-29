using Microsoft.AspNetCore.Mvc;
using EFCoreTask.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EFCoreTask.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ChangepondContext _changepondContext;

        public EmployeeController(ChangepondContext cc)
        {
            _changepondContext = cc;
        }

        public IActionResult Index()
        {
            return View(_changepondContext.Employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Employee emp = await _changepondContext.Employees.Where(e => e.Id == id).FirstOrDefaultAsync();
            return View(emp);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            _changepondContext.Add(employee);
            await _changepondContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Employee emp)
        {
            _changepondContext.Update(emp);
            await _changepondContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var emp = new Employee() { Id = id };
            _changepondContext.Remove(emp);
            await _changepondContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
