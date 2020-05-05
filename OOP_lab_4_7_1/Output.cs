using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_4_7_1
{
    interface Output
    {
        public static void CheckingStudentRating()
        {
            Console.WriteLine(Program.Roman.StudentRating());
        }
    }
}
