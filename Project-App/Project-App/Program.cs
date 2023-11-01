using Project_App;

Console.WriteLine("Welcome to Woof ya doin? The app to track your dogs' activity.");
Console.WriteLine("What's your dog's name?");

var dogsname = Console.ReadLine();
Console.WriteLine("How old is your dog?");
var dogsage = Console.ReadLine();
var dog = new Dog(dogsname, dogsage);
Console.WriteLine($"Hello {dog.Name}, nice to meet you !");
