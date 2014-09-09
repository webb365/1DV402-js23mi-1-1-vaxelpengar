using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar_js23mi{
    class Program{
        static void Main(string[] args){
              do {
                  Console.WriteLine("Du är bäst!");
              } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        private static double ReadPositiveDouble(string prompt){
            double sum = 6.76;

            return sum;
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
