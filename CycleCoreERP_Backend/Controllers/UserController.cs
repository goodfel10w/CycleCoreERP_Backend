using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Linq;
using System.Linq;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/LoadXml/{fileName}
        public IActionResult LoadXml(string fileName)
        {
            // Sicherstellen, dass der fileName nicht null oder leer ist
            if (string.IsNullOrEmpty(fileName))
            {
                return Content("Kein Dateiname angegeben.");
            }

            // Pfad zur XML-Datei
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "xml-files", "result", fileName);

            // Überprüfen, ob die Datei existiert
            if (System.IO.File.Exists(filePath))
            {
                XDocument xdoc = XDocument.Load(filePath);

                // Konvertiere das XML in eine Liste von Objekten (z.B. Dictionary oder benutzerdefinierte Klassen)
                var data = xdoc.Descendants("Item")
                               .Select(item => new
                               {
                                   Name = item.Element("Name")?.Value,
                                   Value = item.Element("Value")?.Value
                               }).ToList();

                // Gib die Daten als JSON zurück
                return Json(data);
            }
            else
            {
                return Content($"Die Datei '{fileName}' wurde nicht gefunden.");
            }
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
