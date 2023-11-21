using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_osztalyok
{
    enum HumanType
    {
        STUDENT, TEACHER
    }

   
    internal class Program
    {

        static string ConvertHumanTypeToString(HumanType humanType)
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
            tamas.birth = new DateTime(2001, 4, 30);
            tamas.type = HumanType.STUDENT;

            //Console.WriteLine($"Name: {tamas.name} \t Birth: {tamas.birth.ToString("yyyy. MM. dd")} \t Type: {tamas.type}");

            List<Human> humans = new List<Human>();

            humans.Add(tamas);

            Human peter = new Human();
            peter.name = "Péter";
            peter.birth = new DateTime(2002, 10, 2);
            peter.type = HumanType.TEACHER;

            humans.Add(peter);

            for(int i = 0; i < humans.Count; i++)
            {
                //1. lehetőség
                Human temp = humans[i];
                Console.WriteLine($"Name: {temp.name} \t Birth: {temp.birth.ToString("yyyy. MM. dd")} \t Type: {ConvertHumanTypeToString(temp.type)}");

                //2. lehetőség
                Console.WriteLine($"Name: {humans[i].name} \t Birth: {humans[i].birth.ToString("yyyy. MM. dd")} \t Type: {ConvertHumanTypeToString(humans[i].type)}");

            }

            HumanType type = HumanType.STUDENT;

            Console.ReadLine();
        }
    }
}
