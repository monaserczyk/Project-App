using Project_App;

Console.WriteLine("Welcome to Woof ya doin? The app to track your dogs' activity.");
Console.WriteLine("What's your dog's name?");

var dogsname = Console.ReadLine();
Console.WriteLine("How old is your dog (years)?");

string dogsage = (Console.ReadLine());
float yearsOld;

if (float.TryParse(dogsage, out yearsOld))
{
  // Konwersja się powiodła, możesz używać zmiennej liczba jako float
}
else
{
    Console.WriteLine("Wprowadzone dane nie były liczbą zmiennoprzecinkową");
}
var dog = new Dog(dogsname, yearsOld);

Console.WriteLine($"Hello {dog.Name}, nice to meet you !");
if (yearsOld < 8)
{
    Console.WriteLine("I see you are an adult dog.");

}
else
{
    Console.WriteLine("I see we have a senior dog here.");
}
Console.WriteLine("How much time (min) did you spend on walks today?");
var walkingTime = Console.ReadLine();
Console.WriteLine("How much time (min) did you spend on training today (not included in walk's time)?");
var trainingTime = Console.ReadLine();
Console.WriteLine("How much time (min) did you spend on cuddles with your dog?");
var cuddlingTime = Console.ReadLine();
Console.WriteLine("Does it mean that for the rest of the day your dog was resting/sleeping?");
var answer = Console.ReadLine();
if (answer == "yes")
{

}
else
{
    Console.WriteLine("How much time did that other activity take?");
    var otherActivity = Console.ReadLine();
}