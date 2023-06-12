using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int number = randomGenerator.Next(1, 100);
       int answer = -1;
       
       while(answer!=number){
        Console.WriteLine("what´s the number?: ");
        string userInput=Console.ReadLine();
        answer=int.Parse(userInput);

        if(answer>number){
            Console.WriteLine("Lower");
        
            }
        else if(answer<number){
            Console.WriteLine("Higher");
        }
        else{
            Console.WriteLine("You guessed it");
        }
       }
       
    }
}