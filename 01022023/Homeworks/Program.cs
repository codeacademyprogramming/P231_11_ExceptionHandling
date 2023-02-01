using Homeworks.Exceptions;
using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region homework
            //var str = "salam hikmaT";  //Hikmet

            ////Console.WriteLine(MyMethods.ToCapitalize(str));

            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.ToLower());
            //Console.WriteLine(str.ToCapitalize());

            //Console.WriteLine(str.CalcWordsCount());

            //Console.WriteLine(str.FindCharCount('a'));

            //Student std1 = new Student
            //{
            //    FullName = "Hikmet Abbasov",
            //    GroupNo = "P123",
            //};

            //Student std2 = new Student
            //{
            //    FullName = "Hikmet Abbasov",
            //    GroupNo = "P123",
            //};
            //Student std3 = new Student
            //{
            //    FullName = "Hikmet Abbasov",
            //    GroupNo = "P123",
            //};

            //Console.WriteLine(std3.GroupNo);
            //Console.WriteLine(std2.No);
            #endregion


            Course course1 = new Course();

            course1.StudentsLimit = 3;


            Student std1 = new Student
            {
                FullName = "Hikemt Abbasov",
                GroupNo = "P123",
                Point = 80
            };

            Student std2 = new Student
            {
                FullName = "Tofiq Abbasov",
                GroupNo = "D205",
                Point = 70
            };

            Student std3 = new Student
            {
                FullName = "Nermin Abbasova",
                GroupNo = "P201",
                Point = 65
            };

            //course1.Students[0] = std1;
            //course1.Students[1] = std2;
            //course1.Students[2] = std3;

            try
            {
                course1.AddStudent(std1);
                course1.AddStudent(std2);
                course1.AddStudent(std3);
                course1.AddStudent(std3);
            }
            catch (DuplicatedItemException ex)
            {
                Console.WriteLine("Bu nomreli telebe movcuddur:"+ex.Message);
            }
            catch (OutOfLimitException ex)
            {
                Console.WriteLine("Telebe limiti asilir!:"+ex.Message);
            }
          



            Console.WriteLine(course1.Students.Length);

            foreach (Student std in course1.Students)
            {
                Console.WriteLine(std.FullName);
            }



        }

    }
}
