using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentRecordsMVC.Context;
using StudentRecordsMVC.Models.Domain;
using StudentRecordsMVC.Models.ViewModel;

namespace StudentRecordsMVC.Controllers
{
    public class StudentController : Controller
    {
       private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allStudents = await _context.Students.ToListAsync();
            return View(allStudents);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentVM addStudentRequest)
        {
            var newStudent = new Student()
            {
                MatNo = Guid.NewGuid(),
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
                Gender = addStudentRequest.Gender,
                DateOfBirth = addStudentRequest.DateOfBirth,
                PhoneNumber = addStudentRequest.PhoneNumber,
                Faculty = addStudentRequest.Faculty,
                Department = addStudentRequest.Department,
            };

            await _context.Students.AddAsync(newStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
