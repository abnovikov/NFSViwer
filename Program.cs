using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFSConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var probe = new Probe()
            {
                Field = "H"
            };
            var measurement = new Measurement()
            {
                List = @"26e-3 29e-3 2e-3 -58 22 -60 35 -59 42 -55 51 ",
                Format = "ma"
            };
            var data = new Data()
            {
                Coordinates = "xyzcf",
                Frequencies = new Frequencies()
                {
                    //List = @"100 200 300 400",
                    //                    A.3 File with field azimuth and zenith orientation
                    List = @"  26e-3 29e-3 2e-3 0 0 - 58 - 60 - 59 - 55
                            26e-3 29e-3 2e-3 0 90 - 58 - 60 - 59 - 55
                            26e-3 29e-3 2e-3 90 90 - 58 - 60 - 59 - 55",
                    Unit = "MHz"
                },
                Measurement = measurement
            };

            EmissionScan emissionscan = new EmissionScan()
            {
                File_ver = "1",
                Nfs_ver = "1.0",
                Data_source = "measurement",
                Date = DateTime.Now,
                Source = "measurement",
                Disclaimer = "As is",
                Copyright = "Alex Ltd",
                Probe = probe,
                Data = data,
                Filename = "MyFile"
            };
        XmlSerializer serializer = new XmlSerializer(typeof(EmissionScan));
            serializer.Serialize(Console.Out, emissionscan);
            Console.ReadLine();

        }
    }
}
