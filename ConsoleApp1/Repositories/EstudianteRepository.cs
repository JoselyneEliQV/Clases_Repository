using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class EstudianteRepository
    {
        private readonly SchoolContext _context= new SchoolContext();

        
        public async Task guardarEstudiante(Student student)
        {      
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Student>> leerEstudiantes ()
        {
            List<Student> lstStudents = _context.Students.ToList();
            return lstStudents;
        }   

        public async Task<Student> leerEstudiantePorId(int id)
        {
            Student student = _context.Students.Where(x => x.StudentId == id).FirstOrDefault();

            return student;
        }   

        public async Task actualizarEstudiante(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();
        }

        public async Task eliminarEstudiante(Student student)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}
