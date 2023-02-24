using System;
namespace Module6
{
    public class SalaryApp
    {
        List<Employee> mEmp = new List<Employee>();

        public SalaryApp()
        {

        }

        public void Init() {
            PermanentEmployee anders = new PermanentEmployee
            {
                Name = "Ander And",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                Salary = 23000,
                IsMemberOfLunch = true,
                IsMemberGiftbox = false
            };
            ParttimeEmployee jens = new ParttimeEmployee
            {
                Name = "jens",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 123,
                Hours = 110
            };
            PermanentEmployee peter = new PermanentEmployee
            {
                Name = "peter",
                Address = "byvej 12",
                Email = "peter@peter.com",
                TaxDeduction = 5000,
                TaxPrecentage = 32,
                Salary = 23000,
                IsMemberOfLunch = false,
                IsMemberGiftbox = false
            };
            ParttimeEmployee gert = new ParttimeEmployee
            {
                Name = "Gert",
                Address = "byvej 14",
                Email = "jens@jens.com",
                TaxDeduction = 6700,
                TaxPrecentage = 54,
                HourlySalary = 123,
                Hours = 110,
                IsMemberOfLunch = true
            };

            mEmp.Add(anders);
            mEmp.Add(jens);
            mEmp.Add(peter);
            mEmp.Add(gert);

            foreach (Employee emp in mEmp) {
                emp.PrintSalaryNote();
         
            }
        }
    }
}

