
// Method overloads

// Overload in a build methods
 Console.WriteLine("Hello!"); // WriteLine can take a string (This is one overload)

 Console.WriteLine(1234); // another overload (numbers)

 Console.WriteLine('A'); // Another Overload ( Characters )

 static void Greet(string data)
{
    Console.WriteLine(data);
}


 static void Greet(int data)
{
    Console.WriteLine(data);
}


Greet("Hi There");
Greet(1234);