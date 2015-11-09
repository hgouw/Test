using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocation
{
    class Program
    {
        static void Main(string[] args)
        {
            double latitude;
            double longitude;
            GetLocation(out latitude, out longitude);
            Console.WriteLine(string.Format("Latitude = {0} - Longitude = {1}, latitude, longitude"));
            Console.ReadLine();
        }

        static void GetLocation(out double latitude, out double longitude)
        {
            latitude = longitude = 0;

            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            for (int i = 0; i < 5; i++)
            {
                watcher.TryStart(false, // Do not suppress permissions prompt.
                   TimeSpan.FromMilliseconds(1000)); // Wait 1000 ms to start.

                GeoCoordinate coord = watcher.Position.Location;

                if (coord.IsUnknown != true)
                {
                    latitude = watcher.Position.Location.Latitude;
                    longitude = watcher.Position.Location.Longitude;
                    break;
                }
            }
        }
    }
}
