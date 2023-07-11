using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class CursoRepository
    {
        private readonly SchoolContext _context = new SchoolContext();

        public async Task guardarCurso(Course course)
        {
            _context.Courses.Add(course);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Course>> leerCursos()
        {
            List<Course> lstCourses = _context.Courses.ToList();
            return lstCourses;
        }

        public async Task<Course> leerCursoPorId(int id)
        {
            Course course = _context.Courses.Where(x => x.CourseId == id).FirstOrDefault();

            return course;
        }

        public async Task actualizarCurso(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();
        }

        public async Task eliminarCurso(Course course)
        {
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
        }

    }
}
