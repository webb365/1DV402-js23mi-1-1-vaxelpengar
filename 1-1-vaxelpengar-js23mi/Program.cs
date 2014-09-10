using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar_js23mi{
    class Program{
         static void Main(string[] args){
              do {
                  Console.Clear();
                   double total = ReadPositiveDouble(Properties.Resources.Total_Sum);// Klar Total
                   uint payTotal = (uint)Math.Round(total);// Klar Att Betala
                   double roundingOffAmount = payTotal - total; // Klar Öresavrundning
                   uint moneyRecived = ReadUint(Properties.Resources.Money_Recived, payTotal); // Klar Kontant
                   uint rest = moneyRecived - payTotal; // Klar Tillbaka 
                   uint[,] denominations = { { 500, 0 }, { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 }, { 1, 0 } };// Går ändra utan problem
                   denominations = SplitIntoDenominations(rest, denominations);// Retunerar antal av varje sedel/mynt
                   ViewReceipt(total,roundingOffAmount,moneyRecived, payTotal,rest,denominations); // funkar
                   ViewMessage(Properties.Resources.Continue_Prompt);
              } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static double ReadPositiveDouble(string prompt){
            double sum;
            string input;
            while (true) {
                Console.Write(prompt);
                input = Console.ReadLine();
                try{
                    sum = double.Parse(input);
                    if (Math.Round(sum) < 1){
                        throw new Exception();
                    }
                    return sum;
                }
                catch {
                    ViewMessage(String.Format(Properties.Resources.Wrong_amount, input), true);
                } 
            }

        }

        private static uint ReadUint(string prompt, uint minValue){
            uint cashRecived;
            string input;
            while (true) {
                Console.Write(prompt);
                input = Console.ReadLine();
                try{
                    cashRecived = uint.Parse(input);
                    if (cashRecived < minValue) {
                        throw new Exception();
                    }
                    return cashRecived;
                }
                catch {
                    ViewMessage(String.Format(Properties.Resources.To_small, input), true);
                }
            }
        }

        private static uint[,] SplitIntoDenominations(uint change, uint[,] denominations){
            for (int i = 0; i < denominations.GetLength(0); i++) {
                if (change / denominations[i, 0] >= 1) {
                    denominations[i, 1] = change / denominations[i, 0];
                    change %= denominations[i, 0];
                }

            }
            return denominations;
        }

        private static void ViewMessage(string message,bool isError = false) {       
            if (isError){
                Console.BackgroundColor = ConsoleColor.Red;
            }else{
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            Console.WriteLine("\n {0}", message);
            Console.ResetColor();
        }

        private static void ViewReceipt(double subtotal, double roundingOffAmount,uint recived, uint total, uint change, uint[,] denominations){
            Console.WriteLine("\nKvitto\n------------------------------------");
            Console.WriteLine("Totalt              :{0,15:c}",subtotal);
            Console.WriteLine("Öresavrundning      :{0,15:c}", roundingOffAmount);
            Console.WriteLine("Att betala          :{0,15:c}", total);
            Console.WriteLine("Kontant             :{0,15:c}", recived);
            Console.WriteLine("Tillbaka            :{0,15:c}", change);
            Console.WriteLine("------------------------------------");
            for (int i = 0; i < denominations.GetLength(0); i++) {
                if (denominations[i, 1] != 0)
                {
                     Console.WriteLine("{0,3}-lappar : {1,3}", denominations[i, 0], denominations[i, 1]);
                }
            }
        }
    
    }
}
