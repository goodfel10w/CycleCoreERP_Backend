using CycleCoreERP_Backend.Models;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Mvc;


namespace CycleCoreERP_Backend.Service
{
    public static class XMLService
    {
        private static Models.Results _pr;

        public static void xmlRead(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(Models.Results), new XmlRootAttribute("results"));
            // Umwandlung in ein String ist später nicht mehr notwendig
            string xmlContent = File.ReadAllText(xml);
            byte[] byteArray = Encoding.ASCII.GetBytes(xmlContent);

            MemoryStream stream = new MemoryStream(byteArray);

            var result = (Models.Results)xmlSerializer.Deserialize(stream);
            _pr = result;
        }

        public static int GetArtikelBestand(int id)
        {
            return _pr.warehousestock.article.Single(artikel => artikel.id == id).amount;
        }

        public static int GetAnzahlArtikelInWarteschlangen(int id)
        {
            return _pr.waitinglistworkstations
            .Where(arbeitsplatz => arbeitsplatz.timeneed != 0)
            .SelectMany(arbeitsplatz => arbeitsplatz.waitinglist)
            .Where(artikel => artikel.item == id)
            .Sum(menge => menge.amount)
            +
            _pr.waitingliststock
            .Where(fehlendeTeile => fehlendeTeile.id != 0)
            .SelectMany(arbeitsplatz => arbeitsplatz.waitinglist)
            .Where(artikel => artikel.item == id)
            .Sum(menge => menge.amount);

        }

        public static int GetAnzahlArtikelInBearbeitung(int id)
        {
            return _pr.ordersinwork
            .Where(artikel => artikel.item == id)
            .Sum(menge => menge.amount);
        }

        public static int GetVergangenePeriode()
        {
            return _pr.period;
        }
    }
}