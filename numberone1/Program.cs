using Zadanie2;

namespace Zadanie2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student ( firstName: "Томас", lastName: "Шелби", group: "ИСП", averageMark: 5);
            Console.WriteLine("Стипендия студента: " + student.getScholarship());
            student.PrintStudent();
            Aspirant aspirant = new Aspirant(firstName: "Иван", lastName: "Иванов", group: "ПД", averageMark: 4, work: "Безопасность на улице" );
            Console.WriteLine("Стипендия аспиранта: " + aspirant.getScholarship());
        }
    }
}
