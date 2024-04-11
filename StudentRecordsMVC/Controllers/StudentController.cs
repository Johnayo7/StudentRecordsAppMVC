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
            if (ModelState.IsValid)
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

            else
            {
                // Validation failed, return to the form view with validation errors
                return View(addStudentRequest);
            }
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid matNo)
        {
            var existingStudent = await _context.Students.FindAsync(matNo);

            if (existingStudent != null)
            {
                var updateModel = new UpdateStudentRecordsVM()
                {
                    MatNo = existingStudent.MatNo,
                    Name = existingStudent.Name,
                    Email = existingStudent.Email,
                    Gender = existingStudent.Gender,
                    DateOfBirth = existingStudent.DateOfBirth,
                    PhoneNumber = existingStudent.PhoneNumber,
                    Faculty = existingStudent.Faculty,
                    Department = existingStudent.Department
                };
                return await Task.Run(() => View("View", updateModel));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateStudentRecordsVM updateModel)
        {
            if (ModelState.IsValid)
            {
                var existingRecord = await _context.Students.FindAsync(updateModel.MatNo);

                if (existingRecord != null)
                {
                    existingRecord.Name = updateModel.Name;
                    existingRecord.Email = updateModel.Email;
                    existingRecord.Gender = updateModel.Gender;
                    existingRecord.DateOfBirth = updateModel.DateOfBirth;
                    existingRecord.PhoneNumber = updateModel.PhoneNumber;
                    existingRecord.Faculty = updateModel.Faculty;
                    existingRecord.Department = updateModel.Department;

                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }

            else
            {
                // Validation failed, return to the form view with validation errors
                return View();
            }

            
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudentRecordsVM recordToRemove)
        {
            var existingRecord = await _context.Students.FindAsync(recordToRemove.MatNo);

            if (existingRecord != null)
            {
                _context.Students.Remove(existingRecord);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}
