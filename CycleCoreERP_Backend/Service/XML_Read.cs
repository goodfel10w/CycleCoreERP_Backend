using System;
using System.Xml.Serialization;
using CycleCoreERP_Backend.Models;
using System.IO;
using System.Text;

namespace CycleCoreERP_Backend.Service
{
    public static class XMLService
    {
        private static PeriodenResult _pr;

        public static void xmlRead(string xml)
        {


            var xmlSerializer = new XmlSerializer(typeof(PeriodenResult), new XmlRootAttribute("PeriodenResult"));

            string xmlContent = File.ReadAllText(filePath);
            Console.WriteLine("XML Content: " + xmlContent);

            var result = (PeriodenResult)xmlSerializer.Deserialize(xmlContent);
            _pr = result;
        }
    }
}