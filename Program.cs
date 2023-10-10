namespace Lab4_A1
{    
    class Program
    {
        static void Main()
        {
            WriteMessage(SeverityLevel.High, "High severity message");
            WriteMessage(SeverityLevel.Warning, "Warning message");
            WriteMessage(SeverityLevel.Info, "Info message");
            WriteMessage(SeverityLevel.Debug, "Debug message");

            string answer = "n";
            Console.WriteLine("Do you want to insert a message y/n");
            answer = Console.ReadLine();

            if (answer.ToLower() == "y")
            {
                Console.WriteLine("Insert the message:");
                string message = Console.ReadLine();

                Console.WriteLine("Insert the severity level (High, Warning, Info, or Debug):");
                SeverityLevel severity;
                Enum.TryParse(Console.ReadLine(), out severity);

                WriteMessage(severity, message);
            }
        }

        enum SeverityLevel
        {
            High,
            Warning,
            Info,
            Debug
        }

        static void WriteMessage(SeverityLevel severity, string message)
        {
            ConsoleColor color = ConsoleColor.White;
            switch (severity)
            {
                case SeverityLevel.High:
                    color = ConsoleColor.Red;
                    break;
                case SeverityLevel.Warning:
                    color = ConsoleColor.DarkYellow;
                    break;
                case SeverityLevel.Info:
                    color = ConsoleColor.White;
                    break;
                case SeverityLevel.Debug:
                    color = ConsoleColor.Gray;
                    break;
            }
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

}