using OPP1.Employees;
using static OPP1.Employees.employee;
namespace OPP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1,Q2
            employee e1 = new employee(10, "Soher", SecurityLevel.guest, 10000, new Hiringdate(31,12,2024),Gender.Female);
            Console.WriteLine(e1);
            #endregion

            #region Q3
            employee[] EmpArr = new employee[3];
            try
            {
                EmpArr[0] = new employee(1, "Ahmed", SecurityLevel.DBA, 12000, new Hiringdate(10, 3, 2020),Gender.Male);
                EmpArr[1] = new employee(2, "Nour", SecurityLevel.guest, 4000, new Hiringdate(5, 8, 2023),Gender.Female);
                EmpArr[2] = new employee(3, "Omar", SecurityLevel.Developer, 15000, new Hiringdate(1, 1, 2021),Gender.Male);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            foreach (employee emp in EmpArr)
            {
                if (emp != null)
                    Console.WriteLine(emp);
            }
            #endregion
            Array.Sort(EmpArr, new ReverseClass());

            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
