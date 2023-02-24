using System;
namespace Module6
{
    public class PermanentEmployee : Employee
    {
        public int Salary { get; set; }

        public override void PrintSalaryNote() {
            base.PrintHeader();
            Console.WriteLine("Type: Fastansat");
            string salaryTxt = String.Format("{0,8}", Salary);
            Console.WriteLine("Månedsløb\t\t\t" + salaryTxt + " kr");
            Console.WriteLine("Fradrag " + TaxDeduction + " kr");
            int nettoPayment = Salary;
            int taxToPay = (Salary - TaxDeduction) * TaxPrecentage / 100;
            nettoPayment = Salary - taxToPay;
            string taxToPayTxt = String.Format("{0, 8}", taxToPay);
            Console.WriteLine("Skat: " + TaxPrecentage + "% af " + (Salary - TaxDeduction) + "kr \t\t" + taxToPayTxt + " kr");
            if (IsMemberOfLunch)
            {
                string lunchTxt = String.Format("{0, 8}", 350);
                Console.WriteLine("Frokostordning\t\t\t" + lunchTxt + " kr"); ;
                nettoPayment = nettoPayment - 350;
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

