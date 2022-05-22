using System;
namespace intermediate
{
    public class boardMarker : IDisposable
    {
        public boardMarker()
        {
        }
        public string color = "white";
        public int content = 100;
        private bool disposedValue;

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

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~boardMarker()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}