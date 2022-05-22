using System;
namespace intermediate
{
    public class boardMarker
    {
        public boardMarker()
        {
        }
        public string color = "white";
        public int content = 100;
        public void write(string msg)
        {
            content--;
            Console.WriteLine(msg);
            Console.WriteLine("Remaining ink: " + content);
        }
        public void refill()
        {
            content++;
            Console.WriteLine("Remaining ink: " + content);
        }
        public void changeColor(string userColor) {
            color = userColor;
            switch (color)
            {
                case "White":
                    color = "white";
                    break;
                case "Blue":
                    color = "blue";
                    break;
                case "Red":
                    color = "red";
                    break;
                default:
                    color =
           "white";
                    break;
            }

            Console.WriteLine("Marker Color: " + color);
        }
        public void checkStatus()
        {
            Console.WriteLine("Remaining ink: " + content);
            Console.WriteLine("Marker Color: " + color);
        }
    }
}