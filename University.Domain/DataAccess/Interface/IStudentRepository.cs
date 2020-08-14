using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Entities;

namespace University.Domain.DataAccess.Interface
{
    public interface IStudentRepository
    {
        List<Student> RetrieveAll();
    }
}
