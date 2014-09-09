using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar_js23mi{
    class Program{
         static void Main(string[] args){
              do {
                 Console.WriteLine( ReadPositiveDouble(Properties.Resources.Total_sum));
              } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static double ReadPositiveDouble(string prompt){
            double sum;
            while (true) {
                Console.Write(prompt);
                try{
                    sum = Math.Round(double.Parse(Console.ReadLine()));
                    if (sum < 1){
                        throw new Exception();
                    }
                    return sum;
                }
                catch {
                    // använd  viewmessage när det blir klart
                    Console.WriteLine("FEL");
                } 
            }

        }

        private static uint ReadUint(string prompt, uint minValue){

            return 99;
        }

        private static uint[] SplitIntoDenominations(uint change, uint[] denominations){
            denominations= new uint[]{55,76};

            return denominations;
        }

        private static void ViewMessage(string message,bool isError = false) {

        }

        private static void ViewReceipt(double subtotal, double roundingOffAmount, uint total, uint change, uint[] notes, uint[] denominations){

        }
    
    }
}
