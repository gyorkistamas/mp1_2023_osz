using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_osztalyok
{
   
    internal class Program
    {

        static string HumanTypeToString(HumanType humanType)
        {
            switch(humanType)
            {
                case HumanType.STUDENT:
                    return "Student";

                case HumanType.TEACHER:
                    return "Teacher";

                default:
                    return "";
            }
        }

        static void Main(string[] args)
        {
            Human tamas = new Human();
            tamas.name = "Györkis Tamás";
            tamas.birthDay = new DateTime(2001, 4, 30);
            tamas.Type = HumanType.STUDENT;

            Console.WriteLine($"{tamas.name} - {tamas.birthDay} - {HumanTypeToString(tamas.Type)}");

            HumanType asd = HumanType.TEACHER;

            Console.ReadLine();
        }
    }
}
