using CycleCoreERP_Backend.Models;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace CycleCoreERP_Backend.Service
{
    public static class XMLService
    {
        private static Models.Results _pr;

        public static void xmlRead(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(Models.Results), new XmlRootAttribute("results"));
            string xmlContent = File.ReadAllText(xml);
            byte[] byteArray = Encoding.ASCII.GetBytes(xmlContent);

            MemoryStream stream = new MemoryStream(byteArray);

            var result = (Models.Results)xmlSerializer.Deserialize(stream);
            _pr = result;
        }
    }
}