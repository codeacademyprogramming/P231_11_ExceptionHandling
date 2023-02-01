using Homeworks.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Course
    {
        public int StudentsLimit;
        public Student[] Students = new Student[0];

        public void AddStudent(Student std)
        {
            if (Students.Length < StudentsLimit)
            {
                if (!HasStudentByNo(std.No))
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = std;
                }
                else
                {
                    throw new DuplicatedItemException();
                }
            }
            else
            {
                throw new OutOfLimitException($"Limitiniz {this.StudentsLimit} qederdir, asa bilmezsiniz!");
            }
        }

        //Kursda verilmis nomreli telebenin olub olmadigini tapan metod
        public bool HasStudentByNo(int no)
        {
            //for (int i = 0; i < Students.Length; i++)
            //{
            //    if (Students[i].No == no)
            //        return true;
            //}

            foreach (Student std in Students)
            {
                if (std.No == no)
                    return true;
            }

            return false;
        }

    }
}
