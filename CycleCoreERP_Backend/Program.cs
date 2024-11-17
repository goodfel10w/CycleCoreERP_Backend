using System;
using System.IO;
using System.Xml.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Verzeichnis mit XML-Dateien
string directoryPath = "/CycleCoreERP_Backend/xml-files/result";  // Dein XML-Dateipfad

// Verzeichnis durchsuchen und alle XML-Dateien laden
if (Directory.Exists(directoryPath))
{
    string[] xmlFiles = Directory.GetFiles(directoryPath, "*.xml");

    foreach (string xmlFile in xmlFiles)
    {
        // Lade jede XML-Datei
        XDocument xdoc = XDocument.Load(xmlFile);
        
        // Beispiel: Ausgabe des Wurzels und ersten Elements
        var settingValue = xdoc.Root.Element("Setting")?.Value;
        Console.WriteLine($"Loaded {Path.GetFileName(xmlFile)}: Setting = {settingValue}");
    }
}
else
{
    Console.WriteLine($"Das Verzeichnis {directoryPath} wurde nicht gefunden.");
}

// Add services to the container
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// MapControllerRoute für Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HelloWorld}/{action=LoadXml}/{fileName?}");

app.Run();
