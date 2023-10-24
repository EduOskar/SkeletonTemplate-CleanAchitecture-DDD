namespace WebApiSwagger.Logging;

public class Logging : ILogging
{
    public void Log(string message, string type)
    {
        if (type == "Error")
        {
            Console.WriteLine("Error - " + message);
        }
        else
        {
            if (type =="warning")
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error - " + message);
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
