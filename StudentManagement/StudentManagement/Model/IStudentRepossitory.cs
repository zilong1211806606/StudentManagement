using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public interface IStudentRepossitory
    {
        Student GetStudent(int id);
    }
}
