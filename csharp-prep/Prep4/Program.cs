using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int>numbers;
        numbers=new List<int>();
        int answer=-1;
        while(answer!=0){
            Console.WriteLine("Enter a number: ");
            string userInput=Console.ReadLine();
            answer=int.Parse(userInput);
            if(answer!=0){
             numbers.Add(answer);}}

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
         Console.WriteLine($"The sum is:{sum} ");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is:{average} ");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            { max = number;
            }
        }
        
        
        Console.WriteLine($"The largest number is:{max}");
        
        
}
}