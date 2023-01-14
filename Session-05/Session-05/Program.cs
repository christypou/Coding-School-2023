// See https://aka.ms/new-console-template for more information
using Session_05;
ExerciseOne exerciseOne = new ExerciseOne();
Console.WriteLine("Give me a name:");
string name = Console.ReadLine();
Console.WriteLine(exerciseOne.convertName(name));

//Exercise Two - Ask for a number and the user chooses for sum or product
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

//Exercise Three - Give a number and find all the prime number from 1 to n

Console.WriteLine("Give a number :");
int number2 = Convert.ToInt32(Console.ReadLine());
while (number2 < 2)
{
    Console.WriteLine("Please give a valid number. ");
    number2 = Convert.ToInt32(Console.ReadLine());
}
ExerciseThree exerciseThree= new ExerciseThree();
for (int j = 1; j <= number2; j++)
{
    exerciseThree.findPrimes(j);
}


// Exercise Four - Multiply array1 and array2 and save result to array3
ExerciseFour exerciseFour = new ExerciseFour();
int[] array1 =  { 2, 4, 9, 12 };
int[] array2 =  { 1, 3, 7, 10 };
int arrayLength = array1.Length*array2.Length;
int[] array3 = new int[arrayLength];
int counter = 0;
for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)
    {
        array3[counter] = exerciseFour.multiplyNumber(array1[i] , array2[j]);
        counter++;
    }
}
Console.WriteLine("The new array is: ");
foreach (int num in array3)
{
    Console.WriteLine(num + " ");
}

//Exercise Five - Bubble sort int array

    int[] array4= { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
ExerciseFive exerciseFive = new ExerciseFive();
exerciseFive.bubbleSort(array4);
foreach (int num in array4)
    Console.Write(num + " ");
Console.ReadLine();
