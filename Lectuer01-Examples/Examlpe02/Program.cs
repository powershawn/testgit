using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementLIibrary;

namespace Examlpe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student astudent = new Student()
            {
                name = "shawn",
                phone = "00929039290",
                address = "asdf",
            };
            Console.WriteLine("學生姓名:{0},電話:{1},地址:{2}"
                , astudent.name
                , astudent.phone
                , astudent.address
            );
        }
    }
}
