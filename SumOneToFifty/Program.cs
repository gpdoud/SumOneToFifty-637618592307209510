using System;

namespace SumOneToFifty {
    class Program {
        static void Main(string[] args) {

            var sum = 0;

            for(var i = 1; i <= 50; i++) {

                if(i % 5 == 0 || i % 7 == 0) {
                    sum = sum + i;
                }

            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
