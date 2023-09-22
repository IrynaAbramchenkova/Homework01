// See https://aka.ms/new-console-template for more information
//var name = "";
//Console.WriteLine("What is your name?");
//name = Console.ReadLine();
//Console.WriteLine($"Hello,{name}!");
//Console.WriteLine("Nice to meet you!");
//Console.ReadLine();

string Meet()
{
    Console.WriteLine("What's your name?");
    return Console.ReadLine();
}

void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}
var name = Meet();
Greet(name);


//Console.WriteLine("What's your name?");
//var name = Console.ReadLine();
//Console.WriteLine($"Hello, {name}!");

//Console.WriteLine($"Hello, has {"Hello,".Length} letters");