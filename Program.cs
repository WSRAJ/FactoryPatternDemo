using FactoryPatternDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter shape (circle/square): ");
        string input = Console.ReadLine();

        try
        {
            IShape shape = ShapeFactory.GetShape(input);
            shape.Draw();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.ReadLine();
    }
}