using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLocation
{
    public static class Test1
    {
        public static void StartLocationWatcher()
        {
            string latitude = "<empty>";
            string longitude = "<empty>";
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);

            watcher.MovementThreshold = 20; // Use MovementThreshold to ignore noise in the signal.

            watcher.StatusChanged += (o, args) =>
            {
                switch (args.Status)
                {
                    case GeoPositionStatus.Ready:
                        // Use the Position property of the GeoCoordinateWatcher object to get the current location.
                        GeoCoordinate co = watcher.Position.Location;

                        latitude = co.Latitude.ToString("0.000");
                        longitude = co.Longitude.ToString("0.000");

                        //Stop the Location Service to conserve battery power.

                        watcher.Stop();
                        break;
                }
            };
            watcher.Start();

            Console.WriteLine(string.Format("{0} - {1}", latitude, longitude));
            Console.ReadLine();
        }
    }
}
//GeoCoordinateWatcher watcher;
//watcher = new GeoCoordinateWatcher();

//watcher.PositionChanged += (sender, e) =>
//{
//    var coordinate = e.Position.Location;
//    Console.WriteLine("Lat: {0}, Long: {1}", coordinate.Latitude,
//        coordinate.Longitude);
//    // Uncomment to get only one event.
//    // watcher.Stop(); 
//};

//// Begin listening for location updates.
//watcher.Start();
//Console.ReadLine();