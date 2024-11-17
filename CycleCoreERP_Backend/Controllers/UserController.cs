using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Linq;

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
                // Lade die XML-Datei in ein XDocument
                XDocument xdoc = XDocument.Load(filePath);

                // Gib das XML-Dokument als XML-String zurück
                return Content(xdoc.ToString(), "application/xml");
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