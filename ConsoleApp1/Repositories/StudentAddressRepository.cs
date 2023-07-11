using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class StudentAddressRepository
    {
        private readonly SchoolContext _context = new SchoolContext();

        public async Task guardarStudentAddress(StudentAddress studentAddress)
        {
            _context.StudentAddresses.Add(studentAddress);
            await _context.SaveChangesAsync();
        }

        public async Task<List<StudentAddress>> leerStudentAddresses()
        {
            List<StudentAddress> lstStudentAddresses = _context.StudentAddresses.ToList();
            return lstStudentAddresses;
        }   

        public async Task<StudentAddress> leerStudentAddressPorEstudiantesId(int id)
        {
            StudentAddress studentAddress = _context.StudentAddresses.Where(x => x.StudentID == id).FirstOrDefault();
            return studentAddress;
        }

        public async Task actualizarStudentAddress(StudentAddress studentAddress)
        {
            _context.StudentAddresses.Update(studentAddress);
            await _context.SaveChangesAsync();
        }

        public async Task eliminarStudentAddress(StudentAddress studentAddress)
        {
            _context.StudentAddresses.Remove(studentAddress);
            await _context.SaveChangesAsync();
        }


    }
}
