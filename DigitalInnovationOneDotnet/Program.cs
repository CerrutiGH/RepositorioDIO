using System;
namespace DigitalInnovationOneDotnet{
    class Program{
        static void Main(string[] args){

            int numVezes = 5;
            for (int i=0; i < numVezes; i++){
                if(i%2==0){
                    Console.WriteLine($"O número {i} é par");
                }
              else{
                    Console.WriteLine($"O número {i} é impar");
              }

            }
            

        }
    }
}
// See https://aka.ms/new-console-template for more information
