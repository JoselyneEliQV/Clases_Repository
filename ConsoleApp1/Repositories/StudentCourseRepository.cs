using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class StudentCourseRepository
    {
        private readonly SchoolContext _context = new SchoolContext();

        public async Task guardarStudentCourse(StudentCourse studentCourse)
        {
            _context.StudentCourses.Add(studentCourse);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StudentCourse>> leerStudentCourses()
        {
            List<StudentCourse> lstStudentCourses = _context.StudentCourses.ToList();
            return lstStudentCourses;
        }

        public async Task<StudentCourse> leerStudentCoursePorId(int id)
        {
            StudentCourse studentCourse = _context.StudentCourses.Where(x => x.StudentCourseId == id).FirstOrDefault();
            return studentCourse;
        }

        public async Task actualizarStudentCourse(StudentCourse studentCourse)
        {
            _context.StudentCourses.Update(studentCourse);
            await _context.SaveChangesAsync();
        }   

        public async Task eliminarStudentCourse(StudentCourse studentCourse)
        {
            _context.StudentCourses.Remove(studentCourse);
            await _context.SaveChangesAsync();
        }
    }
}
