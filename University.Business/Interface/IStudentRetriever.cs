using System;
using System.Collections.Generic;
using System.Text;
using University.Domain.Entities;

namespace University.Business.Interface
{
    public interface IStudentRetriever
    {
        List<Student> RetrieveAll();
    }
}
