using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string nameresult= PropmtUserName();
        int numberresult=PromptUserNumber();
        int squareresult=SquareNumber(numberresult);
        DisplayResults(nameresult,squareresult);}
    
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!")

       }
    static string PropmtUserName(){
        Console.WriteLine("Please enter your name: ");
        string name=Console.ReadLine();
        Console.WriteLine(name);
        return name;
       }
    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number ");
        int userNumber=int.Parse(Console.ReadLine());
        Console.WriteLine(userNumber);
        return userNumber;        
       }
    static int SquareNumber(int number){
        int powNumber=number*number;
        return powNumber;

       }
    static void DisplayResults(string name,int number){
        Console.WriteLine($"Brother {name}, the square of your number is {number}");
       }
    
}