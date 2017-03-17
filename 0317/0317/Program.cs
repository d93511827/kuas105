using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _0317
{
    class Program
    {
        static void Main(string[] args)
        {
            var stations = Findstations();
        }
        public static List<station> Findstations()
        {
            List<station> stations = new List<station>();
            var xml = XElement.Load(@"C:\Users\user\Desktop\git\0317\data.xml");
            XNamespace gml = @"http://www.opengis.net/gml/3.2";
            XNamespace twed = @"http://twed.wra.gov.tw/twedml/opendata";
            var stationsNode = xml.Descendants(twed + "RiverStageObservatoryProfile").ToList();

            return stations;
        }
    }
}
