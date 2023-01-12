// See https://aka.ms/new-console-template for more information
using Session_04;
using System.Globalization;
//Exercise one - Print a message
ExerciseOne exerciseOne= new ExerciseOne();
Console.WriteLine(exerciseOne.GetMessage());
//Exercise two - Get a summary and a division of two numbers
ExerciseTwo exerciseTwo= new ExerciseTwo();
Console.WriteLine("The summary is : " + exerciseTwo.getSum());
Console.WriteLine("The summary is : " + exerciseTwo.getDiv());
//Exercise three - Print the result of five operations
ExerciseThree exerciseThree = new ExerciseThree();
Console.WriteLine("First example: " + exerciseThree.getFirstExample());
Console.WriteLine("Second example: " + exerciseThree.getSecondExample());
Console.WriteLine("Third example: " + exerciseThree.getThirdExample());
Console.WriteLine("Fourth example: " + exerciseThree.getFourthExample());
Console.WriteLine("Fifth example: " + exerciseThree.getFifthExample());
//Exercise four - Print a message
ExerciseFour exerciseFour = new ExerciseFour();
Console.WriteLine(exerciseFour.getMessage());
//Exercise five - Convert seconds to minutes, hours, days and years
ExerciseFive ExerciseFive = new ExerciseFive();
Console.WriteLine("There are " + ExerciseFive.getYears() + " years, " + ExerciseFive.getDays() + " days, " + ExerciseFive.getHours() + " hours and " + ExerciseFive.getMinutes() + " minutes.");
//Exercise six - Convert seconds to minutes, hours, days and years using .Net Libraries
ExerciseSix exerciseSix = new ExerciseSix();
Console.WriteLine("There are " + ExerciseFive.getYears() + " years, " + ExerciseFive.getDays() + " days, " + ExerciseFive.getHours() + " hours and " + ExerciseFive.getMinutes() + " minutes.");
//Exercise seven - Convert celsius degrees to Kelvin and Fahrenheit
ExerciseSeven exerciseSeven = new ExerciseSeven();  
Console.WriteLine("The temperature in Kelvin is : " + exerciseSeven.getKelvin());
Console.WriteLine("The temperature in Fahrenheit is : " + exerciseSeven.getFahrenheit());



