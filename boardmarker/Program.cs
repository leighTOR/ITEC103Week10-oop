using System;

namespace intermediate
{
    class mainProgram
    {
        public static void Main(string[] args)
        {
            boardMarker myMarker = new boardMarker();
            int choice = 0;
            string msg = string.Empty;
            string userColor = string.Empty;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] Write");
                Console.WriteLine("[2] Refill");
                Console.WriteLine("[3] Change Color");
                Console.WriteLine("[4] Check Status");
                Console.WriteLine("[5] Dispose");
                Console.WriteLine("--------------");
                Console.Write("Command: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("\n");
                        Console.Write("Message: ");
                        Console.Write("\n");
                        msg = Console.ReadLine();

                        switch (myMarker.color)
                        {
                            case "blue":
                                Console.ForegroundColor =
                                ConsoleColor.Blue;
                                break;
                            case "red":
                                Console.ForegroundColor =
                                ConsoleColor.Red;
                                break;
                        }
                        Console.Write("\n");
                        myMarker.write(msg);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.WriteLine();
                        myMarker.refill();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Choose from: White, Blue and Red");
                        Console.Write("Color: ");
                        userColor = Console.ReadLine();
                        Console.Write("\n");
                        myMarker.changeColor(userColor);
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine();
                        myMarker.checkStatus();
                        Console.ReadKey(true);
                        break;
                    case 5:
                        Console.WriteLine();
                        myMarker.Dispose();
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid command...");
                        Console.ReadKey(true);
                        break;
                }
            }
        }
    }
}