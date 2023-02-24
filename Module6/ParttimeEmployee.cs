using System;
namespace Module6
{
    public class ParttimeEmployee : Employee
    {
        public int HourlySalary { get; set; }
        public int Hours { get; set; }

        public override void PrintSalaryNote()
        {
            base.PrintHeader();
            int salary = Hours * HourlySalary;
            Console.WriteLine("Type: Deltidsansat");
            string salaryTxt = String.Format("{0,8}", salary);
            Console.WriteLine("" + Hours + " timer af " + HourlySalary + "kr\t\t" + salaryTxt + " kr");
            Console.WriteLine("Fradrag " + TaxDeduction + " kr");
            int nettoPayment = salary;
            int taxToPay = (salary - TaxDeduction) * TaxPrecentage / 100;
            nettoPayment = salary - taxToPay;
            string taxToPayTxt = String.Format("{0, 8}", taxToPay);
            Console.WriteLine("Skat: " + TaxPrecentage + "% af " + (salary - TaxDeduction) + "kr \t\t" + taxToPayTxt + " kr");
            if (IsMemberOfLunch)
            {
                int lunchToPay = 350 * 70 / 100;
                string lunchTxt = String.Format("{0, 8}", lunchToPay);
                Console.WriteLine("Frokostordning\t\t\t" + lunchTxt + " kr"); ;
                nettoPayment = nettoPayment - lunchToPay;
            }
            if (IsMemberGiftbox)
            {
                string presentTxt = String.Format("{0,8}", 30);
                Console.WriteLine("Gavekassen\t\t\t" + presentTxt + " kr");
                nettoPayment = nettoPayment - 30;
            }
            string nettoTxt = String.Format("{0,8}", nettoPayment);
            Console.WriteLine("Nettoløn\t\t\t" + nettoTxt + " kr");
            Console.WriteLine("===========================================");
        }

    }
}

