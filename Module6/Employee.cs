using System;
namespace Module6
{
    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int TaxDeduction { get; set; }
        public int TaxPrecentage { get; set; }

        public bool IsMemberOfLunch { get; set; } = false;
        public bool IsMemberGiftbox { get; set; } = false;

        public void PrintHeader() {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Email);
        }

        public virtual void PrintSalaryNote() {
            Console.WriteLine("Det er noget bras...");
        }
    }
}

