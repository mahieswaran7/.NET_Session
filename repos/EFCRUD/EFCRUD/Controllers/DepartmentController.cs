using EFCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

namespace EFCRUD.Controllers
{
    public class DepartmentController : Controller
    {
        private CompanyContext context;
        public DepartmentController(CompanyContext cC)
        {
            context=cC;
        }
        public IActionResult Create()
        {
        //    //var dept1 = new Department()
        //    //{
        //    //    Name = "Development"
        //    //};

        //    //var dept2 = new Department()
        //    //{
        //    //    Name = "Design"
        //    //};

        //    //var dept3 = new Department()
        //    //{
        //    //    Name = "Devops"
        //    //};
        //    //var dept4 = new Department()
        //    //{
        //    //    Name = "Development"
        //    //};

        //    //context.AddRange(dept1,dept2,dept3,dept4);
        //    //context.SaveChanges();

        //    // return "Department Added";
           return View();

            
        }
        [HttpPost]

        public async Task<IActionResult> Create(Department dept)
        {
            context.Add(dept);
            await context.SaveChangesAsync();
            return View();
        }

        public async Task<IActionResult>Edit(int id)
        {
            Department dept = await context.Departments.Where(e => e.Id == id).FirstOrDefaultAsync();

            return View(dept);
        }
        [HttpPost]

        public async  Task<IActionResult>Edit(Department dept)
        {
            context.Update(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(context.Departments.AsNoTracking());
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int id)
        {
            var dep = new Department() { Id = id };
            context.Remove(dep);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
