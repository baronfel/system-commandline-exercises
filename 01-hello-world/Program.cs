namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
    }

    /// <summary>
    /// Greet someone politely
    /// </summary>
    /// <param name="person">The name of the person to greet. This will be provided by an end user on the command line.</param>
    void Greet(string person) => Console.WriteLine($"Hello, {person}");
}

