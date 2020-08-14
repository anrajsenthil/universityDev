using System.Collections.Generic;
using System.Linq;
using University.Domain.DataAccess.Interface;
using University.Domain.Entities;

namespace University.Domain.DataAccess
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _context;
        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }
        public List<Student> RetrieveAll()
        {
            return null;// _context.Students.ToList();
        }
    }
}
