using System;
using System.Collections.Generic;
using System.Text;
using University.Business.Interface;
using University.Domain.Entities;

namespace University.Business
{
   public class StudentRetriever :IStudentRetriever
    {
        private readonly IStudentRetriever _studentRetriever;
        public StudentRetriever(IStudentRetriever studentRetriever)
        {
            _studentRetriever = studentRetriever;
        }

        public List<Student> RetrieveAll()
        {
           return _studentRetriever.RetrieveAll();
        }

    }
}
