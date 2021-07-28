using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using pos_system.Model;

namespace pos_system.Repository
{
    public class StudentRepository : DatabaseRepository
    {
        public Student Add(Student student)
        {
            DatabaseContext.Students.Add(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public List<Student> GetAll()
        {
            return DatabaseContext.Students.ToList();
        }

        public Student GetById(int studentId)
        {
           foreach(var student in DatabaseContext.Students)
            {
                if (student.Id == studentId)
                    return student;
            }

            return null;
        }

        public Student UpdateStudent(Student student)
        {
            DatabaseContext.Students.Update(student);
            DatabaseContext.SaveChanges();
            return student;
        }

        public bool Delete(Student student)
        {
            DatabaseContext.Students.Remove(student);
            DatabaseContext.SaveChanges();
            return true;
        }
    }
}
