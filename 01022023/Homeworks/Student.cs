using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    internal class Student
    {
        static int TotalCount;
        public Student()
        {
            TotalCount++;
            No = TotalCount;
        }
        public int No;
        public string FullName;
        private string _groupNo;

        public byte Point;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
            }
        }

        public static bool CheckGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length > 4)
                return false;

            if (!char.IsUpper(str[0]))
                return false;

            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }

            return true;
        }
    }
}
