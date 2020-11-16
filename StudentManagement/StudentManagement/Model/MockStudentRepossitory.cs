using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{
    public class MockStudentRepossitory : IStudentRepossitory
    {
        private List<Student> _studentList;

        public MockStudentRepossitory()
        {
            _studentList = new List<Student> {
                new Student{ id=1,name="张三",classname="一年级一班",email="xxxx" },
                new Student{ id=1,name="李四",classname="一年级二班",email="xxxx" }
            };
        }

        public Student GetStudent(int id)
        {
            return _studentList.Select(a => { 
                a.id = id;return a; 
            }).First<Student>();
            //return _studentList.Where(a => a.id == id).First<Student>();
        }
    }
}
