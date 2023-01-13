// See https://aka.ms/new-console-template for more information
//Exercise Two - Ask for a number and the user chooses for sum or product
using Session_05;

ExerciseTwo exerciseTwo = new ExerciseTwo();
Console.WriteLine("Give me a number:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("If you want the sum press 1");
Console.WriteLine("If you want the product press 2");
int option = Convert.ToInt32(Console.ReadLine());

while (option != 1 && option != 2)
{
    Console.WriteLine("Please give a valid option. ");
    option = Convert.ToInt32(Console.ReadLine());
}
if (option == 1)
{
    Console.WriteLine("The sum is: "+exerciseTwo.GetSum(number));
}
else if (option == 2)
{
    Console.WriteLine("The product is: " + exerciseTwo.GetProduct(number));
}

